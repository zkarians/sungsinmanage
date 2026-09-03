// ========================================================
// 성신판매접수 관리자 v3.18 - 모던 풀스택 클라이언트 로직
// ========================================================

const API_BASE = "";

// Global State
let currentUser = null;
let allProducts = [];
let allAccounts = [];
let basketItems = [];
let ctiCurrentPage = 0;
let ctiCurrentDbIdx = null;

function getProductName(code) {
    if (!code) return "";
    const cleanCode = String(code).trim();
    if (!window.productMap) {
        window.productMap = {};
        allProducts.forEach(p => {
            if (p.product_code) window.productMap[p.product_code.trim()] = p.product_name;
        });
    }
    return window.productMap[cleanCode] || cleanCode;
}

// Initialize on DOM load
document.addEventListener("DOMContentLoaded", () => {
    initAuth();
    initTabNavigation();
    initSetOrderTab();
    initOrdersTab();
    initCustomersTab();
    initProductsTab();
    initAccountsTab();
    initCtiTab();
    initModals();
});

// ========================================================
// 1. AUTHENTICATION & LOGIN
// ========================================================
function initAuth() {
    const savedUser = localStorage.getItem("ss_user");
    const autoLogin = localStorage.getItem("ss_autologin") === "true";

    if (savedUser && autoLogin) {
        try {
            currentUser = JSON.parse(savedUser);
            onLoginSuccess();
            return;
        } catch (e) {
            localStorage.removeItem("ss_user");
        }
    }

    const savedId = localStorage.getItem("ss_saved_id");
    if (savedId) {
        document.getElementById("loginId").value = savedId;
        document.getElementById("saveId").checked = true;
    }

    document.getElementById("btnLogin").addEventListener("click", performLogin);
    document.getElementById("loginPw").addEventListener("keydown", (e) => {
        if (e.key === "Enter") performLogin();
    });
    document.getElementById("btnLogout").addEventListener("click", performLogout);
}

async function performLogin() {
    const id = document.getElementById("loginId").value.trim();
    const pw = document.getElementById("loginPw").value.trim();
    const errorEl = document.getElementById("loginError");
    errorEl.textContent = "";

    if (!id || !pw) {
        errorEl.textContent = "아이디와 암호를 모두 입력해주세요.";
        return;
    }

    try {
        const res = await fetch(`${API_BASE}/api/login`, {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify({ id, pw })
        });
        const data = await res.json();

        if (res.ok && data.status === "ok") {
            currentUser = data.user;
            if (document.getElementById("saveId").checked) {
                localStorage.setItem("ss_saved_id", id);
            } else {
                localStorage.removeItem("ss_saved_id");
            }
            if (document.getElementById("autoLogin").checked) {
                localStorage.setItem("ss_autologin", "true");
                localStorage.setItem("ss_user", JSON.stringify(currentUser));
            } else {
                localStorage.removeItem("ss_autologin");
                sessionStorage.setItem("ss_user", JSON.stringify(currentUser));
            }
            onLoginSuccess();
        } else {
            errorEl.textContent = data.message || "로그인 실패 / 계정 또는 암호를 확인하세요.";
        }
    } catch (err) {
        errorEl.textContent = "서버 통신 오류: " + err.message;
    }
}

function onLoginSuccess() {
    document.getElementById("loginOverlay").classList.add("hidden");
    document.getElementById("appContainer").classList.remove("hidden");

    // Display Header Info
    const teamName = currentUser.team || (currentUser.team_code === 1 ? "직판" : "TM");
    const roleName = currentUser.acgb || "사원";
    document.getElementById("headerUserInfo").textContent =
        `[사원이름 - ${currentUser.name || currentUser.id}] [소속구분 - ${teamName}] [권한 - ${roleName}]`;

    // Load initial reference data
    loadProducts();
    loadAccounts();

    // Default dates for orders
    const today = new Date().toISOString().split("T")[0];
    document.getElementById("orderDateFrom").value = today;
    document.getElementById("orderDateTo").value = today;
}

function performLogout() {
    if (!confirm("로그아웃 하시겠습니까?")) return;
    localStorage.removeItem("ss_autologin");
    localStorage.removeItem("ss_user");
    sessionStorage.removeItem("ss_user");
    location.reload();
}

// ========================================================
// 2. TAB NAVIGATION
// ========================================================
function initTabNavigation() {
    const tabs = document.querySelectorAll(".tab-btn");
    tabs.forEach(btn => {
        btn.addEventListener("click", () => {
            tabs.forEach(b => b.classList.remove("active"));
            document.querySelectorAll(".tab-pane").forEach(p => p.classList.remove("active"));

            btn.classList.add("active");
            const target = btn.getAttribute("data-tab");
            const pane = document.getElementById(target);
            if (pane) pane.classList.add("active");

            // Refresh data when switching tabs
            if (target === "tabOrders") loadOrders();
            if (target === "tabCustomers") loadCustomers();
            if (target === "tabProducts") loadProducts();
            if (target === "tabAccounts") loadAccounts();
            if (target === "tabCti") loadCtiDbs();
        });
    });
}

// ========================================================
// 3. TAB 1: ORDER ENTRY (주문 접수)
// ========================================================
function initSetOrderTab() {
    // Realtime Customer Search in Order
    const searchInput = document.getElementById("orderCusSearch");
    const dropdown = document.getElementById("cusSearchResults");

    let searchTimer = null;
    searchInput.addEventListener("input", () => {
        clearTimeout(searchTimer);
        const q = searchInput.value.trim();
        if (q.length < 2) {
            dropdown.classList.add("hidden");
            return;
        }
        searchTimer = setTimeout(() => searchCustomersInline(q), 250);
    });

    document.getElementById("btnSearchCusInOrder").addEventListener("click", () => {
        searchCustomersInline(searchInput.value.trim());
    });

    // Address Search (Mock / Daum Postcode)
    document.getElementById("btnSearchZip").addEventListener("click", () => {
        const addr = prompt("검색할 도로명 또는 지번 주소를 입력하세요:", "서울특별시 ");
        if (addr) {
            document.getElementById("orderAddress").value = addr;
            document.getElementById("orderAddressDetail").focus();
        }
    });

    // Product Basket Events
    document.getElementById("btnOpenProductModal").addEventListener("click", openProductModal);
    document.getElementById("orderProductSearch").addEventListener("keydown", (e) => {
        if (e.key === "Enter") {
            openProductModal();
            document.getElementById("modalProductSearch").value = e.target.value;
            filterModalProducts();
        }
    });

    document.getElementById("checkAllBasket").addEventListener("change", (e) => {
        const checks = document.querySelectorAll(".basket-check");
        checks.forEach(c => c.checked = e.target.checked);
        recalcBasket();
    });

    // Reset Order
    document.getElementById("btnResetOrder").addEventListener("click", resetOrderForm);

    // Submit Order
    document.getElementById("btnSubmitOrder").addEventListener("click", submitOrder);

    makeTableResizable("basketTable", "ss_basket_col_widths");
}

