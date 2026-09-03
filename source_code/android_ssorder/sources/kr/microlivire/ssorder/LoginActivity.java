package kr.microlivire.ssorder;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.annotation.TargetApi;
import android.app.LoaderManager;
import android.content.CursorLoader;
import android.content.Intent;
import android.content.Loader;
import android.database.Cursor;
import android.net.Uri;
import android.os.AsyncTask;
import android.os.Build;
import android.os.Bundle;
import android.provider.ContactsContract;
import android.support.annotation.NonNull;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewPropertyAnimator;
import android.view.animation.AnimationUtils;
import android.view.inputmethod.InputMethodManager;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;
import java.util.ArrayList;
import java.util.List;

public class LoginActivity extends AppCompatActivity implements LoaderManager.LoaderCallbacks<Cursor> {
    /* access modifiers changed from: private */
    public static final String[] DUMMY_CREDENTIALS = {"foo@example.com:hello", "bar@example.com:world"};
    private static final int REQUEST_READ_CONTACTS = 0;
    boolean autoLogin = false;
    EnvironmentClass environmentClass;
    Intent intent;
    /* access modifiers changed from: private */
    public UserLoginTask mAuthTask = null;
    Button mEmailSignInButton;
    /* access modifiers changed from: private */
    public AutoCompleteTextView mIDView;
    /* access modifiers changed from: private */
    public View mLoginFormView;
    /* access modifiers changed from: private */
    public EditText mPasswordView;
    /* access modifiers changed from: private */
    public View mProgressView;
    boolean serverChangeFlag = false;
    int serverChangeFlagCount = 0;
    private Spinner spinner1;

    private interface ProfileQuery {
        public static final int ADDRESS = 0;
        public static final int IS_PRIMARY = 1;
        public static final String[] PROJECTION = {"data1", "is_primary"};
    }

    public void onLoaderReset(Loader<Cursor> loader) {
    }

