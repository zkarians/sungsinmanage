package kr.microlivire.ssorder;

import java.text.NumberFormat;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.Locale;

public class OrderClass {
    private String _order_cuscall;
    public String _order_cuscode;
    public String _order_cusdelivery;
    public String _order_cusname;
    private String _order_cusphone;
    public String _order_date;
    public String _order_delivery;
    public String _order_etc;
    public String _order_index;
    public String _order_product_names = BuildConfig.FLAVOR;
    public String _order_product_price;
    public int _order_status;
    public ArrayList<ProductClass> products = new ArrayList<>();

    public OrderClass(String str, String str2, String str3, String str4, String str5, String str6, String str7, String str8, int i, String str9, String str10) {
        String str11;
        int i2 = 0;
        for (String split : Module.getInstance().RemoveEmptyEntity(str8.split("<product>"))) {
            String[] split2 = split.split("<br>");
            try {
                if (split2.length == 4) {
                    ArrayList<ProductClass> arrayList = this.products;
                    ProductClass productClass = r11;
                    ProductClass productClass2 = new ProductClass(split2[0], Integer.valueOf(split2[1]).intValue(), Integer.valueOf(split2[2]).intValue(), BuildConfig.FLAVOR, Integer.valueOf(split2[3]).intValue());
                    arrayList.add(productClass);
                } else {
                    ArrayList<ProductClass> arrayList2 = this.products;
                    ProductClass productClass3 = r12;
                    ProductClass productClass4 = new ProductClass(split2[0], Integer.valueOf(split2[1]).intValue(), Integer.valueOf(split2[2]).intValue(), split2[3], Integer.valueOf(split2[4]).intValue());
                    arrayList2.add(productClass3);
                }
            } catch (Exception unused) {
            }
        }
        this._order_index = str;
        this._order_date = str2;
        this._order_cuscode = str3;
        this._order_cusname = str4;
        this._order_cuscall = str5;
        this._order_cusphone = str6;
        this._order_cusdelivery = str7.replace("<other>", " ");
        this._order_etc = str10.replace("<end>", BuildConfig.FLAVOR);
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
                str11 = " X " + next.getProductCount() + "개";
            } else {
                str11 = BuildConfig.FLAVOR;
            }
            sb.append(str11);
            String str12 = "\n\n";
            if (!next.getETC().isEmpty()) {
                str12 = "\n[비고] " + next.getETC() + str12;
            }
            sb.append(str12);
            this._order_product_names = sb.toString();
            i2 += next.getGopPrice();
        }
        this._order_product_names = this._order_product_names.trim();
        this._order_product_price = "￦" + NumberFormat.getNumberInstance(Locale.US).format((long) i2);
        this._order_status = i;
        this._order_delivery = str9;
    }

    public String getCall() {
        if (this._order_cuscall.isEmpty()) {
            return "-";
        }
        return this._order_cuscall;
    }

    public String getPhone() {
        if (this._order_cusphone.isEmpty()) {
            return "-";
        }
        return this._order_cusphone;
    }

    public String getDeliveryCode() {
        if (this._order_delivery.isEmpty()) {
            return "-";
        }
        return this._order_delivery;
    }

    public String getETC() {
        if (this._order_etc.isEmpty()) {
            return "-";
        }
        return this._order_etc;
    }
}