async function searchCustomersInline(query) {
    const dropdown = document.getElementById("cusSearchResults");
    if (!query) return;

    try {
        const res = await fetch(`${API_BASE}/api/customers?query=${encodeURIComponent(query)}`);
        const data = await res.json();
        dropdown.innerHTML = "";

        if (!data.customers || data.customers.length === 0) {
            dropdown.innerHTML = `<div class="search-dropdown-item">일치하는 고객이 없습니다. (신규 자동등록)</div>`;
        } else {
            data.customers.forEach(c => {
                const item = document.createElement("div");
                item.className = "search-dropdown-item";
                item.innerHTML = `<strong>${c.cus_name}</strong> | 📞 ${c.cus_phone || c.cus_call || "-"} | 🏠 ${c.cus_address || "-"}`;
                item.addEventListener("click", () => selectCustomerForOrder(c));
                dropdown.appendChild(item);
            });
        }
        dropdown.classList.remove("hidden");
    } catch (err) {
        console.error("Search error:", err);
    }
}

function selectCustomerForOrder(c) {
    document.getElementById("orderCusCode").value = c.cus_code || "";
    document.getElementById("orderCusName").value = c.cus_name || "";
    document.getElementById("orderCusCall").value = c.cus_call || "";
    document.getElementById("orderCusPhone").value = c.cus_phone || "";

    const rawAddr = c.cus_address || "";
    const spl = rawAddr.split("<other>");
    document.getElementById("orderAddress").value = spl[0] || "";
    document.getElementById("orderAddressDetail").value = spl[1] || "";

    document.getElementById("cusSearchResults").classList.add("hidden");
    document.getElementById("orderCusSearch").value = "";
}

function addProductToBasket(p) {
    // Check if already in basket
    const existing = basketItems.find(it => it.product_code === p.product_code);
    if (existing) {
        existing.qty += 1;
    } else {
        basketItems.push({
            product_code: p.product_code,
            product_name: p.product_name,
            price: parseInt(p.product_price) || 0,
            stock: parseInt(p.product_stock) || 0,
            qty: 1,
            checked: true
        });
    }
    renderBasket();
}

function renderBasket() {
    const tbody = document.getElementById("basketTableBody");
    tbody.innerHTML = "";

    if (basketItems.length === 0) {
        tbody.innerHTML = `<tr><td colspan="8" class="text-center empty-msg">상품을 추가해주세요.</td></tr>`;
        recalcBasket();
        return;
    }

    basketItems.forEach((it, idx) => {
        const tr = document.createElement("tr");
        const subtotal = it.price * it.qty;
        const stockWarning = it.stock < it.qty ? `<span style="color:red;font-weight:bold;">(부족)</span>` : "";

        tr.innerHTML = `
            <td><input type="checkbox" class="basket-check" data-idx="${idx}" ${it.checked ? "checked" : ""}></td>
            <td><strong>${it.product_code}</strong></td>
            <td>${it.product_name}</td>
            <td class="text-right">${it.price.toLocaleString()}</td>
            <td><input type="number" min="1" max="999" value="${it.qty}" style="width:55px;" data-idx="${idx}" class="basket-qty-input"></td>
            <td class="text-right"><strong>${subtotal.toLocaleString()}</strong></td>
            <td class="text-center">${it.stock.toLocaleString()} ${stockWarning}</td>
            <td class="text-center"><button class="btn-danger btn-sm" data-idx="${idx}">&times;</button></td>
        `;

        // Qty change
        tr.querySelector(".basket-qty-input").addEventListener("change", (e) => {
            const val = parseInt(e.target.value) || 1;
            basketItems[idx].qty = Math.max(1, val);
            renderBasket();
        });

        // Checkbox change
        tr.querySelector(".basket-check").addEventListener("change", (e) => {
            basketItems[idx].checked = e.target.checked;
            recalcBasket();
        });

        // Delete button
        tr.querySelector(".btn-danger").addEventListener("click", () => {
            basketItems.splice(idx, 1);
            renderBasket();
        });

        tbody.appendChild(tr);
    });

    recalcBasket();
    makeTableResizable("basketTable", "ss_basket_col_widths");
}

function recalcBasket() {
    let count = 0;
    let total = 0;
    basketItems.forEach(it => {
        if (it.checked) {
            count += it.qty;
            total += (it.price * it.qty);
        }
    });
    document.getElementById("basketCount").textContent = count;
    document.getElementById("basketTotalPrice").textContent = total.toLocaleString();
}

function resetOrderForm() {
    if (basketItems.length > 0 && !confirm("입력 중인 주문 정보를 모두 초기화하시겠습니까?")) return;
    document.getElementById("orderCusCode").value = "";
    document.getElementById("orderCusName").value = "";
    document.getElementById("orderCusCall").value = "";
    document.getElementById("orderCusPhone").value = "";
    document.getElementById("orderAddress").value = "";
    document.getElementById("orderAddressDetail").value = "";
    document.getElementById("orderDelivery").value = "";
    document.getElementById("orderEtc").value = "";
    basketItems = [];
    renderBasket();
}

