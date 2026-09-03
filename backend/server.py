import os
import json
import datetime
import urllib.parse
from typing import Optional, List, Dict, Any

from fastapi import FastAPI, Request, HTTPException
from fastapi.responses import PlainTextResponse, JSONResponse, HTMLResponse, FileResponse
from fastapi.staticfiles import StaticFiles
from fastapi.middleware.cors import CORSMiddleware
import psycopg2
from psycopg2.extras import RealDictCursor
import uvicorn

app = FastAPI(title="Sungshin Order Management Server", version="3.18")

app.add_middleware(
    CORSMiddleware,
    allow_origins=["*"],
    allow_credentials=True,
    allow_methods=["*"],
    allow_headers=["*"],
)

STATIC_DIR = os.path.join(os.path.dirname(os.path.abspath(__file__)), "static")
os.makedirs(STATIC_DIR, exist_ok=True)
app.mount("/static", StaticFiles(directory=STATIC_DIR), name="static")

def get_db():
    conn = psycopg2.connect(
        dbname="reception",
        user="postgres",
        host="localhost",
        port=5432
    )
    conn.set_client_encoding('UTF8')
    return conn

async def parse_body_and_params(request: Request):
    params = dict(request.query_params)
    body_bytes = await request.body()
    body_str = body_bytes.decode("utf-8", errors="replace")
    form = {}

    if body_str.startswith("args="):
        raw_json = body_str[5:]
        try:
            form["args"] = json.loads(raw_json)
        except Exception:
            try:
                form["args"] = json.loads(urllib.parse.unquote_plus(raw_json))
            except Exception:
                pass
    elif body_str.startswith("{") and body_str.endswith("}"):
        try:
            form = json.loads(body_str)
        except Exception:
            pass
    elif body_str:
        parsed = urllib.parse.parse_qs(body_str, keep_blank_values=True)
        for k, v in parsed.items():
            form[k] = v[0] if v else ""

    return params, form

@app.api_route("/", methods=["GET", "HEAD"])
@app.api_route("/tmserver", methods=["GET", "HEAD"])
@app.api_route("/tmserver/", methods=["GET", "HEAD"])
def serve_spa():
    index_path = os.path.join(STATIC_DIR, "index.html")
    if os.path.exists(index_path):
        return FileResponse(index_path)
    return HTMLResponse("<h1>성신판매접수 서버 실행 중 (static/index.html 준비 중)</h1>")

# ==========================================
# MODERN REST API FOR WEB DESKTOP APP
# ==========================================

@app.post("/api/login")
async def api_login(request: Request):
    data = await request.json()
    user_id = str(data.get("id", "")).strip()
    user_pw = str(data.get("pw", "")).strip()

    conn = get_db()
    cur = conn.cursor(cursor_factory=RealDictCursor)
    cur.execute("""
    SELECT a.account_code, a.acgb_code, b.acgb, a.team_code, c.team,
           a.account_id as id, a.account_pw as pw, a.account_name as name,
           a.allow_ip, cti.idx as cti_idx
    FROM ss_account a
    LEFT JOIN ss_accountgb b ON a.acgb_code = b.acgb_code
    LEFT JOIN ss_team c ON a.team_code = c.team_code
    LEFT JOIN cti_agents cti ON a.account_code = cti.account_idx
    WHERE a.account_id = %s
    """, (user_id,))
    row = cur.fetchone()
    cur.close()
    conn.close()

    if not row or str(row["pw"]) != user_pw:
        return JSONResponse({"status": "error", "message": "아이디 또는 비밀번호가 올바르지 않습니다."}, status_code=400)

    now_str = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")
    return {
        "status": "ok",
        "user": {
            "account_code": row["account_code"],
            "id": row["id"],
            "name": row["name"],
            "acgb_code": row["acgb_code"],
            "acgb": row["acgb"],
            "team_code": row["team_code"],
            "team": row["team"],
            "cti_idx": row["cti_idx"],
            "login_time": now_str
        }
    }

@app.get("/api/dashboard")
def api_dashboard():
    conn = get_db()
    cur = conn.cursor(cursor_factory=RealDictCursor)
    cur.execute("SELECT count(*) as cnt FROM ss_order")
    order_cnt = cur.fetchone()["cnt"]
    cur.execute("SELECT count(*) as cnt FROM ss_customer")
    customer_cnt = cur.fetchone()["cnt"]
    cur.execute("SELECT count(*) as cnt FROM ss_product")
    product_cnt = cur.fetchone()["cnt"]
    cur.execute("SELECT count(*) as cnt FROM ss_account")
    account_cnt = cur.fetchone()["cnt"]

    today_str = datetime.date.today().strftime("%Y-%m-%d")
    cur.execute("""
    SELECT order_status, count(*) as cnt
    FROM ss_order
    WHERE order_date >= %s
    GROUP BY order_status
    """, (today_str,))
    status_counts = {r["order_status"]: r["cnt"] for r in cur.fetchall()}

    cur.close()
    conn.close()
    return {
        "order_count": order_cnt,
        "customer_count": customer_cnt,
        "product_count": product_cnt,
        "account_count": account_cnt,
        "today_status": status_counts
    }

