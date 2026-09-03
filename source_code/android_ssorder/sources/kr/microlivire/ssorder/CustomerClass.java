package kr.microlivire.ssorder;

public class CustomerClass {
    private String _customer_address;
    private String _customer_call;
    private int _customer_code;
    private String _customer_delivery;
    private String _customer_name;
    private String _customer_phone;

    public CustomerClass(int i, String str, String str2, String str3, String str4) {
        this._customer_code = i;
        this._customer_name = str;
        this._customer_call = str2;
        this._customer_phone = str3;
        this._customer_address = str4;
    }

    public int getCustomerCode() {
        return this._customer_code;
    }

    public String getCustomerName() {
        if (this._customer_name.isEmpty()) {
            return "-";
        }
        return this._customer_name;
    }

    public String getCustomerCall() {
        return this._customer_call;
    }

    public String getCustomerPhone() {
        return this._customer_phone;
    }

    public String getCustomerAddress() {
        return this._customer_address;
    }

    public String getCustomerDelivery() {
        return this._customer_delivery;
    }

    public void setCustomerCode(int i) {
        this._customer_code = i;
    }

    public void setCustomerName(String str) {
        this._customer_name = str;
    }

    public void setCustomerCall(String str) {
        this._customer_call = str;
    }

    public void setCustomerPhone(String str) {
        this._customer_phone = str;
    }

    public void setCustomerAddress(String str) {
        this._customer_address = str;
    }

    public void setCustomerDelivery(String str) {
        this._customer_delivery = str;
    }
}
