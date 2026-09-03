package kr.microlivire.ssorder;

public class NameValuePairClass {
    String _key;
    String _value;

    public NameValuePairClass(String str, String str2) {
        this._key = str;
        this._value = str2;
    }

    public String getName() {
        return this._key;
    }

    public String getValue() {
        return this._value;
    }
}
