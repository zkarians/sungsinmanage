package kr.microlivire.ssorder;

import android.content.Context;
import android.os.AsyncTask;
import java.io.UnsupportedEncodingException;
import java.net.URLEncoder;
import java.util.ArrayList;
import java.util.List;

class AsyncTaskClass extends AsyncTask<String, Void, String> {
    String HTML_response = BuildConfig.FLAVOR;
    ArrayList<NameValuePairClass> arguments;
    OnTaskFinished onOurTaskFinished;
    ResponseType responseType;

    public AsyncTaskClass(Context context, OnTaskFinished onTaskFinished, ResponseType responseType2, ArrayList<NameValuePairClass> arrayList) {
        this.onOurTaskFinished = onTaskFinished;
        this.responseType = responseType2;
        this.arguments = arrayList;
    }

    /* access modifiers changed from: protected */
    public void onPreExecute() {
        super.onPreExecute();
    }

    /* access modifiers changed from: protected */
    /* JADX WARNING: Can't wrap try/catch for region: R(6:9|10|11|12|17|18) */
    /* JADX WARNING: Missing exception handler attribute for start block: B:11:0x004d */
    /* Code decompiled incorrectly, please refer to instructions dump. */
    public java.lang.String doInBackground(java.lang.String... r6) {
        /*
            r5 = this;
            kr.microlivire.ssorder.ResponseType r0 = r5.responseType
            kr.microlivire.ssorder.ResponseType r1 = kr.microlivire.ssorder.ResponseType.GET
            r2 = 0
            if (r0 != r1) goto L_0x0064
            java.net.URL r0 = new java.net.URL     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            r6 = r6[r2]     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            r0.<init>(r6)     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            java.net.URLConnection r6 = r0.openConnection()     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            java.io.BufferedReader r0 = new java.io.BufferedReader     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            java.io.InputStreamReader r1 = new java.io.InputStreamReader     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            java.io.InputStream r6 = r6.getInputStream()     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            r1.<init>(r6)     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            r0.<init>(r1)     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
        L_0x0020:
            java.lang.String r6 = r0.readLine()     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            java.lang.String r1 = "\n"
            if (r6 == 0) goto L_0x003f
            java.lang.StringBuilder r3 = new java.lang.StringBuilder     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            r3.<init>()     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            java.lang.String r4 = r5.HTML_response     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            r3.append(r4)     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            r3.append(r6)     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            r3.append(r1)     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            java.lang.String r6 = r3.toString()     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            r5.HTML_response = r6     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            goto L_0x0020
        L_0x003f:
            java.lang.String r6 = r5.HTML_response     // Catch:{ Exception -> 0x004d }
            java.lang.String r3 = r5.HTML_response     // Catch:{ Exception -> 0x004d }
            int r1 = r3.lastIndexOf(r1)     // Catch:{ Exception -> 0x004d }
            java.lang.String r6 = r6.substring(r2, r1)     // Catch:{ Exception -> 0x004d }
            r5.HTML_response = r6     // Catch:{ Exception -> 0x004d }
        L_0x004d:
            r0.close()     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            java.io.PrintStream r6 = java.lang.System.out     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            java.lang.String r0 = "Done"
            r6.println(r0)     // Catch:{ MalformedURLException -> 0x005d, IOException -> 0x0058 }
            goto L_0x0061
        L_0x0058:
            r6 = move-exception
            r6.printStackTrace()
            goto L_0x0061
        L_0x005d:
            r6 = move-exception
            r6.printStackTrace()
        L_0x0061:
            java.lang.String r6 = r5.HTML_response
            return r6
        L_0x0064:
            java.net.URL r0 = new java.net.URL     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r6 = r6[r2]     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r0.<init>(r6)     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            java.net.URLConnection r6 = r0.openConnection()     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            java.net.HttpURLConnection r6 = (java.net.HttpURLConnection) r6     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            java.lang.String r0 = "POST"
            r6.setRequestMethod(r0)     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r0 = 1
            r6.setDoInput(r0)     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r6.setDoOutput(r0)     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            java.io.OutputStream r0 = r6.getOutputStream()     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            java.io.BufferedWriter r1 = new java.io.BufferedWriter     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            java.io.OutputStreamWriter r2 = new java.io.OutputStreamWriter     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            java.lang.String r3 = "UTF-8"
            r2.<init>(r0, r3)     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r1.<init>(r2)     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            java.util.ArrayList<kr.microlivire.ssorder.NameValuePairClass> r2 = r5.arguments     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            java.lang.String r2 = r5.getURLQuery(r2)     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r1.write(r2)     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r1.flush()     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r1.close()     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r0.close()     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r6.connect()     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            java.lang.StringBuilder r0 = new java.lang.StringBuilder     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r0.<init>()     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            int r1 = r6.getResponseCode()     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r2 = 200(0xc8, float:2.8E-43)
            if (r1 != r2) goto L_0x00dc
            java.io.BufferedReader r1 = new java.io.BufferedReader     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            java.io.InputStreamReader r2 = new java.io.InputStreamReader     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            java.io.InputStream r3 = r6.getInputStream()     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r2.<init>(r3)     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r1.<init>(r2)     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
        L_0x00bd:
            java.lang.String r2 = r1.readLine()     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            if (r2 != 0) goto L_0x00c7
            r1.close()     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            goto L_0x00dc
        L_0x00c7:
            java.lang.StringBuilder r3 = new java.lang.StringBuilder     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r3.<init>()     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r3.append(r2)     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r2 = 10
            r3.append(r2)     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            java.lang.String r2 = r3.toString()     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            r0.append(r2)     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            goto L_0x00bd
        L_0x00dc:
            r6.disconnect()     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            java.lang.String r6 = r0.toString()     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            java.lang.String r6 = r6.trim()     // Catch:{ MalformedURLException -> 0x00ed, IOException -> 0x00e8 }
            return r6
        L_0x00e8:
            r6 = move-exception
            r6.printStackTrace()
            goto L_0x00f1
        L_0x00ed:
            r6 = move-exception
            r6.printStackTrace()
        L_0x00f1:
            java.lang.String r6 = "fail"
            return r6
        */
        throw new UnsupportedOperationException("Method not decompiled: kr.microlivire.ssorder.AsyncTaskClass.doInBackground(java.lang.String[]):java.lang.String");
    }

    /* access modifiers changed from: protected */
    public void onPostExecute(String str) {
        this.onOurTaskFinished.onFeedRetrieved(str);
    }

    private String getURLQuery(List<NameValuePairClass> list) {
        StringBuilder sb = new StringBuilder();
        boolean z = true;
        for (NameValuePairClass next : list) {
            if (z) {
                z = false;
            } else {
                sb.append("&");
            }
            try {
                sb.append(URLEncoder.encode(next.getName(), "UTF-8"));
                sb.append("=");
                sb.append(URLEncoder.encode(next.getValue(), "UTF-8"));
            } catch (UnsupportedEncodingException e) {
                e.printStackTrace();
            }
        }
        return sb.toString();
    }
}