async function submitOrder() {
    const cusName = document.getElementById("orderCusName").value.trim();
    const cusCode = document.getElementById("orderCusCode").value.trim();
    const cusCall = document.getElementById("orderCusCall").value.trim();
    const cusPhone = document.getElementById("orderCusPhone").value.trim();
    const addr = document.getElementById("orderAddress").value.trim();
    const addrDetail = document.getElementById("orderAddressDetail").value.trim();
    const delivery = document.getElementById("orderDelivery").value.trim();
    const etc = document.getElementById("orderEtc").value.trim();

    if (!cusName) {
        alert("고객명을 입력해주세요.");
        document.getElementById("orderCusName").focus();
        return;
    }
    if (!addr) {
        alert("배송지 주소를 입력해주세요.");
        document.getElementById("orderAddress").focus();
        return;
    }

    const selectedItems = basketItems.filter(it => it.checked);
    if (selectedItems.length === 0) {
        alert("주문할 상품을 최소 1개 이상 선택(체크)해주세요.");
        return;
    }

    // Check stock warning
    const outOfStock = selectedItems.find(it => it.stock < it.qty);
    if (outOfStock) {
        if (!confirm(`[경고] 제품 '${outOfStock.product_name}'의 현재 재고(${outOfStock.stock}개)가 주문 수량(${outOfStock.qty}개)보다 부족합니다.\n그래도 주문을 계속 진행하시겠습니까?`)) {
            return;
        }
    }

    const fullAddress = addrDetail ? `${addr}<other>${addrDetail}` : addr;

    const payload = {
        account_code: currentUser ? currentUser.account_code : 1,
        cus_code: cusCode || null,
        cus_name: cusName,
        cus_call: cusCall,
        cus_phone: cusPhone,
        order_address: fullAddress,
        order_delivery: delivery,
        order_etc: etc,
        items: selectedItems.map(it => ({
            product_code: it.product_code,
            product_name: it.product_name,
            price: it.price,
            qty: it.qty
        }))
    };

    try {
        const res = await fetch(`${API_BASE}/api/orders`, {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(payload)
        });
        const data = await res.json();

        if (res.ok && data.status === "ok") {
            alert(`✅ 주문이 성공적으로 접수되었습니다!\n주문번호: #${data.order_index}`);
            resetOrderForm();
            // Refresh products for updated stock
            loadProducts();
        } else {
            alert("주문 접수 실패: " + (data.message || "알 수 없는 오류"));
        }
    } catch (err) {
        alert("서버 통신 오류: " + err.message);
    }
}

// ========================================================
// 4. TAB 2: ORDER MANAGEMENT (주문 관리 / 조회)
// ========================================================
let currentOrdersList = [];

function initOrdersTab() {
    document.getElementById("btnSearchOrders").addEventListener("click", loadOrders);
    document.getElementById("btnExportExcel").addEventListener("click", exportOrdersToExcel);
    document.getElementById("orderListSearch").addEventListener("keydown", (e) => {
        if (e.key === "Enter") loadOrders();
    });
    makeTableResizable("ordersGrid", "ss_order_col_widths");
}

function makeTableResizable(tableId, storageKey) {
    const table = document.getElementById(tableId);
    if (!table) return;
    const thead = table.querySelector("thead");
    if (!thead) return;
    const ths = thead.querySelectorAll("th");
    if (!ths || ths.length === 0) return;

    // Load saved widths from localStorage
    let savedWidths = {};
    try {
        savedWidths = JSON.parse(localStorage.getItem(storageKey) || "{}");
    } catch (e) {}

    // Explicitly fix every column to exact px so other columns NEVER auto-expand or shrink
    let totalWidth = 0;
    ths.forEach((th, idx) => {
        const w = savedWidths[idx] || th.offsetWidth || 100;
        th.style.width = w + "px";
        th.style.minWidth = w + "px";
        th.style.maxWidth = w + "px";
        totalWidth += w;
    });
    table.style.width = totalWidth + "px";

    // Setup resizers
    ths.forEach((th, idx) => {
        if (!th.querySelector(".resizer")) {
            const resizer = document.createElement("div");
            resizer.className = "resizer";
            th.appendChild(resizer);

            let startX = 0;
            let startWidth = 0;

            const onMouseMove = (e) => {
                const diff = e.pageX - startX;
                const newWidth = Math.max(30, startWidth + diff);
                th.style.width = newWidth + "px";
                th.style.minWidth = newWidth + "px";
                th.style.maxWidth = newWidth + "px";

                let sum = 0;
                ths.forEach(h => sum += (parseInt(h.style.width) || h.offsetWidth));
                table.style.width = sum + "px";
            };

            const onMouseUp = () => {
                resizer.classList.remove("resizing");
                document.removeEventListener("mousemove", onMouseMove);
                document.removeEventListener("mouseup", onMouseUp);

                const currentWidths = {};
                ths.forEach((h, i) => {
                    currentWidths[i] = parseInt(h.style.width) || h.offsetWidth;
                });
                localStorage.setItem(storageKey, JSON.stringify(currentWidths));
            };

            resizer.addEventListener("mousedown", (e) => {
                e.preventDefault();
                e.stopPropagation();
                startX = e.pageX;
                startWidth = parseInt(th.style.width) || th.offsetWidth;
                resizer.classList.add("resizing");
                document.addEventListener("mousemove", onMouseMove);
                document.addEventListener("mouseup", onMouseUp);
            });
        }
    });
}

async function loadOrders() {
    if (allProducts.length === 0) {
        await loadProducts();
    }
    const tbody = document.getElementById("ordersGridBody");
    tbody.innerHTML = `<tr><td colspan="11" class="text-center loading-msg">주문 내역을 조회 중입니다...</td></tr>`;

    const dateFrom = document.getElementById("orderDateFrom").value;
    const dateTo = document.getElementById("orderDateTo").value;
    const status = document.getElementById("orderStatusFilter").value;
    const accountCode = document.getElementById("orderAccountFilter").value;
    const search = document.getElementById("orderListSearch").value.trim();

    const params = new URLSearchParams();
    if (dateFrom) params.append("dateFrom", dateFrom);
    if (dateTo) params.append("dateTo", dateTo);
    if (status) params.append("status", status);
    if (accountCode) params.append("account_code", accountCode);
    if (search) params.append("search", search);

    try {
        const res = await fetch(`${API_BASE}/api/orders?${params.toString()}`);
        const data = await res.json();
        currentOrdersList = data.orders || [];

        document.getElementById("orderTotalCount").textContent = currentOrdersList.length.toLocaleString();
        renderOrdersGrid(currentOrdersList);
    } catch (err) {
        tbody.innerHTML = `<tr><td colspan="11" class="text-center empty-msg" style="color:red;">조회 실패: ${err.message}</td></tr>`;
    }
}