@app.get("/api/orders")
def api_get_orders(dateFrom: Optional[str] = None, dateTo: Optional[str] = None, status: Optional[str] = None, account_code: Optional[int] = None, search: Optional[str] = None):
    conn = get_db()
    cur = conn.cursor(cursor_factory=RealDictCursor)

    conds = []
    vals = []

    if dateFrom:
        conds.append("a.order_date >= %s")
        vals.append(f"{dateFrom} 00:00:00")
    if dateTo:
        conds.append("a.order_date <= %s")
        vals.append(f"{dateTo} 23:59:59")
    if status is not None and status != "" and status != "all":
        conds.append("a.order_status = %s")
        vals.append(int(status))
    if account_code:
        conds.append("a.account_code = %s")
        vals.append(account_code)
    if search:
        conds.append("(b.cus_name LIKE %s OR b.cus_phone LIKE %s OR b.cus_call LIKE %s OR a.order_address LIKE %s OR a.cus_code = %s)")
        s_val = f"%{search}%"
        vals.extend([s_val, s_val, s_val, s_val, search])

    where_clause = ("WHERE " + " AND ".join(conds)) if conds else ""

    q = f"""
    SELECT a."index", a.account_code, e.account_name, a.order_date,
           a.cus_code, b.cus_name, b.cus_call, b.cus_phone,
           a.order_address, a.product_code, a.order_status,
           a.order_delivery, a.order_etc
    FROM ss_order a
    LEFT JOIN ss_customer b ON a.cus_code = b.cus_code::text
    LEFT JOIN ss_account e ON a.account_code = e.account_code
    {where_clause}
    ORDER BY a."index" DESC
    LIMIT 2000
    """
    cur.execute(q, tuple(vals))
    rows = cur.fetchall()

    orders = []
    for r in rows:
        d = dict(r)
        if d.get("order_date"):
            d["order_date_str"] = d["order_date"].strftime("%Y-%m-%d %H:%M:%S")
            del d["order_date"]
        orders.append(d)

    cur.close()
    conn.close()
    return {"orders": orders}

@app.post("/api/orders")
async def api_create_order(request: Request):
    data = await request.json()
    acc_code = data.get("account_code")
    cus_code = data.get("cus_code")
    cus_name = data.get("cus_name", "").strip()
    cus_call = data.get("cus_call", "").strip()
    cus_phone = data.get("cus_phone", "").strip()
    order_address = data.get("order_address", "").strip()
    cus_address = data.get("cus_address", "").strip() or order_address
    order_delivery = data.get("order_delivery", "").strip()
    order_etc = data.get("order_etc", "").strip()
    items = data.get("items", [])

    if not cus_name or not order_address or not items:
        return JSONResponse({"status": "error", "message": "고객명, 배송지 주소 및 주문상품은 필수 입력 항목입니다."}, status_code=400)

    conn = get_db()
    cur = conn.cursor(cursor_factory=RealDictCursor)
    now_str = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")

    final_cus_code = cus_code
    if not final_cus_code:
        cur.execute("""
        SELECT cus_code FROM ss_customer
        WHERE cus_name = %s AND (cus_phone = %s OR cus_call = %s) AND account_code = %s
        LIMIT 1
        """, (cus_name, cus_phone, cus_call, acc_code))
        existing_c = cur.fetchone()
        if existing_c:
            final_cus_code = str(existing_c["cus_code"])
            if cus_address:
                cur.execute("UPDATE ss_customer SET cus_address = %s WHERE cus_code = %s", (cus_address, final_cus_code))
        else:
            cur.execute("""
            INSERT INTO ss_customer (account_code, cus_name, cus_call, cus_phone, cus_address)
            VALUES (%s, %s, %s, %s, %s) RETURNING cus_code
            """, (acc_code, cus_name, cus_call, cus_phone, cus_address))
            final_cus_code = str(cur.fetchone()["cus_code"])
    else:
        if cus_address:
            cur.execute("UPDATE ss_customer SET cus_address = %s WHERE cus_code = %s", (cus_address, final_cus_code))

    p_code_parts = []
    for it in items:
        p_code = it["product_code"]
        price = it.get("price", 0)
        qty = it.get("qty", 1)
        p_code_parts.append(f"<product>{p_code}<br>{price}<br>{qty}<br>")
        cur.execute("UPDATE ss_product SET product_stock = product_stock - %s WHERE product_code = %s", (qty, p_code))

    product_code_str = "".join(p_code_parts)

    cur.execute("""
    INSERT INTO ss_order (account_code, cus_code, product_code, order_address, order_date, order_status, order_delivery, order_etc)
    VALUES (%s, %s, %s, %s, %s, 1, %s, %s) RETURNING "index"
    """, (acc_code, final_cus_code, product_code_str, order_address, now_str, order_delivery, order_etc))
    new_idx = cur.fetchone()["index"]

    conn.commit()
    cur.close()
    conn.close()
    return {"status": "ok", "order_index": new_idx, "message": "주문이 정상 접수되었습니다."}

@app.put("/api/orders/{order_id}/status")
async def api_update_order_status(order_id: int, request: Request):
    data = await request.json()
    new_status = int(data.get("status"))

    conn = get_db()
    cur = conn.cursor(cursor_factory=RealDictCursor)
    cur.execute('SELECT order_status, product_code FROM ss_order WHERE "index" = %s', (order_id,))
    row = cur.fetchone()
    if not row:
        cur.close()
        conn.close()
        return JSONResponse({"status": "error", "message": "주문을 찾을 수 없습니다."}, status_code=404)

    orig_status = row["order_status"]
    p_code_str = row["product_code"] or ""

    spl = p_code_str.split("<product>")
    for p in spl:
        if not p.strip():
            continue
        br = p.split("<br>")
        if len(br) >= 3:
            p_code = br[0]
            qty = int(br[2]) if br[2].isdigit() else 1
            if orig_status in (1, 2, 4) and new_status == 3:
                cur.execute("UPDATE ss_product SET product_stock = product_stock + %s WHERE product_code = %s", (qty, p_code))
            elif orig_status == 3 and new_status in (1, 2, 4):
                cur.execute("UPDATE ss_product SET product_stock = product_stock - %s WHERE product_code = %s", (qty, p_code))

    cur.execute('UPDATE ss_order SET order_status = %s WHERE "index" = %s', (new_status, order_id))
    conn.commit()
    cur.close()
    conn.close()
    return {"status": "ok", "message": "주문 상태가 변경되었습니다."}

