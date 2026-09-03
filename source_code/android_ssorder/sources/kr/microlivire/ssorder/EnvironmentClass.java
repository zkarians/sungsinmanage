package kr.microlivire.ssorder;

import android.content.Context;
import android.content.SharedPreferences;

public class EnvironmentClass {
    public static final String PREF_INTRO_USER_AGREEMENT = "PREF_USER_AGREEMENT";
    public static final String PREF_MAIN_VALUE = "PREF_MAIN_VALUE";
    static Context mContext;
    private final String PREF_NAME = "ssorder";

    public EnvironmentClass(Context context) {
        mContext = context;
    }

    public void put(String str, String str2) {
        SharedPreferences.Editor edit = mContext.getSharedPreferences("ssorder", 0).edit();
        edit.putString(str, str2);
        edit.commit();
    }

    public void put(String str, boolean z) {
        SharedPreferences.Editor edit = mContext.getSharedPreferences("ssorder", 0).edit();
        edit.putBoolean(str, z);
        edit.commit();
    }

    public void put(String str, int i) {
        SharedPreferences.Editor edit = mContext.getSharedPreferences("ssorder", 0).edit();
        edit.putInt(str, i);
        edit.commit();
    }

    public String getValue(String str, String str2) {
        try {
            return mContext.getSharedPreferences("ssorder", 0).getString(str, str2);
        } catch (Exception unused) {
            return str2;
        }
    }

    public int getValue(String str, int i) {
        try {
            return mContext.getSharedPreferences("ssorder", 0).getInt(str, i);
        } catch (Exception unused) {
            return i;
        }
    }

    public boolean getValue(String str, boolean z) {
        try {
            return mContext.getSharedPreferences("ssorder", 0).getBoolean(str, z);
        } catch (Exception unused) {
            return z;
        }
    }
}