function renderOrdersGrid(orders) {
    const tbody = document.getElementById("ordersGridBody");
    tbody.innerHTML = "";

    if (!orders || orders.length === 0) {
        tbody.innerHTML = `<tr><td colspan="11" class="text-center empty-msg">조건에 해당하는 주문 내역이 없습니다.</td></tr>`;
        return;
    }

    const statusLabels = {
        0: { text: "접수대기", cls: "status-0" },
        1: { text: "접수완료", cls: "status-1" },
        2: { text: "배송중", cls: "status-2" },
        3: { text: "취소", cls: "status-3" },
        4: { text: "반품", cls: "status-4" }
    };

    orders.forEach(o => {
        const tr = document.createElement("tr");
        const st = statusLabels[o.order_status] || { text: "기타", cls: "status-0" };

        // Parse products summary with REAL product names!
        const parsedProducts = parseLegacyProducts(o.product_code) || [];
        const prodSummary = parsedProducts.length > 0
            ? parsedProducts.map(p => `${p.name || p.code} (${p.qty}개)`).join(", ")
            : "-";

        const cleanAddr = (o.order_address || "").replace("<other>", " ");
        const contact = o.cus_phone || o.cus_call || "-";

        tr.innerHTML = `
            <td class="text-center"><span class="badge-status ${st.cls}">${st.text}</span></td>
            <td class="text-center font-bold">#${o.index}</td>
            <td>${o.order_date_str || "-"}</td>
            <td>${o.account_name || "-"}</td>
            <td><strong>${o.cus_name || "-"}</strong></td>
            <td>${contact}</td>
            <td title="${cleanAddr}">${cleanAddr}</td>
            <td title="${prodSummary}"><strong>${prodSummary}</strong></td>
            <td>${o.order_delivery || "-"}</td>
            <td title="${o.order_etc || ""}">${o.order_etc || "-"}</td>
            <td class="text-center action-td">
                <select class="status-change-select" data-id="${o.index}">
                    <option value="1" ${o.order_status == 1 ? "selected" : ""}>접수완료</option>
                    <option value="2" ${o.order_status == 2 ? "selected" : ""}>배송중</option>
                    <option value="3" ${o.order_status == 3 ? "selected" : ""}>취소</option>
                    <option value="4" ${o.order_status == 4 ? "selected" : ""}>반품</option>
                    <option value="0" ${o.order_status == 0 ? "selected" : ""}>대기</option>
                </select>
                <button class="btn-sub btn-sm btn-edit-order" data-id="${o.index}">수정</button>
            </td>
        `;

        // Double click to open edit modal
        tr.addEventListener("dblclick", (e) => {
            if (e.target.tagName !== "SELECT" && e.target.tagName !== "BUTTON") {
                openOrderEditModal(o);
            }
        });

        // Status change
        tr.querySelector(".status-change-select").addEventListener("change", async (e) => {
            const newSt = e.target.value;
            await changeOrderStatus(o.index, newSt);
        });

        // Edit button
        tr.querySelector(".btn-edit-order").addEventListener("click", () => openOrderEditModal(o));

        tbody.appendChild(tr);
    });
    makeTableResizable("ordersGrid", "ss_order_col_widths");
}

async function changeOrderStatus(orderId, newStatus) {
    try {
        const res = await fetch(`${API_BASE}/api/orders/${orderId}/status`, {
            method: "PUT",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify({ status: newStatus })
        });
        const data = await res.json();
        if (res.ok && data.status === "ok") {
            loadOrders();
            loadProducts();
        } else {
            alert("상태 변경 실패: " + data.message);
            loadOrders();
        }
    } catch (err) {
        alert("통신 오류: " + err.message);
    }
}

function parseLegacyProducts(raw) {
    if (!raw) return [];
    const items = [];
    const spl = raw.split("<product>");
    spl.forEach(p => {
        if (!p.trim()) return;
        const br = p.split("<br>");
        if (br.length >= 3) {
            const pCode = br[0].trim();
            const pName = getProductName(pCode);
            items.push({
                code: pCode,
                name: pName,
                price: parseInt(br[1]) || 0,
                qty: parseInt(br[2]) || 1
            });
        }
    });
    return items;
}

function openOrderEditModal(o) {
    document.getElementById("modalOrderIndex").value = o.index;
    document.getElementById("modalOrderIndexDisplay").value = `#${o.index}`;
    document.getElementById("modalOrderDate").value = o.order_date_str || "";
    document.getElementById("modalOrderCusName").value = o.cus_name || "";
    document.getElementById("modalOrderPhone").value = o.cus_phone || o.cus_call || "";
    document.getElementById("modalOrderAddress").value = (o.order_address || "").replace("<other>", " ");
    document.getElementById("modalOrderDelivery").value = o.order_delivery || "";
    document.getElementById("modalOrderEtc").value = o.order_etc || "";

    // Product pills
    const pillsBox = document.getElementById("modalOrderProducts");
    pillsBox.innerHTML = "";
    const items = parseLegacyProducts(o.product_code);
    items.forEach(it => {
        const pill = document.createElement("span");
        pill.className = "product-pill";
        pill.textContent = `${it.name} (${it.code}, ${it.qty}개, ${(it.price * it.qty).toLocaleString()}원)`;
        pillsBox.appendChild(pill);
    });

    document.getElementById("orderDetailModal").classList.remove("hidden");
}

document.getElementById("btnSaveOrderEdit").addEventListener("click", async () => {
    const orderId = document.getElementById("modalOrderIndex").value;
    const address = document.getElementById("modalOrderAddress").value.trim();
    const delivery = document.getElementById("modalOrderDelivery").value.trim();
    const etc = document.getElementById("modalOrderEtc").value.trim();

    try {
        const res = await fetch(`${API_BASE}/api/orders/${orderId}`, {
            method: "PUT",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify({
                order_address: address,
                order_delivery: delivery,
                order_etc: etc
            })
        });
        const data = await res.json();
        if (res.ok && data.status === "ok") {
            alert("주문 정보가 수정되었습니다.");
            document.getElementById("orderDetailModal").classList.add("hidden");
            loadOrders();
        } else {
            alert("수정 실패: " + data.message);
        }
    } catch (err) {
        alert("통신 오류: " + err.message);
    }
});

function exportOrdersToExcel() {
    if (!currentOrdersList || currentOrdersList.length === 0) {
        alert("다운로드할 주문 내역이 없습니다.");
        return;
    }

    const statusMap = { 0: "접수대기", 1: "접수완료", 2: "배송중", 3: "취소", 4: "반품" };

    const rows = currentOrdersList.map(o => {
        const prods = parseLegacyProducts(o.product_code).map(p => `${p.name} (${p.qty}개)`).join(", ");
        return {
            "주문상태": statusMap[o.order_status] || "기타",
            "주문번호": o.index,
            "접수일시": o.order_date_str || "",
            "담당사원": o.account_name || "",
            "고객명": o.cus_name || "",
            "전화번호": o.cus_call || "",
            "휴대전화": o.cus_phone || "",
            "배송주소": (o.order_address || "").replace("<other>", " "),
            "주문상품": prods,
            "배송처": o.order_delivery || "",
            "비고": o.order_etc || ""
        };
    });

    const ws = XLSX.utils.json_to_sheet(rows);
    const wb = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, "주문내역");

    const todayStr = new Date().toISOString().split("T")[0];
    XLSX.writeFile(wb, `성신판매접수_주문목록_${todayStr}.xlsx`);
}