@app.put("/api/orders/{order_id}")
async def api_edit_order(order_id: int, request: Request):
    data = await request.json()
    address = data.get("order_address", "")
    delivery = data.get("order_delivery", "")
    etc = data.get("order_etc", "")

    conn = get_db()
    cur = conn.cursor()
    cur.execute("""
    UPDATE ss_order SET order_address = %s, order_delivery = %s, order_etc = %s
    WHERE "index" = %s
    """, (address, delivery, etc, order_id))
    conn.commit()
    cur.close()
    conn.close()
    return {"status": "ok", "message": "주문 정보가 수정되었습니다."}

# Customers
@app.get("/api/customers")
def api_get_customers(query: Optional[str] = None):
    conn = get_db()
    cur = conn.cursor(cursor_factory=RealDictCursor)
    if query:
        q_val = f"%{query}%"
        cur.execute("""
        SELECT c.cus_code, c.cus_name, c.cus_call, c.cus_phone, c.cus_address, c.account_code, a.account_name
        FROM ss_customer c
        LEFT JOIN ss_account a ON c.account_code = a.account_code
        WHERE c.cus_name LIKE %s OR c.cus_phone LIKE %s OR c.cus_call LIKE %s OR c.cus_code::text LIKE %s
        ORDER BY c.cus_code DESC LIMIT 300
        """, (q_val, q_val, q_val, q_val))
    else:
        cur.execute("""
        SELECT c.cus_code, c.cus_name, c.cus_call, c.cus_phone, c.cus_address, c.account_code, a.account_name
        FROM ss_customer c
        LEFT JOIN ss_account a ON c.account_code = a.account_code
        ORDER BY c.cus_code DESC LIMIT 300
        """)
    rows = cur.fetchall()
    cur.close()
    conn.close()
    return {"customers": [dict(r) for r in rows]}

@app.post("/api/customers")
async def api_create_customer(request: Request):
    data = await request.json()
    name = data.get("cus_name", "").strip()
    call = data.get("cus_call", "").strip()
    phone = data.get("cus_phone", "").strip()
    address = data.get("cus_address", "").strip()
    account_code = data.get("account_code", 1)

    if not name:
        return JSONResponse({"status": "error", "message": "고객명을 입력해주세요."}, status_code=400)

    conn = get_db()
    cur = conn.cursor(cursor_factory=RealDictCursor)
    cur.execute("""
    INSERT INTO ss_customer (account_code, cus_name, cus_call, cus_phone, cus_address)
    VALUES (%s, %s, %s, %s, %s) RETURNING cus_code
    """, (account_code, name, call, phone, address))
    code = cur.fetchone()["cus_code"]
    conn.commit()
    cur.close()
    conn.close()
    return {"status": "ok", "cus_code": code, "message": "고객이 등록되었습니다."}

@app.put("/api/customers/{cus_code}")
async def api_update_customer(cus_code: int, request: Request):
    data = await request.json()
    conn = get_db()
    cur = conn.cursor()
    cur.execute("""
    UPDATE ss_customer
    SET cus_name = %s, cus_call = %s, cus_phone = %s, cus_address = %s
    WHERE cus_code = %s
    """, (data.get("cus_name"), data.get("cus_call"), data.get("cus_phone"), data.get("cus_address"), cus_code))
    conn.commit()
    cur.close()
    conn.close()
    return {"status": "ok", "message": "고객 정보가 수정되었습니다."}

@app.delete("/api/customers/{cus_code}")
def api_delete_customer(cus_code: int):
    conn = get_db()
    cur = conn.cursor()
    cur.execute("DELETE FROM ss_customer WHERE cus_code = %s", (cus_code,))
    conn.commit()
    cur.close()
    conn.close()
    return {"status": "ok", "message": "고객이 삭제되었습니다."}

# Products
@app.get("/api/products")
def api_get_products():
    conn = get_db()
    cur = conn.cursor(cursor_factory=RealDictCursor)
    cur.execute("""
    SELECT product_code, team_code, gb_code, product_name, product_price, product_stock
    FROM ss_product ORDER BY product_code ASC
    """)
    rows = cur.fetchall()
    cur.close()
    conn.close()
    return {"products": [dict(r) for r in rows]}

@app.post("/api/products")
async def api_create_product(request: Request):
    data = await request.json()
    code = data.get("product_code", "").strip()
    name = data.get("product_name", "").strip()
    price = int(data.get("product_price", 0))
    stock = int(data.get("product_stock", 0))
    team = int(data.get("team_code", 1))
    gb = int(data.get("gb_code", 1))

    if not code or not name:
        return JSONResponse({"status": "error", "message": "제품코드와 제품명은 필수입니다."}, status_code=400)

    conn = get_db()
    cur = conn.cursor()
    cur.execute("""
    INSERT INTO ss_product (product_code, team_code, gb_code, product_name, product_price, product_stock)
    VALUES (%s, %s, %s, %s, %s, %s)
    ON CONFLICT (product_code) DO UPDATE
    SET product_name = EXCLUDED.product_name, product_price = EXCLUDED.product_price, product_stock = EXCLUDED.product_stock
    """, (code, team, gb, name, price, stock))
    conn.commit()
    cur.close()
    conn.close()
    return {"status": "ok", "message": "제품이 저장되었습니다."}

