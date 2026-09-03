package kr.microlivire.ssorder;

import android.content.Context;
import android.content.pm.PackageManager;
import android.util.Log;
import java.util.ArrayList;

public class Module {
    private static Module instance;
    ArrayList<NameValuePairClass> account = new ArrayList<>();
    int account_code;
    String account_name = BuildConfig.FLAVOR;
    int acgb_code;
    public String server;
    int team_code;

    public String getAccountGBString() {
        int i = this.acgb_code;
        if (i == 1) {
            return "관리자";
        }
        if (i != 2) {
            return i != 3 ? "없음" : "최고관리자";
        }
        return "일반";
    }

    public String getTeamString() {
        int i = this.team_code;
        if (i != 1) {
            return i != 2 ? "없음" : "TM";
        }
        return "직판";
    }

    public String[] RemoveEmptyEntity(String[] strArr) {
        ArrayList arrayList = new ArrayList();
        for (int i = 0; i < strArr.length; i++) {
            if (!strArr[i].equals(BuildConfig.FLAVOR) && strArr[i] != null) {
                arrayList.add(strArr[i]);
            }
        }
        String[] strArr2 = new String[arrayList.size()];
        for (int i2 = 0; i2 < arrayList.size(); i2++) {
            strArr2[i2] = (String) arrayList.get(i2);
        }
        return strArr2;
    }

    public static synchronized Module getInstance() {
        Module module;
        synchronized (Module.class) {
            if (instance == null) {
                instance = new Module();
            }
            module = instance;
        }
        return module;
    }

    public String getApplicationVersion(Context context) {
        try {
            return context.getPackageManager().getPackageInfo(context.getPackageName(), 0).versionName;
        } catch (PackageManager.NameNotFoundException e) {
            Log.e("tag", e.getMessage());
            return BuildConfig.FLAVOR;
        }
    }
}