// ========================================================
// 5. TAB 3: CUSTOMERS (고객 관리)
// ========================================================
function initCustomersTab() {
    document.getElementById("btnSearchCustomers").addEventListener("click", () => {
        loadCustomers(document.getElementById("cusSearchInput").value.trim());
    });
    document.getElementById("cusSearchInput").addEventListener("keydown", (e) => {
        if (e.key === "Enter") loadCustomers(e.target.value.trim());
    });

    document.getElementById("btnNewCustomer").addEventListener("click", clearCustomerForm);
    document.getElementById("btnSaveCustomer").addEventListener("click", saveCustomer);
    document.getElementById("btnDeleteCustomer").addEventListener("click", deleteCustomer);
    makeTableResizable("customersGrid", "ss_customer_col_widths");
}

async function loadCustomers(query = "") {
    const tbody = document.getElementById("customersGridBody");
    tbody.innerHTML = `<tr><td colspan="5" class="text-center loading-msg">고객 목록을 불러오는 중...</td></tr>`;

    try {
        const res = await fetch(`${API_BASE}/api/customers${query ? "?query=" + encodeURIComponent(query) : ""}`);
        const data = await res.json();
        const list = data.customers || [];
        tbody.innerHTML = "";

        if (list.length === 0) {
            tbody.innerHTML = `<tr><td colspan="5" class="text-center empty-msg">고객 데이터가 없습니다.</td></tr>`;
            return;
        }

        list.forEach(c => {
            const tr = document.createElement("tr");
            tr.innerHTML = `
                <td class="text-center">${c.cus_code}</td>
                <td><strong>${c.cus_name}</strong></td>
                <td>${c.cus_call || "-"}</td>
                <td>${c.cus_phone || "-"}</td>
                <td>${c.account_name || "-"}</td>
            `;
            tr.addEventListener("click", () => {
                document.querySelectorAll("#customersGrid tr").forEach(r => r.classList.remove("selected"));
                tr.classList.add("selected");
                populateCustomerForm(c);
            });
            tbody.appendChild(tr);
        });
        makeTableResizable("customersGrid", "ss_customer_col_widths");
    } catch (err) {
        tbody.innerHTML = `<tr><td colspan="5" class="text-center empty-msg" style="color:red;">오류: ${err.message}</td></tr>`;
    }
}

function populateCustomerForm(c) {
    document.getElementById("cusFormTitle").textContent = `고객 정보 수정 [코드: ${c.cus_code}]`;
    document.getElementById("cusDetailCode").value = c.cus_code;
    document.getElementById("cusDetailName").value = c.cus_name;
    document.getElementById("cusDetailCall").value = c.cus_call || "";
    document.getElementById("cusDetailPhone").value = c.cus_phone || "";
    document.getElementById("cusDetailAddress").value = (c.cus_address || "").replace("<other>", " ");
    document.getElementById("btnDeleteCustomer").classList.remove("hidden");
}

function clearCustomerForm() {
    document.getElementById("cusFormTitle").textContent = "신규 고객 등록";
    document.getElementById("cusDetailCode").value = "";
    document.getElementById("cusDetailName").value = "";
    document.getElementById("cusDetailCall").value = "";
    document.getElementById("cusDetailPhone").value = "";
    document.getElementById("cusDetailAddress").value = "";
    document.getElementById("btnDeleteCustomer").classList.add("hidden");
    document.querySelectorAll("#customersGrid tr").forEach(r => r.classList.remove("selected"));
}

async function saveCustomer() {
    const code = document.getElementById("cusDetailCode").value;
    const name = document.getElementById("cusDetailName").value.trim();
    const call = document.getElementById("cusDetailCall").value.trim();
    const phone = document.getElementById("cusDetailPhone").value.trim();
    const addr = document.getElementById("cusDetailAddress").value.trim();

    if (!name) {
        alert("고객명을 입력해주세요.");
        return;
    }

    const payload = {
        cus_name: name,
        cus_call: call,
        cus_phone: phone,
        cus_address: addr,
        account_code: currentUser ? currentUser.account_code : 1
    };

    try {
        let res;
        if (code) {
            res = await fetch(`${API_BASE}/api/customers/${code}`, {
                method: "PUT",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify(payload)
            });
        } else {
            res = await fetch(`${API_BASE}/api/customers`, {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify(payload)
            });
        }
        const data = await res.json();
        if (res.ok && data.status === "ok") {
            alert(data.message || "저장되었습니다.");
            loadCustomers();
            clearCustomerForm();
        } else {
            alert("저장 실패: " + data.message);
        }
    } catch (err) {
        alert("통신 오류: " + err.message);
    }
}

async function deleteCustomer() {
    const code = document.getElementById("cusDetailCode").value;
    if (!code) return;
    if (!confirm(`정말로 고객 [코드: ${code}]을(를) 삭제하시겠습니까?`)) return;

    try {
        const res = await fetch(`${API_BASE}/api/customers/${code}`, { method: "DELETE" });
        const data = await res.json();
        if (res.ok && data.status === "ok") {
            alert("고객이 삭제되었습니다.");
            loadCustomers();
            clearCustomerForm();
        } else {
            alert("삭제 실패: " + data.message);
        }
    } catch (err) {
        alert("통신 오류: " + err.message);
    }
}

// ========================================================
// 6. TAB 4: PRODUCTS & STOCK (제품 / 재고 관리)
// ========================================================
function initProductsTab() {
    document.getElementById("btnFilterProducts").addEventListener("click", filterProductsGrid);
    document.getElementById("productSearchInput").addEventListener("input", filterProductsGrid);

    document.getElementById("btnNewProduct").addEventListener("click", clearProductForm);
    document.getElementById("btnSaveProduct").addEventListener("click", saveProduct);
    document.getElementById("btnDeleteProduct").addEventListener("click", deleteProduct);
    makeTableResizable("productsGrid", "ss_product_col_widths");
}

async function loadProducts() {
    try {
        const res = await fetch(`${API_BASE}/api/products`);
        const data = await res.json();
        allProducts = data.products || [];
        renderProductsGrid(allProducts);
    } catch (err) {
        console.error("Products load error:", err);
    }
}