@app.put("/api/products/{code}")
async def api_update_product(code: str, request: Request):
    data = await request.json()
    conn = get_db()
    cur = conn.cursor()
    cur.execute("""
    UPDATE ss_product
    SET product_name = %s, product_price = %s, product_stock = %s, team_code = %s, gb_code = %s
    WHERE product_code = %s
    """, (data.get("product_name"), data.get("product_price"), data.get("product_stock"), data.get("team_code", 1), data.get("gb_code", 1), code))
    conn.commit()
    cur.close()
    conn.close()
    return {"status": "ok", "message": "제품 정보가 수정되었습니다."}

@app.delete("/api/products/{code}")
def api_delete_product(code: str):
    conn = get_db()
    cur = conn.cursor()
    cur.execute("DELETE FROM ss_product WHERE product_code = %s", (code,))
    conn.commit()
    cur.close()
    conn.close()
    return {"status": "ok", "message": "제품이 삭제되었습니다."}

# Accounts
@app.get("/api/accounts")
def api_get_accounts():
    conn = get_db()
    cur = conn.cursor(cursor_factory=RealDictCursor)
    cur.execute("""
    SELECT a.account_code, a.acgb_code, b.acgb, a.team_code, c.team,
           a.account_id, a.account_pw, a.account_name, a.allow_ip
    FROM ss_account a
    LEFT JOIN ss_accountgb b ON a.acgb_code = b.acgb_code
    LEFT JOIN ss_team c ON a.team_code = c.team_code
    ORDER BY a.account_code ASC
    """)
    rows = cur.fetchall()
    cur.close()
    conn.close()
    return {"accounts": [dict(r) for r in rows]}

@app.post("/api/accounts")
async def api_create_account(request: Request):
    data = await request.json()
    conn = get_db()
    cur = conn.cursor()
    cur.execute("""
    INSERT INTO ss_account (acgb_code, team_code, account_id, account_pw, account_name, allow_ip)
    VALUES (%s, %s, %s, %s, %s, %s)
    """, (data.get("acgb_code", 2), data.get("team_code", 1), data.get("account_id"), data.get("account_pw"), data.get("account_name"), data.get("allow_ip") or None))
    conn.commit()
    cur.close()
    conn.close()
    return {"status": "ok", "message": "사원 계정이 추가되었습니다."}

@app.put("/api/accounts/{acc_code}")
async def api_update_account(acc_code: int, request: Request):
    data = await request.json()
    conn = get_db()
    cur = conn.cursor()
    cur.execute("""
    UPDATE ss_account
    SET acgb_code = %s, team_code = %s, account_id = %s, account_pw = %s, account_name = %s, allow_ip = %s
    WHERE account_code = %s
    """, (data.get("acgb_code"), data.get("team_code"), data.get("account_id"), data.get("account_pw"), data.get("account_name"), data.get("allow_ip") or None, acc_code))
    conn.commit()
    cur.close()
    conn.close()
    return {"status": "ok", "message": "사원 계정이 수정되었습니다."}

@app.delete("/api/accounts/{acc_code}")
def api_delete_account(acc_code: int):
    conn = get_db()
    cur = conn.cursor()
    cur.execute("DELETE FROM ss_account WHERE account_code = %s", (acc_code,))
    conn.commit()
    cur.close()
    conn.close()
    return {"status": "ok", "message": "사원 계정이 삭제되었습니다."}

# CTI Endpoints
@app.get("/api/cti/dbs")
def api_cti_dbs():
    conn = get_db()
    cur = conn.cursor(cursor_factory=RealDictCursor)
    cur.execute("SELECT idx, name, status, last_date FROM cti_db ORDER BY idx DESC")
    dbs = cur.fetchall()
    res = []
    for d in dbs:
        cur.execute("SELECT count(*) as total, count(CASE WHEN agent_idx IS NULL THEN 1 END) as nosplit, count(CASE WHEN blacklist = 1 THEN 1 END) as bl FROM cti_tm_list WHERE db_idx = %s", (d["idx"],))
        st = cur.fetchone()
        res.append({
            "idx": d["idx"],
            "name": d["name"],
            "status": d["status"],
            "last_date": d["last_date"],
            "total_count": st["total"] if st else 0,
            "nosplit_count": st["nosplit"] if st else 0,
            "blacklist_count": st["bl"] if st else 0
        })
    cur.close()
    conn.close()
    return {"dbs": res}

@app.get("/api/cti/tm_list")
def api_cti_tm_list(db_idx: int, page: int = 0, search: Optional[str] = None):
    conn = get_db()
    cur = conn.cursor(cursor_factory=RealDictCursor)
    limit = 100
    offset = page * limit
    cond = "WHERE db_idx = %s"
    vals = [db_idx]
    if search:
        cond += " AND (name LIKE %s OR phone_number LIKE %s OR home_number LIKE %s)"
        s = f"%{search}%"
        vals.extend([s, s, s])

    cur.execute(f"SELECT count(*) as cnt FROM cti_tm_list {cond}", tuple(vals))
    total = cur.fetchone()["cnt"]

    cur.execute(f"""
    SELECT idx, agent_idx, name, product_name, seller, price, phone_number, home_number,
           address, result, call_time, call_count, restored, comment, comment2, blacklist
    FROM cti_tm_list
    {cond}
    ORDER BY idx ASC
    LIMIT %s OFFSET %s
    """, tuple(vals + [limit, offset]))
    items = [dict(r) for r in cur.fetchall()]
    cur.close()
    conn.close()
    return {"total": total, "page": page, "items": items}

