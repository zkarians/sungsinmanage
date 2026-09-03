package kr.microlivire.ssorder;

public class AddressClass {
    public String _address_dong;
    public String _address_post;
    public String _address_road;

    public AddressClass(String str, String str2, String str3) {
        this._address_post = str;
        this._address_road = str2;
        this._address_dong = str3;
    }
}