function renderProductsGrid(products) {
    const tbody = document.getElementById("productsGridBody");
    tbody.innerHTML = "";

    if (!products || products.length === 0) {
        tbody.innerHTML = `<tr><td colspan="5" class="text-center empty-msg">등록된 제품이 없습니다.</td></tr>`;
        return;
    }

    products.forEach(p => {
        const tr = document.createElement("tr");
        const price = parseInt(p.product_price) || 0;
        const stock = parseInt(p.product_stock) || 0;
        const teamLabel = p.team_code === 1 ? "직판" : "TM";

        tr.innerHTML = `
            <td><strong>${p.product_code}</strong></td>
            <td>${p.product_name}</td>
            <td class="text-right">${price.toLocaleString()}원</td>
            <td class="text-center ${stock <= 5 ? "font-bold text-danger" : ""}">${stock.toLocaleString()}</td>
            <td class="text-center">${teamLabel}</td>
        `;

        tr.addEventListener("click", () => {
            document.querySelectorAll("#productsGrid tr").forEach(r => r.classList.remove("selected"));
            tr.classList.add("selected");
            populateProductForm(p);
        });

        tbody.appendChild(tr);
    });
    makeTableResizable("productsGrid", "ss_product_col_widths");
}

function filterProductsGrid() {
    const q = document.getElementById("productSearchInput").value.trim().toLowerCase();
    if (!q) {
        renderProductsGrid(allProducts);
        return;
    }
    const filtered = allProducts.filter(p =>
        p.product_code.toLowerCase().includes(q) ||
        p.product_name.toLowerCase().includes(q)
    );
    renderProductsGrid(filtered);
}

function populateProductForm(p) {
    document.getElementById("productFormTitle").textContent = `제품 정보 수정 [코드: ${p.product_code}]`;
    const codeInput = document.getElementById("prodDetailCode");
    codeInput.value = p.product_code;
    codeInput.readOnly = true;

    document.getElementById("prodDetailName").value = p.product_name;
    document.getElementById("prodDetailPrice").value = p.product_price;
    document.getElementById("prodDetailStock").value = p.product_stock;
    document.getElementById("prodDetailTeam").value = p.team_code || 1;
    document.getElementById("prodDetailGb").value = p.gb_code || 1;
    document.getElementById("btnDeleteProduct").classList.remove("hidden");
}

function clearProductForm() {
    document.getElementById("productFormTitle").textContent = "신규 제품 등록";
    const codeInput = document.getElementById("prodDetailCode");
    codeInput.value = "";
    codeInput.readOnly = false;
    document.getElementById("prodDetailName").value = "";
    document.getElementById("prodDetailPrice").value = 0;
    document.getElementById("prodDetailStock").value = 0;
    document.getElementById("btnDeleteProduct").classList.add("hidden");
    document.querySelectorAll("#productsGrid tr").forEach(r => r.classList.remove("selected"));
}

async function saveProduct() {
    const code = document.getElementById("prodDetailCode").value.trim();
    const name = document.getElementById("prodDetailName").value.trim();
    const price = parseInt(document.getElementById("prodDetailPrice").value) || 0;
    const stock = parseInt(document.getElementById("prodDetailStock").value) || 0;
    const team = parseInt(document.getElementById("prodDetailTeam").value) || 1;
    const gb = parseInt(document.getElementById("prodDetailGb").value) || 1;

    if (!code || !name) {
        alert("제품코드와 제품명을 모두 입력해주세요.");
        return;
    }

    const payload = {
        product_code: code,
        product_name: name,
        product_price: price,
        product_stock: stock,
        team_code: team,
        gb_code: gb
    };

    try {
        const isEdit = document.getElementById("prodDetailCode").readOnly;
        const res = isEdit
            ? await fetch(`${API_BASE}/api/products/${code}`, {
                method: "PUT",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify(payload)
            })
            : await fetch(`${API_BASE}/api/products`, {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify(payload)
            });

        const data = await res.json();
        if (res.ok && data.status === "ok") {
            alert("제품이 저장되었습니다.");
            await loadProducts();
            clearProductForm();
        } else {
            alert("저장 실패: " + data.message);
        }
    } catch (err) {
        alert("통신 오류: " + err.message);
    }
}

async function deleteProduct() {
    const code = document.getElementById("prodDetailCode").value.trim();
    if (!code) return;
    if (!confirm(`정말로 제품 [코드: ${code}]을(를) 삭제하시겠습니까?`)) return;

    try {
        const res = await fetch(`${API_BASE}/api/products/${code}`, { method: "DELETE" });
        const data = await res.json();
        if (res.ok && data.status === "ok") {
            alert("제품이 삭제되었습니다.");
            await loadProducts();
            clearProductForm();
        } else {
            alert("삭제 실패: " + data.message);
        }
    } catch (err) {
        alert("통신 오류: " + err.message);
    }
}

// ========================================================
// 7. TAB 5: ACCOUNTS (사원 / 계정 관리)
// ========================================================
function initAccountsTab() {
    document.getElementById("btnNewAccount").addEventListener("click", clearAccountForm);
    document.getElementById("btnSaveAccount").addEventListener("click", saveAccount);
    document.getElementById("btnDeleteAccount").addEventListener("click", deleteAccount);
    makeTableResizable("accountsGrid", "ss_account_col_widths");
}

async function loadAccounts() {
    try {
        const res = await fetch(`${API_BASE}/api/accounts`);
        const data = await res.json();
        allAccounts = data.accounts || [];
        renderAccountsGrid(allAccounts);
        updateAccountFilterOptions(allAccounts);
    } catch (err) {
        console.error("Accounts load error:", err);
    }
}

function renderAccountsGrid(accounts) {
    const tbody = document.getElementById("accountsGridBody");
    tbody.innerHTML = "";

    if (!accounts || accounts.length === 0) {
        tbody.innerHTML = `<tr><td colspan="6" class="text-center empty-msg">계정 데이터가 없습니다.</td></tr>`;
        return;
    }

    accounts.forEach(a => {
        const tr = document.createElement("tr");
        tr.innerHTML = `
            <td class="text-center">${a.account_code}</td>
            <td><strong>${a.account_id}</strong></td>
            <td>${a.account_name}</td>
            <td>${a.acgb || "사원"}</td>
            <td>${a.team || "-"}</td>
            <td>${a.allow_ip || "모두 허용"}</td>
        `;
        tr.addEventListener("click", () => {
            document.querySelectorAll("#accountsGrid tr").forEach(r => r.classList.remove("selected"));
            tr.classList.add("selected");
            populateAccountForm(a);
        });
        tbody.appendChild(tr);
    });
    makeTableResizable("accountsGrid", "ss_account_col_widths");
}

