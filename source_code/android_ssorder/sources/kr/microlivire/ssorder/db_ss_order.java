package kr.microlivire.ssorder;

import java.text.NumberFormat;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.Locale;
import org.json.JSONException;
import org.json.JSONObject;

public class db_ss_order {
    public String _order_product_names = BuildConfig.FLAVOR;
    public String _order_product_price;
    int account_code;
    String account_name;
    String cus_call;
    int cus_code;
    String cus_name;
    String cus_phone;
    int index;
    String order_address;
    String order_date;
    public String order_delivery;
    String order_etc;
    public int order_status;
    String product_code;
    public ArrayList<ProductClass> products;

    public db_ss_order(JSONObject jSONObject) throws JSONException {
        String str;
        this.index = jSONObject.getInt("index");
        this.account_code = jSONObject.getInt("account_code");
        this.cus_code = jSONObject.getInt("cus_code");
        this.cus_name = jSONObject.getString("cus_name");
        this.cus_call = jSONObject.getString("cus_call");
        this.cus_phone = jSONObject.getString("cus_phone");
        this.product_code = jSONObject.getString("product_code");
        this.order_address = jSONObject.getString("order_address").replace("<other>", " ");
        this.order_date = jSONObject.getString("order_date");
        this.order_status = jSONObject.getInt("order_status");
        this.order_delivery = jSONObject.getString("order_delivery").replace("<other>", " ");
        this.order_etc = jSONObject.getString("order_etc").replace("<end>", BuildConfig.FLAVOR);
        this.products = new ArrayList<>();
        int i = 0;
        for (String split : Module.getInstance().RemoveEmptyEntity(this.product_code.split("<product>"))) {
            String[] split2 = split.split("<br>");
            try {
                if (split2.length == 3) {
                    this.products.add(new ProductClass(split2[0], Integer.valueOf(split2[1]).intValue(), Integer.valueOf(split2[2]).intValue(), BuildConfig.FLAVOR));
                } else {
                    this.products.add(new ProductClass(split2[0], Integer.valueOf(split2[1]).intValue(), Integer.valueOf(split2[2]).intValue(), split2[3]));
                }
            } catch (Exception unused) {
            }
        }
        Iterator<ProductClass> it = this.products.iterator();
        while (it.hasNext()) {
            ProductClass next = it.next();
            StringBuilder sb = new StringBuilder();
            sb.append(this._order_product_names);
            sb.append(next._gb_code == 1 ? "[본품] " : "[사례] ");
            sb.append("[");
            sb.append(next.getProductName());
            sb.append("] ￦");
            sb.append(NumberFormat.getNumberInstance(Locale.US).format((long) next.getProductPrice()));
            if (next._gb_code == 2) {
                str = " X " + next.getProductCount() + "개";
            } else {
                str = BuildConfig.FLAVOR;
            }
            sb.append(str);
            String str2 = "\n\n";
            if (!next.getETC().isEmpty()) {
                str2 = "\n[비고] " + next.getETC() + str2;
            }
            sb.append(str2);
            this._order_product_names = sb.toString();
            i += next.getGopPrice();
        }
        this._order_product_names = this._order_product_names.trim();
        this._order_product_price = "￦" + NumberFormat.getNumberInstance(Locale.US).format((long) i);
    }

    public String getProducts() {
        Iterator<ProductClass> it = this.products.iterator();
        String str = BuildConfig.FLAVOR;
        while (it.hasNext()) {
            ProductClass next = it.next();
            str = str + "<product>" + next._product_code + "<br>" + next._product_price + "<br>" + next._product_count + "<br>" + next._order_etc;
        }
        return str;
    }

    public String getCall() {
        if (this.cus_call.isEmpty()) {
            return "-";
        }
        return this.cus_call;
    }

    public String getPhone() {
        if (this.cus_phone.isEmpty()) {
            return "-";
        }
        return this.cus_phone;
    }

    public String getDeliveryCode() {
        if (this.order_delivery.isEmpty()) {
            return "-";
        }
        return this.order_delivery;
    }

    public String getETC() {
        if (this.order_etc.isEmpty()) {
            return "-";
        }
        return this.order_etc;
    }
}