@app.post("/api/cti/result")
async def api_cti_set_result(request: Request):
    data = await request.json()
    idx = data.get("idx")
    result = data.get("result")
    comment = data.get("comment", "")
    now_str = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")

    conn = get_db()
    cur = conn.cursor()
    cur.execute("""
    UPDATE cti_tm_list
    SET result = %s, comment = %s, call_time = %s, call_count = call_count + 1
    WHERE idx = %s
    """, (result, comment, now_str, idx))
    conn.commit()
    cur.close()
    conn.close()
    return {"status": "ok", "message": "상담 결과가 저장되었습니다."}


# ==========================================
# LEGACY PHP ENDPOINTS (100% COMPATIBILITY)
# ==========================================

@app.post("/tmserver/login_v2.php")
@app.get("/tmserver/login_v2.php")
@app.post("/tmserverlogin_v2.php")
@app.get("/tmserverlogin_v2.php")
@app.post("/login_v2.php")
@app.get("/login_v2.php")
async def login_v2(request: Request):
    params, form = await parse_body_and_params(request)
    args = form.get("args") or form or {}
    user_id = str(args.get("id", "")).strip()
    user_pw = str(args.get("pw", "")).strip()

    conn = get_db()
    cur = conn.cursor(cursor_factory=RealDictCursor)
    cur.execute("""
    SELECT a.account_code, a.acgb_code, b.acgb, a.team_code, c.team,
           a.account_id as id, a.account_pw as pw, a.account_name as name,
           a.allow_ip, cti.idx as cti_idx
    FROM ss_account a
    LEFT JOIN ss_accountgb b ON a.acgb_code = b.acgb_code
    LEFT JOIN ss_team c ON a.team_code = c.team_code
    LEFT JOIN cti_agents cti ON a.account_code = cti.account_idx
    WHERE a.account_id = %s
    """, (user_id,))
    row = cur.fetchone()
    cur.close()
    conn.close()

    if not row or str(row["pw"]) != user_pw:
        return JSONResponse({"response": "fail", "cause": "no_match"})

    now_str = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")
    return JSONResponse({
        "response": "ok",
        "output": {
            "name": row["name"],
            "acgb_code": row["acgb_code"],
            "acgb": row["acgb"],
            "team_code": row["team_code"],
            "team": row["team"],
            "account_code": row["account_code"],
            "cti_idx": row["cti_idx"] or 0,
            "date": now_str
        }
    })

@app.post("/tmserver/login.php")
@app.get("/tmserver/login.php")
@app.post("/login.php")
@app.get("/login.php")
async def login_v1(request: Request):
    params, form = await parse_body_and_params(request)
    user_id = form.get("id", "") or params.get("id", "")
    user_pw = form.get("pw", "") or params.get("pw", "")

    conn = get_db()
    cur = conn.cursor(cursor_factory=RealDictCursor)
    cur.execute("""
    SELECT a.account_code, a.acgb_code, b.acgb, a.team_code, c.team,
           a.account_id as id, a.account_pw as pw, a.account_name as name
    FROM ss_account a
    LEFT JOIN ss_accountgb b ON a.acgb_code = b.acgb_code
    LEFT JOIN ss_team c ON a.team_code = c.team_code
    WHERE a.account_id = %s
    """, (user_id,))
    row = cur.fetchone()
    cur.close()
    conn.close()

    if not row or str(row["pw"]) != user_pw:
        return PlainTextResponse("incorrect")

    now_str = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")
    resp = f"{row['acgb_code']}<next>{row['acgb']}<next>{row['team_code']}<next>{row['team']}<next>{row['name']}<next>{now_str}<next>{row['account_code']}"
    return PlainTextResponse(resp)

@app.api_route("/tmserver/update/get.php", methods=["GET", "POST"])
@app.api_route("/tmserverupdate/get.php", methods=["GET", "POST"])
@app.api_route("/update/get.php", methods=["GET", "POST"])
def update_get():
    return JSONResponse({
        "project_name": "성신판매접수",
        "latest_version": "318",
        "force": False,
        "description": "성신 판매접수 관리자 클라이언트 버전 3.18"
    })