function updateAccountFilterOptions(accounts) {
    const sel = document.getElementById("orderAccountFilter");
    sel.innerHTML = `<option value="">전체 사원</option>`;
    accounts.forEach(a => {
        const opt = document.createElement("option");
        opt.value = a.account_code;
        opt.textContent = `${a.account_name} (${a.account_id})`;
        sel.appendChild(opt);
    });
}

function populateAccountForm(a) {
    document.getElementById("accountFormTitle").textContent = `계정 정보 수정 [코드: ${a.account_code}]`;
    document.getElementById("accDetailCode").value = a.account_code;
    document.getElementById("accDetailId").value = a.account_id;
    document.getElementById("accDetailPw").value = a.account_pw;
    document.getElementById("accDetailName").value = a.account_name;
    document.getElementById("accDetailAcgb").value = a.acgb_code || 2;
    document.getElementById("accDetailTeam").value = a.team_code || 1;
    document.getElementById("accDetailIp").value = a.allow_ip || "";
    document.getElementById("btnDeleteAccount").classList.remove("hidden");
}

function clearAccountForm() {
    document.getElementById("accountFormTitle").textContent = "신규 사원 등록";
    document.getElementById("accDetailCode").value = "";
    document.getElementById("accDetailId").value = "";
    document.getElementById("accDetailPw").value = "";
    document.getElementById("accDetailName").value = "";
    document.getElementById("accDetailIp").value = "";
    document.getElementById("btnDeleteAccount").classList.add("hidden");
    document.querySelectorAll("#accountsGrid tr").forEach(r => r.classList.remove("selected"));
}

async function saveAccount() {
    const code = document.getElementById("accDetailCode").value;
    const id = document.getElementById("accDetailId").value.trim();
    const pw = document.getElementById("accDetailPw").value.trim();
    const name = document.getElementById("accDetailName").value.trim();
    const acgb = parseInt(document.getElementById("accDetailAcgb").value) || 2;
    const team = parseInt(document.getElementById("accDetailTeam").value) || 1;
    const ip = document.getElementById("accDetailIp").value.trim();

    if (!id || !pw || !name) {
        alert("아이디, 비밀번호, 사원명은 필수 항목입니다.");
        return;
    }

    const payload = {
        account_id: id,
        account_pw: pw,
        account_name: name,
        acgb_code: acgb,
        team_code: team,
        allow_ip: ip || null
    };

    try {
        let res;
        if (code) {
            res = await fetch(`${API_BASE}/api/accounts/${code}`, {
                method: "PUT",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify(payload)
            });
        } else {
            res = await fetch(`${API_BASE}/api/accounts`, {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify(payload)
            });
        }

        const data = await res.json();
        if (res.ok && data.status === "ok") {
            alert(data.message || "계정이 저장되었습니다.");
            loadAccounts();
            clearAccountForm();
        } else {
            alert("저장 실패: " + data.message);
        }
    } catch (err) {
        alert("통신 오류: " + err.message);
    }
}

async function deleteAccount() {
    const code = document.getElementById("accDetailCode").value;
    if (!code) return;
    if (currentUser && currentUser.account_code === parseInt(code)) {
        alert("현재 로그인 중인 본인 계정은 삭제할 수 없습니다.");
        return;
    }
    if (!confirm(`정말로 사원 계정 [코드: ${code}]을(를) 삭제하시겠습니까?`)) return;

    try {
        const res = await fetch(`${API_BASE}/api/accounts/${code}`, { method: "DELETE" });
        const data = await res.json();
        if (res.ok && data.status === "ok") {
            alert("계정이 삭제되었습니다.");
            loadAccounts();
            clearAccountForm();
        } else {
            alert("삭제 실패: " + data.message);
        }
    } catch (err) {
        alert("통신 오류: " + err.message);
    }
}

// ========================================================
// 8. TAB 6: CTI MANAGEMENT (CTI 상담 관리)
// ========================================================
function initCtiTab() {
    document.getElementById("ctiDbSelect").addEventListener("change", (e) => {
        ctiCurrentDbIdx = e.target.value;
        ctiCurrentPage = 0;
        loadCtiTmList();
    });

    document.getElementById("btnSearchCti").addEventListener("click", () => {
        ctiCurrentPage = 0;
        loadCtiTmList();
    });

    document.getElementById("btnCtiPrev").addEventListener("click", () => {
        if (ctiCurrentPage > 0) {
            ctiCurrentPage--;
            loadCtiTmList();
        }
    });

    document.getElementById("btnCtiNext").addEventListener("click", () => {
        ctiCurrentPage++;
        loadCtiTmList();
    });

    makeTableResizable("ctiGrid", "ss_cti_col_widths");
}

async function loadCtiDbs() {
    try {
        const res = await fetch(`${API_BASE}/api/cti/dbs`);
        const data = await res.json();
        const sel = document.getElementById("ctiDbSelect");
        sel.innerHTML = `<option value="">DB 선택...</option>`;

        (data.dbs || []).forEach(d => {
            const opt = document.createElement("option");
            opt.value = d.idx;
            opt.textContent = `${d.name} (총 ${d.total_count.toLocaleString()}건)`;
            opt.dataset.stats = `총: ${d.total_count.toLocaleString()}건 | 미배분: ${d.nosplit_count.toLocaleString()}건 | 블랙리스트: ${d.blacklist_count.toLocaleString()}건`;
            sel.appendChild(opt);
        });

        if (data.dbs && data.dbs.length > 0 && !ctiCurrentDbIdx) {
            sel.selectedIndex = 1;
            ctiCurrentDbIdx = sel.value;
            loadCtiTmList();
        }
    } catch (err) {
        console.error("CTI DBs error:", err);
    }
}

