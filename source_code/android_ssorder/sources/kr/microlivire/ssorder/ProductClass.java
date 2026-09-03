package kr.microlivire.ssorder;

import java.util.Iterator;

public class ProductClass {
    int _gb_code;
    String _order_delivery;
    String _order_etc = BuildConfig.FLAVOR;
    String _product_code;
    int _product_count = 1;
    String _product_name;
    int _product_price;
    int _product_stock;

    public ProductClass(String str, int i, String str2, int i2, int i3) {
        this._product_code = str;
        this._gb_code = i;
        this._product_name = str2;
        this._product_price = i2;
        this._product_stock = i3;
    }

    public ProductClass(String str, int i, int i2, String str2, int i3) {
        this._product_name = str;
        this._product_price = i;
        this._product_count = i2;
        this._order_etc = str2;
        this._gb_code = i3;
    }

    public ProductClass(String str, int i, int i2, String str2) {
        Iterator<ProductClass> it = MainActivity.products.iterator();
        while (it.hasNext()) {
            ProductClass next = it.next();
            if (next._product_code.equals(str)) {
                this._product_name = next._product_name;
                this._gb_code = next._gb_code;
            }
        }
        this._product_code = str;
        this._product_price = i;
        this._product_count = i2;
        this._order_etc = str2;
    }

    public int getGopPrice() {
        if (this._gb_code == 2) {
            return 0;
        }
        return this._product_price;
    }

    public String getProductCode() {
        return this._product_code;
    }

    public int getGB() {
        return this._gb_code;
    }

    public String getETC() {
        return this._order_etc;
    }

    public String getDelivery() {
        return this._order_etc;
    }

    public String getProductName() {
        try {
            return this._product_name.trim();
        } catch (Exception unused) {
            return BuildConfig.FLAVOR;
        }
    }

    public int getProductPrice() {
        return this._product_price;
    }

    public int getProductStock() {
        return this._product_stock;
    }

    public int getProductCount() {
        return this._product_count;
    }

    public void setProductPrice(int i) {
        this._product_price = i;
    }

    public void setProductStock(int i) {
        this._product_stock = i;
    }

    public void setProductCount(int i) {
        this._product_count = i;
    }

    public void setOrderEtc(String str) {
        this._order_etc = str;
    }

    public void setDelivery(String str) {
        this._order_delivery = str;
    }
}