@app.api_route("/tmserver/admin.php", methods=["GET", "POST"])
@app.api_route("/tmserveradmin.php", methods=["GET", "POST"])
@app.api_route("/admin.php", methods=["GET", "POST"])
async def admin_endpoint(request: Request):
    params, form = await parse_body_and_params(request)

    action_type = params.get("t", "")
    user_id = form.get("id", "") or params.get("id", "")
    user_pw = form.get("pw", "") or params.get("pw", "")
    acc_code = form.get("acc_code") or params.get("acc_code") or params.get("ac")

    tc = form.get("tc") or params.get("tc")
    dateFrom = params.get("dateFrom", "")
    dateTo = params.get("dateTo", "")

    cc = params.get("cc", "")
    cp = params.get("cp", "")
    cn = params.get("cn", "")
    call_num = params.get("call", "")
    ca = params.get("ca", "")

    pc = form.get("pc") or params.get("pc", "")
    pt = params.get("pt", "")
    pg = params.get("pg", "")
    pn = params.get("pn", "")
    pp = params.get("pp", "")
    ps = params.get("ps", "")

    ac = form.get("ac") or params.get("ac", "")
    acgb = form.get("acgb") or params.get("acgb", "")
    gb = form.get("gb") or params.get("gb", "")
    ai = params.get("ai", "")
    ap = params.get("ap", "")
    an = params.get("an", "")
    allow_ip = params.get("allow_ip")

    index_val = params.get("i", "")
    status_val = params.get("s", "")
    od = params.get("od", "")
    oe = params.get("oe", "")
    oa = form.get("oa") or params.get("oa", "")

    conn = get_db()
    cur = conn.cursor(cursor_factory=RealDictCursor)

    cur.execute("SELECT acgb_code, account_id, account_code FROM ss_account WHERE account_id = %s AND account_pw = %s", (user_id, user_pw))
    admin_check = cur.fetchone()
    if not admin_check:
        cur.close()
        conn.close()
        return PlainTextResponse("fail")

    check_acgb = admin_check["acgb_code"]
    auth_account_code = admin_check["account_code"]
    now_str = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")

    if action_type in ("getOrder", "getOrderV2"):
        cond = "WHERE a.order_date >= %s AND a.order_date <= %s"
        dt_to = f"{dateTo} 23:59:59" if dateTo else "2099-12-31 23:59:59"
        dt_from = dateFrom if dateFrom else "2000-01-01"
        qp = [dt_from, dt_to]
        if str(tc) == "99":
            cond += " AND a.account_code = %s"
            qp.append(ac)

        q = f"""
        SELECT a."index", a.account_code, e.account_name, a.order_date,
               a.cus_code, b.cus_name, b.cus_call, b.cus_phone,
               a.order_address, a.product_code, a.order_status,
               a.order_delivery, a.order_etc
        FROM ss_order a
        LEFT JOIN ss_customer b ON a.cus_code = b.cus_code::text
        LEFT JOIN ss_account e ON a.account_code = e.account_code
        {cond} ORDER BY a."index" DESC
        """
        cur.execute(q, qp)
        rows = cur.fetchall()
        out_parts = []
        for r in rows:
            odate_str = r["order_date"].strftime("%Y-%m-%d %H:%M:%S") if r["order_date"] else ""
            line = f"<split>{r['index']}<next>{odate_str}<next>{r['account_name'] or ''}<next>{r['cus_code']}<next>{r['cus_name'] or ''}<next>{r['cus_call'] or ''}<next>{r['cus_phone'] or ''}<next>{r['order_address'] or ''}<next>{r['product_code'] or ''}<next>{r['order_status']}<next>{r['order_delivery'] or ''}<next>{r['order_etc'] or ''}<end>"
            out_parts.append(line)
        cur.close()
        conn.close()
        return PlainTextResponse("".join(out_parts))

    elif action_type == "getOrderV3":
        cond = "WHERE a.order_date >= %s AND a.order_date <= %s"
        dt_to = f"{dateTo} 23:59:59" if dateTo else "2099-12-31 23:59:59"
        dt_from = dateFrom if dateFrom else "2000-01-01"
        qp = [dt_from, dt_to]
        if str(tc) == "99":
            cond += " AND a.account_code = %s"
            qp.append(ac)

        q = f"""
        SELECT a."index", a.account_code, a.order_date, a.cus_code,
               b.cus_name, b.cus_call, b.cus_phone, a.order_address,
               a.product_code, a.order_status, a.order_delivery, a.order_etc
        FROM ss_order a
        LEFT JOIN ss_customer b ON a.cus_code = b.cus_code::text
        {cond} ORDER BY a."index" DESC
        """
        cur.execute(q, qp)
        orders = cur.fetchall()
        formatted_orders = []
        for o in orders:
            d = dict(o)
            if d.get("order_date"):
                d["order_date"] = d["order_date"].strftime("%Y-%m-%d %H:%M:%S")
            formatted_orders.append(d)

        cur.execute("SELECT account_code, account_name FROM ss_account ORDER BY account_code ASC")
        accounts = [dict(a) for a in cur.fetchall()]
        cur.close()
        conn.close()
        return JSONResponse({
            "ss_order": json.dumps(formatted_orders, ensure_ascii=False),
            "ss_account": json.dumps(accounts, ensure_ascii=False)
        })

    elif action_type == "getCustomer":
        cur.execute("""
        SELECT cus_code, acc.account_id, cus_name, cus_call, cus_phone, cus_address
        FROM ss_customer cus
        LEFT JOIN ss_account acc ON cus.account_code = acc.account_code
        WHERE cus_code::text LIKE %s AND cus_name LIKE %s AND cus_phone LIKE %s AND cus_call LIKE %s
        ORDER BY cus_code ASC
        """, (f"%{cc}%", f"%{cn}%", f"%{cp}%", f"%{call_num}%"))
        rows = cur.fetchall()
        out = "".join(f"<split>{r['cus_code']}<next>{r['account_id'] or ''}<next>{r['cus_name']}<next>{r['cus_call'] or ''}<next>{r['cus_phone'] or ''}<next>{(r['cus_address'] or '').replace('<other>', ' ')}" for r in rows)
        cur.close()
        conn.close()
        return PlainTextResponse(out)

    elif action_type == "getProduct":
        cur.execute("""
        SELECT product_code, team_code, gb_code, product_name, product_price, product_stock
        FROM ss_product
        WHERE product_code LIKE %s AND (team_code::text LIKE %s OR team_code IS NULL)
          AND (gb_code::text LIKE %s OR gb_code IS NULL)
          AND (product_name LIKE %s OR product_name IS NULL)
        ORDER BY product_code ASC
        """, (f"%{pc}%", f"%{pt}%", f"%{pg}%", f"%{pn}%"))
        rows = cur.fetchall()
        out = "".join(f"<split>{r['product_code']}<next>{r['team_code'] or ''}<next>{r['gb_code'] or ''}<next>{r['product_name'] or ''}<next>{r['product_price'] or 0}<next>{r['product_stock'] or 0}" for r in rows)
        cur.close()
        conn.close()
        return PlainTextResponse(out)

    elif action_type == "getAccount":
        cur.execute("""
        SELECT account_code, acgb_code, team_code, account_id, account_pw, account_name, allow_ip
        FROM ss_account
        WHERE account_code::text LIKE %s AND acgb_code::text LIKE %s AND team_code::text LIKE %s
          AND account_id LIKE %s AND account_name LIKE %s
        ORDER BY account_code ASC
        """, (f"%{ac}%", f"%{acgb}%", f"%{gb}%", f"%{ai}%", f"%{an}%"))
        rows = cur.fetchall()
        out = "".join(f"<split>{r['account_code']}<next>{r['acgb_code']}<next>{r['team_code']}<next>{r['account_id']}<next>{r['account_pw']}<next>{r['account_name']}<next>{r['allow_ip'] or ''}" for r in rows)
        cur.close()
        conn.close()
        return PlainTextResponse(out)

    elif action_type in ("cusSearchA", "searchCustomer"):
        acc_c = int(acc_code) if acc_code else auth_account_code
        cur.execute("""
        SELECT cus_code, cus_name, cus_call, cus_phone, cus_address
        FROM ss_customer
        WHERE (cus_code::text LIKE %s OR cus_name LIKE %s OR cus_phone LIKE %s OR cus_call LIKE %s)
          AND account_code = %s
        ORDER BY cus_name ASC
        """, (f"%{cc}%", f"%{cc}%", f"%{cc}%", f"%{cc}%", acc_c))
        rows = cur.fetchall()
        out = "".join(f"<split>{r['cus_code']}<next>{r['cus_name']}<next>{r['cus_call'] or ''}<next>{r['cus_phone'] or ''}<next>{r['cus_address'] or ''}" for r in rows)
        cur.close()
        conn.close()
        return PlainTextResponse(out)

    elif action_type == "setOrder":
        acc_c = int(acc_code) if acc_code else auth_account_code
        od_val = params.get("od") or form.get("od", "")
        cur.execute("""
        SELECT cus_code, count(*) as count FROM ss_customer
        WHERE (cus_code::text = %s OR (cus_name LIKE %s AND cus_phone LIKE %s)) AND account_code = %s
        GROUP BY cus_code
        """, (cc, f"%{cn}%", f"%{cp}%", acc_c))
        c_check = cur.fetchone()

        if not c_check or c_check["count"] <= 0:
            cur.execute("""
            INSERT INTO ss_customer (account_code, cus_name, cus_call, cus_phone, cus_address)
            VALUES (%s, %s, %s, %s, %s) RETURNING cus_code
            """, (acc_c, cn, call_num, cp, ca))
            customer_code = str(cur.fetchone()["cus_code"])
        else:
            customer_code = str(c_check["cus_code"])

        spl = pc.split("<product>")
        for p in spl:
            if not p.strip():
                continue
            br = p.split("<br>")
            if len(br) >= 3:
                p_code = br[0]
                qty = int(br[2]) if br[2].isdigit() else 1
                cur.execute("UPDATE ss_product SET product_stock = product_stock - %s WHERE product_code = %s", (qty, p_code))

        cur.execute("""
        INSERT INTO ss_order (account_code, cus_code, product_code, order_address, order_date, order_status, order_delivery, order_etc)
        VALUES (%s, %s, %s, %s, %s, 1, %s, %s)
        """, (acc_c, customer_code, pc, ca, now_str, od_val, oe))
        conn.commit()
        cur.close()
        conn.close()
        return PlainTextResponse("ok")

    elif action_type == "orderMod":
        cur.execute("""
        UPDATE ss_order SET product_code = %s, order_address = %s, order_delivery = %s, order_etc = %s
        WHERE "index" = %s
        """, (pc, oa, od, oe, int(index_val)))
        conn.commit()
        cur.close()
        conn.close()
        return PlainTextResponse("ok")

    elif action_type == "setOrderStatus":
        cur.execute('SELECT order_status, product_code FROM ss_order WHERE "index" = %s', (int(index_val),))
        row = cur.fetchone()
        if not row:
            cur.close()
            conn.close()
            return PlainTextResponse("ok")

        orig_status = row["order_status"]
        new_status = int(status_val) if status_val.isdigit() else 0
        p_code_str = row["product_code"] or ""

        spl = p_code_str.split("<product>")
        for p in spl:
            if not p.strip():
                continue
            br = p.split("<br>")
            if len(br) >= 3:
                p_code = br[0]
                qty = int(br[2]) if br[2].isdigit() else 1
                if orig_status in (1, 2, 4) and new_status == 3:
                    cur.execute("UPDATE ss_product SET product_stock = product_stock + %s WHERE product_code = %s", (qty, p_code))
                elif orig_status == 3 and new_status in (1, 2, 4):
                    cur.execute("UPDATE ss_product SET product_stock = product_stock - %s WHERE product_code = %s", (qty, p_code))

        cur.execute("""
        UPDATE ss_order SET product_code = %s, order_address = %s, order_status = %s, order_delivery = %s, order_etc = %s
        WHERE "index" = %s
        """, (pc or p_code_str, oa, new_status, od, oe, int(index_val)))
        conn.commit()
        cur.close()
        conn.close()
        return PlainTextResponse("ok")

    elif action_type == "modCustomer":
        cur.execute("SELECT account_code FROM ss_account WHERE account_id = %s", (ac,))
        acc_row = cur.fetchone()
        acc_c = acc_row["account_code"] if acc_row else auth_account_code

        if cc and cc.isdigit():
            cur.execute("SELECT count(*) as count FROM ss_customer WHERE cus_code = %s", (int(cc),))
            cnt = cur.fetchone()["count"]
            if cnt > 0:
                cur.execute("""
                UPDATE ss_customer SET cus_name = %s, account_code = %s, cus_call = %s, cus_phone = %s, cus_address = %s
                WHERE cus_code = %s
                """, (cn, acc_c, call_num, cp, ca, int(cc)))
                conn.commit()
                cur.close()
                conn.close()
                return PlainTextResponse("ok")

        cur.execute("""
        INSERT INTO ss_customer (cus_name, account_code, cus_call, cus_phone, cus_address)
        VALUES (%s, %s, %s, %s, %s)
        """, (cn, acc_c, call_num, cp, ca))
        conn.commit()
        cur.close()
        conn.close()
        return PlainTextResponse("ok")

    elif action_type == "delCustomer":
        cur.execute("DELETE FROM ss_customer WHERE cus_code = %s", (int(cc),))
        conn.commit()
        cur.close()
        conn.close()
        return PlainTextResponse("ok")

    elif action_type == "modProduct":
        cur.execute("SELECT count(*) as count FROM ss_product WHERE product_code = %s", (pc,))
        cnt = cur.fetchone()["count"]
        stock_val = int(ps) if ps and str(ps).isdigit() else 0
        price_val = int(pp) if pp and str(pp).isdigit() else 0
        team_val = int(pt) if pt and str(pt).isdigit() else 1
        gb_val = int(pg) if pg and str(pg).isdigit() else 1

        if cnt > 0:
            cur.execute("""
            UPDATE ss_product SET team_code = %s, gb_code = %s, product_name = %s, product_price = %s, product_stock = %s
            WHERE product_code = %s
            """, (team_val, gb_val, pn, price_val, stock_val, pc))
        else:
            cur.execute("""
            INSERT INTO ss_product (product_code, team_code, gb_code, product_name, product_price, product_stock)
            VALUES (%s, %s, %s, %s, %s, %s)
            """, (pc, team_val, gb_val, pn, price_val, stock_val))
        conn.commit()
        cur.close()
        conn.close()
        return PlainTextResponse("ok")

    elif action_type == "delProduct":
        cur.execute("DELETE FROM ss_product WHERE product_code = %s", (pc,))
        conn.commit()
        cur.close()
        conn.close()
        return PlainTextResponse("ok")

    elif action_type == "modAccount":
        if ac and str(ac).isdigit():
            cur.execute("SELECT count(*) as count FROM ss_account WHERE account_code = %s", (int(ac),))
            cnt = cur.fetchone()["count"]
            if cnt > 0:
                cur.execute("""
                UPDATE ss_account SET acgb_code = %s, team_code = %s, account_id = %s, account_pw = %s, account_name = %s, allow_ip = %s
                WHERE account_code = %s
                """, (int(acgb), int(gb), ai, ap, an, allow_ip or None, int(ac)))
                conn.commit()
                cur.close()
                conn.close()
                return PlainTextResponse("ok")

        cur.execute("""
        INSERT INTO ss_account (acgb_code, team_code, account_id, account_pw, account_name, allow_ip)
        VALUES (%s, %s, %s, %s, %s)
        """, (int(acgb), int(gb), ai, ap, an, allow_ip or None))
        conn.commit()
        cur.close()
        conn.close()
        return PlainTextResponse("ok")

    elif action_type == "delAccount":
        if str(ac) == str(auth_account_code):
            cur.close()
            conn.close()
            return PlainTextResponse("서버 알림: 현재 로그인 중인 계정은 삭제할 수 없습니다.")
        cur.execute("DELETE FROM ss_account WHERE account_code = %s", (int(ac),))
        conn.commit()
        cur.close()
        conn.close()
        return PlainTextResponse("ok")

    cur.close()
    conn.close()
    return PlainTextResponse("unknown_action")


if __name__ == "__main__":
    import threading

    ssl_key = r"D:\Gemini\성신판매접수\backend\ssl\server.key"
    ssl_cert = r"D:\Gemini\성신판매접수\backend\ssl\server.crt"

    def run_5000():
        uvicorn.run(app, host="0.0.0.0", port=5000, log_level="warning")

    def run_443():
        if os.path.exists(ssl_key) and os.path.exists(ssl_cert):
            try:
                uvicorn.run(app, host="0.0.0.0", port=443, ssl_keyfile=ssl_key, ssl_certfile=ssl_cert, log_level="warning")
            except Exception as e:
                print("443 bind failed:", e)

    t1 = threading.Thread(target=run_5000, daemon=True)
    t1.start()
    print("Started TMServer Backend on http://0.0.0.0:5000")

    if os.path.exists(ssl_key) and os.path.exists(ssl_cert):
        t2 = threading.Thread(target=run_443, daemon=True)
        t2.start()
        print("Started TMServer Backend on https://0.0.0.0:443 (SSL)")

    t1.join()