async function loadCtiTmList() {
    if (!ctiCurrentDbIdx) return;
    const sel = document.getElementById("ctiDbSelect");
    const selectedOpt = sel.options[sel.selectedIndex];
    if (selectedOpt && selectedOpt.dataset.stats) {
        document.getElementById("ctiDbStats").textContent = selectedOpt.dataset.stats;
    }

    const tbody = document.getElementById("ctiGridBody");
    tbody.innerHTML = `<tr><td colspan="9" class="text-center loading-msg">TM 리스트를 불러오는 중...</td></tr>`;

    const search = document.getElementById("ctiSearchInput").value.trim();
    const params = new URLSearchParams({
        db_idx: ctiCurrentDbIdx,
        page: ctiCurrentPage
    });
    if (search) params.append("search", search);

    try {
        const res = await fetch(`${API_BASE}/api/cti/tm_list?${params.toString()}`);
        const data = await res.json();
        const total = data.total || 0;
        const items = data.items || [];

        const maxPage = Math.max(1, Math.ceil(total / 100));
        document.getElementById("ctiPageIndicator").textContent = `${ctiCurrentPage + 1} / ${maxPage} (총 ${total.toLocaleString()}건)`;

        renderCtiGrid(items);
    } catch (err) {
        tbody.innerHTML = `<tr><td colspan="9" class="text-center empty-msg" style="color:red;">조회 실패: ${err.message}</td></tr>`;
    }
}

const CTI_RESULTS = {
    0: { text: "미처리", cls: "status-0" },
    1: { text: "동의", cls: "status-1" },
    2: { text: "무관심", cls: "status-2" },
    3: { text: "TM거부", cls: "status-3" },
    4: { text: "부재중", cls: "status-0" },
    5: { text: "통화중", cls: "status-0" },
    6: { text: "예약", cls: "status-2" },
    7: { text: "결번", cls: "status-3" },
    8: { text: "본인아님", cls: "status-3" }
};

function renderCtiGrid(items) {
    const tbody = document.getElementById("ctiGridBody");
    tbody.innerHTML = "";

    if (!items || items.length === 0) {
        tbody.innerHTML = `<tr><td colspan="9" class="text-center empty-msg">조회된 데이터가 없습니다.</td></tr>`;
        return;
    }

    items.forEach((item, idx) => {
        const tr = document.createElement("tr");
        const st = CTI_RESULTS[item.result] || { text: "미처리", cls: "status-0" };

        tr.innerHTML = `
            <td class="text-center">${(ctiCurrentPage * 100) + idx + 1}</td>
            <td><strong>${item.name || "-"}</strong></td>
            <td>${item.phone_number || "-"}</td>
            <td>${item.home_number || "-"}</td>
            <td>${item.product_name || "-"}</td>
            <td class="text-center"><span class="badge-status ${st.cls}">${st.text}</span></td>
            <td class="text-center">${item.call_count || 0}</td>
            <td title="${item.comment || ""}">${item.comment || "-"}</td>
            <td class="text-center">
                <button class="btn-primary btn-sm btn-cti-call" data-idx="${item.idx}">상담기록</button>
            </td>
        `;

        tr.querySelector(".btn-cti-call").addEventListener("click", () => openCtiResultModal(item));
        tbody.appendChild(tr);
    });
    makeTableResizable("ctiGrid", "ss_cti_col_widths");
}

function openCtiResultModal(item) {
    document.getElementById("modalCtiIdx").value = item.idx;
    document.getElementById("modalCtiCusName").textContent = item.name || "-";
    document.getElementById("modalCtiPhone").textContent = item.phone_number || item.home_number || "-";
    document.getElementById("modalCtiResultCode").value = item.result || 1;
    document.getElementById("modalCtiComment").value = item.comment || "";
    document.getElementById("ctiResultModal").classList.remove("hidden");
}

document.getElementById("btnSaveCtiResult").addEventListener("click", async () => {
    const idx = document.getElementById("modalCtiIdx").value;
    const result = parseInt(document.getElementById("modalCtiResultCode").value) || 0;
    const comment = document.getElementById("modalCtiComment").value.trim();

    try {
        const res = await fetch(`${API_BASE}/api/cti/result`, {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify({ idx, result, comment })
        });
        const data = await res.json();
        if (res.ok && data.status === "ok") {
            alert("상담 결과가 저장되었습니다.");
            document.getElementById("ctiResultModal").classList.add("hidden");
            loadCtiTmList();
        } else {
            alert("저장 실패: " + data.message);
        }
    } catch (err) {
        alert("통신 오류: " + err.message);
    }
});

// ========================================================
// 9. MODALS & PRODUCT SELECTION
// ========================================================
function initModals() {
    // Close modal on click of [data-close] or backdrop
    document.querySelectorAll("[data-close]").forEach(btn => {
        btn.addEventListener("click", () => {
            const modalId = btn.getAttribute("data-close");
            const m = document.getElementById(modalId);
            if (m) m.classList.add("hidden");
        });
    });

    document.querySelectorAll(".modal-overlay").forEach(overlay => {
        overlay.addEventListener("click", (e) => {
            if (e.target === overlay) overlay.classList.add("hidden");
        });
    });

    // Product search inside product modal
    document.getElementById("modalProductSearch").addEventListener("input", filterModalProducts);
}

function openProductModal() {
    renderModalProducts(allProducts);
    document.getElementById("productModal").classList.remove("hidden");
    document.getElementById("modalProductSearch").focus();
}

function renderModalProducts(products) {
    const tbody = document.getElementById("modalProductsGridBody");
    tbody.innerHTML = "";

    if (!products || products.length === 0) {
        tbody.innerHTML = `<tr><td colspan="5" class="text-center empty-msg">제품이 없습니다.</td></tr>`;
        return;
    }

    products.forEach(p => {
        const tr = document.createElement("tr");
        const price = parseInt(p.product_price) || 0;
        const stock = parseInt(p.product_stock) || 0;

        tr.innerHTML = `
            <td><strong>${p.product_code}</strong></td>
            <td>${p.product_name}</td>
            <td class="text-right">${price.toLocaleString()}원</td>
            <td class="text-center">${stock.toLocaleString()}</td>
            <td class="text-center"><button class="btn-primary btn-sm btn-pick-product">선택</button></td>
        `;

        const selectHandler = () => {
            addProductToBasket(p);
            document.getElementById("productModal").classList.add("hidden");
        };

        tr.addEventListener("dblclick", selectHandler);
        tr.querySelector(".btn-pick-product").addEventListener("click", selectHandler);

        tbody.appendChild(tr);
    });
    makeTableResizable("modalProductsGrid", "ss_modal_prod_col_widths");
}

function filterModalProducts() {
    const q = document.getElementById("modalProductSearch").value.trim().toLowerCase();
    if (!q) {
        renderModalProducts(allProducts);
        return;
    }
    const filtered = allProducts.filter(p =>
        p.product_code.toLowerCase().includes(q) ||
        p.product_name.toLowerCase().includes(q)
    );
    renderModalProducts(filtered);
}