    /* access modifiers changed from: protected */
    public void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        setContentView((int) R.layout.activity_login);
        this.mIDView = (AutoCompleteTextView) findViewById(R.id.id);
        this.environmentClass = new EnvironmentClass(getApplicationContext());
        this.autoLogin = this.environmentClass.getValue("auto-login", false);
        Module.getInstance().server = this.environmentClass.getValue("server-url", "https://maizen.org/tmserver/");
        ((TextView) findViewById(R.id.tv_appversion)).setText("v" + Module.getInstance().getApplicationVersion(getApplicationContext()));
        this.mPasswordView = (EditText) findViewById(R.id.password);
        if (this.autoLogin) {
            ((CheckBox) findViewById(R.id.checkBox)).setChecked(this.autoLogin);
            this.mIDView.setText(this.environmentClass.getValue("ssbio-id", BuildConfig.FLAVOR));
            this.mPasswordView.setText(this.environmentClass.getValue("ssbio-pw", BuildConfig.FLAVOR));
            login();
        }
        ((CheckBox) findViewById(R.id.checkBox)).setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            public void onCheckedChanged(CompoundButton compoundButton, boolean z) {
                if (!z) {
                    LoginActivity.this.environmentClass.put("auto-login", false);
                    LoginActivity.this.environmentClass.put("ssbio-id", BuildConfig.FLAVOR);
                    LoginActivity.this.environmentClass.put("ssbio-pw", BuildConfig.FLAVOR);
                }
            }
        });
        findViewById(R.id.email_sign_in_button).setOnClickListener(new View.OnClickListener() {
            public void onClick(View view) {
                LoginActivity.this.login();
            }
        });
        getSupportActionBar().hide();
        findViewById(R.id.imageView).setOnClickListener(new View.OnClickListener() {
            public void onClick(View view) {
                if (!LoginActivity.this.serverChangeFlag) {
                    if (LoginActivity.this.serverChangeFlagCount < 4) {
                        LoginActivity.this.serverChangeFlagCount++;
                        return;
                    }
                    LoginActivity loginActivity = LoginActivity.this;
                    loginActivity.serverChangeFlag = true;
                    ((TextView) loginActivity.findViewById(R.id.server_url)).setText(Module.getInstance().server);
                    LoginActivity.this.findViewById(R.id.email_login_form).startAnimation(AnimationUtils.loadAnimation(LoginActivity.this.getApplicationContext(), R.anim.fadeout));
                    LoginActivity.this.findViewById(R.id.email_login_form).setVisibility(4);
                    LoginActivity.this.findViewById(R.id.email_login_form).post(new Runnable() {
                        public void run() {
                            LoginActivity.this.findViewById(R.id.server_panel).startAnimation(AnimationUtils.loadAnimation(LoginActivity.this.getApplicationContext(), R.anim.fadein));
                            LoginActivity.this.findViewById(R.id.server_panel).setVisibility(0);
                        }
                    });
                }
            }
        });
        findViewById(R.id.set_server).setOnClickListener(new View.OnClickListener() {
            public void onClick(View view) {
                if (LoginActivity.this.serverChangeFlag) {
                    LoginActivity loginActivity = LoginActivity.this;
                    loginActivity.serverChangeFlag = false;
                    loginActivity.serverChangeFlagCount = 0;
                    Module.getInstance().server = ((TextView) LoginActivity.this.findViewById(R.id.server_url)).getText().toString().trim();
                    LoginActivity.this.environmentClass.put("server-url", Module.getInstance().server);
                    LoginActivity.this.findViewById(R.id.server_panel).startAnimation(AnimationUtils.loadAnimation(LoginActivity.this.getApplicationContext(), R.anim.fadeout));
                    LoginActivity.this.findViewById(R.id.server_panel).setVisibility(4);
                    LoginActivity.this.findViewById(R.id.email_login_form).post(new Runnable() {
                        public void run() {
                            LoginActivity.this.findViewById(R.id.email_login_form).startAnimation(AnimationUtils.loadAnimation(LoginActivity.this.getApplicationContext(), R.anim.fadein));
                            LoginActivity.this.findViewById(R.id.email_login_form).setVisibility(0);
                        }
                    });
                }
            }
        });
    }

    /* access modifiers changed from: package-private */
    public void login() {
        this.mIDView.setError((CharSequence) null);
        this.mPasswordView.setError((CharSequence) null);
        if (TextUtils.isEmpty(this.mIDView.getText().toString())) {
            this.mIDView.setError("아이디가 입력되지 않았습니다.");
            this.mIDView.requestFocus();
        } else if (TextUtils.isEmpty(this.mPasswordView.getText().toString())) {
            this.mPasswordView.setError("비밀번호가 입력되지 않았습니다.");
            this.mPasswordView.requestFocus();
        } else {
            findViewById(R.id.progressBar2).setVisibility(0);
            ((InputMethodManager) getSystemService("input_method")).hideSoftInputFromWindow(this.mIDView.getWindowToken(), 0);
            Module.getInstance().account.clear();
            Module.getInstance().account.add(new NameValuePairClass("id", this.mIDView.getText().toString().trim()));
            Module.getInstance().account.add(new NameValuePairClass("pw", this.mPasswordView.getText().toString().trim()));
            Module.getInstance().account.add(new NameValuePairClass("adv", Module.getInstance().getApplicationVersion(getApplicationContext()).replace(".", BuildConfig.FLAVOR)));
            AsyncTaskClass asyncTaskClass = new AsyncTaskClass(getApplicationContext(), new OnTaskFinished() {
                public void onFeedRetrieved(String str) {
                    if (str.equals("fail")) {
                        LoginActivity loginActivity = LoginActivity.this;
                        loginActivity.autoLogin = false;
                        loginActivity.mIDView.setError("아이디 또는 비밀번호가 일치하지 않습니다.");
                        LoginActivity.this.mIDView.requestFocus();
                    } else {
                        try {
                            String[] RemoveEmptyEntity = Module.getInstance().RemoveEmptyEntity(str.split("<next>"));
                            Module.getInstance().acgb_code = Integer.valueOf(RemoveEmptyEntity[0]).intValue();
                            Module.getInstance().team_code = Integer.valueOf(RemoveEmptyEntity[2]).intValue();
                            Module.getInstance().account_name = RemoveEmptyEntity[4];
                            Module.getInstance().account_code = Integer.valueOf(RemoveEmptyEntity[6]).intValue();
                            Module.getInstance().account.add(new NameValuePairClass("tc", String.valueOf(99)));
                            Module.getInstance().account.add(new NameValuePairClass("acc_code", RemoveEmptyEntity[6]));
                            if (((CheckBox) LoginActivity.this.findViewById(R.id.checkBox)).isChecked() && !LoginActivity.this.autoLogin) {
                                LoginActivity.this.environmentClass.put("auto-login", true);
                                LoginActivity.this.environmentClass.put("ssbio-id", LoginActivity.this.mIDView.getText().toString());
                                LoginActivity.this.environmentClass.put("ssbio-pw", LoginActivity.this.mPasswordView.getText().toString());
                            }
                            LoginActivity.this.intent = new Intent(LoginActivity.this.getApplicationContext(), MainActivity.class);
                            LoginActivity.this.startActivity(LoginActivity.this.intent);
                            LoginActivity.this.overridePendingTransition(R.anim.fadein, R.anim.fadeout);
                            LoginActivity.this.finish();
                        } catch (Exception unused) {
                            LoginActivity loginActivity2 = LoginActivity.this;
                            loginActivity2.autoLogin = false;
                            Toast.makeText(loginActivity2.getApplicationContext(), "서버정보 수신 중에 알 수 없는 오류가 발생했습니다.\n다시 시도 해 주십시오.", 1).show();
                        }
                    }
                    LoginActivity.this.findViewById(R.id.progressBar2).setVisibility(4);
                }
            }, ResponseType.POST, Module.getInstance().account);
            asyncTaskClass.execute(new String[]{Module.getInstance().server + "login.php"});
        }
    }

    private void populateAutoComplete() {
        if (mayRequestContacts()) {
            getLoaderManager().initLoader(0, (Bundle) null, this);
        }
    }

    private boolean mayRequestContacts() {
        if (Build.VERSION.SDK_INT < 23 || checkSelfPermission("android.permission.READ_CONTACTS") == 0) {
            return true;
        }
        if (shouldShowRequestPermissionRationale("android.permission.READ_CONTACTS")) {
            Snackbar.make((View) this.mIDView, (int) R.string.permission_rationale, -2).setAction(17039370, (View.OnClickListener) new View.OnClickListener() {
                @TargetApi(23)
                public void onClick(View view) {
                    LoginActivity.this.requestPermissions(new String[]{"android.permission.READ_CONTACTS"}, 0);
                }
            });
        } else {
            requestPermissions(new String[]{"android.permission.READ_CONTACTS"}, 0);
        }
        return false;
    }

    public void onRequestPermissionsResult(int i, @NonNull String[] strArr, @NonNull int[] iArr) {
        if (i == 0 && iArr.length == 1 && iArr[0] == 0) {
            populateAutoComplete();
        }
    }

    private void attemptLogin() {
        EditText editText;
        boolean z;
        if (this.mAuthTask == null) {
            this.mIDView.setError((CharSequence) null);
            this.mPasswordView.setError((CharSequence) null);
            String obj = this.mIDView.getText().toString();
            String obj2 = this.mPasswordView.getText().toString();
            if (TextUtils.isEmpty(obj2) || isPasswordValid(obj2)) {
                editText = null;
                z = false;
            } else {
                this.mPasswordView.setError(getString(R.string.error_invalid_password));
                editText = this.mPasswordView;
                z = true;
            }
            if (z) {
                editText.requestFocus();
                return;
            }
            showProgress(true);
            this.mAuthTask = new UserLoginTask(obj, obj2);
            this.mAuthTask.execute(new Void[]{null});
        }
    }

    private boolean isEmailValid(String str) {
        return str.contains("@");
    }

    private boolean isPasswordValid(String str) {
        return str.length() > 4;
    }

    /* access modifiers changed from: private */
    @TargetApi(13)
    public void showProgress(final boolean z) {
        int i = 0;
        if (Build.VERSION.SDK_INT >= 13) {
            int integer = getResources().getInteger(17694720);
            this.mLoginFormView.setVisibility(z ? 8 : 0);
            long j = (long) integer;
            float f = 0.0f;
            this.mLoginFormView.animate().setDuration(j).alpha(z ? 0.0f : 1.0f).setListener(new AnimatorListenerAdapter() {
                public void onAnimationEnd(Animator animator) {
                    LoginActivity.this.mLoginFormView.setVisibility(z ? 8 : 0);
                }
            });
            View view = this.mProgressView;
            if (!z) {
                i = 8;
            }
            view.setVisibility(i);
            ViewPropertyAnimator duration = this.mProgressView.animate().setDuration(j);
            if (z) {
                f = 1.0f;
            }
            duration.alpha(f).setListener(new AnimatorListenerAdapter() {
                public void onAnimationEnd(Animator animator) {
                    LoginActivity.this.mProgressView.setVisibility(z ? 0 : 8);
                }
            });
            return;
        }
        this.mProgressView.setVisibility(z ? 0 : 8);
        View view2 = this.mLoginFormView;
        if (z) {
            i = 8;
        }
        view2.setVisibility(i);
    }

    public Loader<Cursor> onCreateLoader(int i, Bundle bundle) {
        return new CursorLoader(this, Uri.withAppendedPath(ContactsContract.Profile.CONTENT_URI, "data"), ProfileQuery.PROJECTION, "mimetype = ?", new String[]{"vnd.android.cursor.item/email_v2"}, "is_primary DESC");
    }

    public void onLoadFinished(Loader<Cursor> loader, Cursor cursor) {
        ArrayList arrayList = new ArrayList();
        cursor.moveToFirst();
        while (!cursor.isAfterLast()) {
            arrayList.add(cursor.getString(0));
            cursor.moveToNext();
        }
        addEmailsToAutoComplete(arrayList);
    }

    private void addEmailsToAutoComplete(List<String> list) {
        this.mIDView.setAdapter(new ArrayAdapter(this, 17367050, list));
    }

    public class UserLoginTask extends AsyncTask<Void, Void, Boolean> {
        private final String mEmail;
        private final String mPassword;

        UserLoginTask(String str, String str2) {
            this.mEmail = str;
            this.mPassword = str2;
        }

        /* access modifiers changed from: protected */
        public Boolean doInBackground(Void... voidArr) {
            try {
                Thread.sleep(2000);
                for (String split : LoginActivity.DUMMY_CREDENTIALS) {
                    String[] split2 = split.split(":");
                    if (split2[0].equals(this.mEmail)) {
                        return Boolean.valueOf(split2[1].equals(this.mPassword));
                    }
                }
                return true;
            } catch (InterruptedException unused) {
                return false;
            }
        }

        /* access modifiers changed from: protected */
        public void onPostExecute(Boolean bool) {
            UserLoginTask unused = LoginActivity.this.mAuthTask = null;
            LoginActivity.this.showProgress(false);
            if (bool.booleanValue()) {
                LoginActivity.this.finish();
                return;
            }
            LoginActivity.this.mPasswordView.setError(LoginActivity.this.getString(R.string.error_incorrect_password));
            LoginActivity.this.mPasswordView.requestFocus();
        }

        /* access modifiers changed from: protected */
        public void onCancelled() {
            UserLoginTask unused = LoginActivity.this.mAuthTask = null;
            LoginActivity.this.showProgress(false);
        }
    }
}
