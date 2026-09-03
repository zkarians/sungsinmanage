package kr.microlivire.ssorder;

import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.graphics.PorterDuff;
import android.os.Bundle;
import android.os.Process;
import android.support.annotation.NonNull;
import android.support.design.widget.BottomNavigationView;
import android.support.v4.internal.view.SupportMenu;
import android.support.v7.app.AppCompatActivity;
import android.telephony.PhoneNumberFormattingTextWatcher;
import android.text.Editable;
import android.text.Html;
import android.text.TextWatcher;
import android.util.DisplayMetrics;
import android.view.KeyEvent;
import android.view.LayoutInflater;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.AnimationUtils;
import android.view.inputmethod.InputMethodManager;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.RadioButton;
import android.widget.RelativeLayout;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.ViewFlipper;
import java.io.IOException;
import java.io.StringReader;
import java.io.UnsupportedEncodingException;
import java.net.URLEncoder;
import java.text.NumberFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.GregorianCalendar;
import java.util.Iterator;
import java.util.Locale;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;
import org.xmlpull.v1.XmlPullParser;
import org.xmlpull.v1.XmlPullParserException;
import org.xmlpull.v1.XmlPullParserFactory;

public class MainActivity extends AppCompatActivity {
    public static ArrayList<ProductClass> products = new ArrayList<>();
    AddedProductAdapter addedAdapter;
    ListView addedProductListView;
    /* access modifiers changed from: private */
    public ArrayList<ProductClass> addedProducts;
    AddressAdapter addressAdapter;
    ListView addressListView;
    boolean addressSearchMode = false;
    /* access modifiers changed from: private */
    public ArrayList<AddressClass> addresses = new ArrayList<>();
    private long backKeyPressedTime = 0;
    private View.OnClickListener clickListener = new View.OnClickListener() {
        public void onClick(View view) {
            int id = view.getId();
            String str = BuildConfig.FLAVOR;
            switch (id) {
                case R.id.btn_addProduct:
                    MainActivity.this.mainViewFlipper.setInAnimation(AnimationUtils.loadAnimation(MainActivity.this.getApplicationContext(), R.anim.slide_in_right));
                    MainActivity.this.mainViewFlipper.setOutAnimation(AnimationUtils.loadAnimation(MainActivity.this.getApplicationContext(), R.anim.slide_out_left));
                    ((TextView) MainActivity.this.findViewById(R.id.productListSearch)).setText(str);
                    MainActivity.this.mainViewFlipper.setDisplayedChild(1);
                    MainActivity.this.productListView.setVisibility(4);
                    MainActivity mainActivity = MainActivity.this;
                    mainActivity.pageNumber = 1;
                    mainActivity.findViewById(R.id.progressBar).setVisibility(0);
                    MainActivity.this.findViewById(R.id.tv_order_nocontent).setVisibility(4);
                    int i = Module.getInstance().team_code;
                    new AsyncTaskClass(MainActivity.this.getApplicationContext(), new OnTaskFinished() {
                        public void onFeedRetrieved(String str) {
                            MainActivity.products = new ArrayList<>();
                            for (String split : Module.getInstance().RemoveEmptyEntity(str.split("<split>"))) {
                                String[] RemoveEmptyEntity = Module.getInstance().RemoveEmptyEntity(split.split("<next>"));
                                MainActivity.products.add(new ProductClass(RemoveEmptyEntity[0], Integer.valueOf(RemoveEmptyEntity[2]).intValue(), RemoveEmptyEntity[3], Integer.valueOf(RemoveEmptyEntity[4]).intValue(), Integer.valueOf(RemoveEmptyEntity[5]).intValue()));
                            }
                            MainActivity.this.m_adapter = new ResultAdapter(MainActivity.this.getApplicationContext(), MainActivity.products, MainActivity.this.metrics);
                            MainActivity.this.productListView.setAdapter(MainActivity.this.m_adapter);
                            MainActivity.this.productListView.setVisibility(0);
                            MainActivity.this.findViewById(R.id.progressBar).setVisibility(4);
                        }
                    }, ResponseType.POST, Module.getInstance().account).execute(new String[]{Module.getInstance().server + "admin.php?t=getProduct&pt=" + String.valueOf(Module.getInstance().team_code)});
                    return;
                case R.id.btn_addressSearch:
                    MainActivity.this.mainViewFlipper.setInAnimation(AnimationUtils.loadAnimation(MainActivity.this.getApplicationContext(), R.anim.slide_in_right));
                    MainActivity.this.mainViewFlipper.setOutAnimation(AnimationUtils.loadAnimation(MainActivity.this.getApplicationContext(), R.anim.slide_out_left));
                    MainActivity.this.searchAddress();
                    return;
                case R.id.btn_addressSearchBtn:
                    MainActivity.this.mainViewFlipper.setInAnimation(AnimationUtils.loadAnimation(MainActivity.this.getApplicationContext(), R.anim.slide_in_right));
                    MainActivity.this.mainViewFlipper.setOutAnimation(AnimationUtils.loadAnimation(MainActivity.this.getApplicationContext(), R.anim.slide_out_left));
                    MainActivity.this.findViewById(R.id.progressBar).setVisibility(4);
                    MainActivity.this.addressListView.setVisibility(4);
                    MainActivity.this.findViewById(R.id.tv_address_noitem).setVisibility(4);
                    ((EditText) MainActivity.this.findViewById(R.id.et_addressSearch)).setText(str);
                    MainActivity mainActivity2 = MainActivity.this;
                    mainActivity2.pageNumber = 1;
                    mainActivity2.addressSearchMode = true;
                    mainActivity2.mainViewFlipper.setDisplayedChild(5);
                    MainActivity.this.findViewById(R.id.et_addressSearch).requestFocus();
                    ((InputMethodManager) MainActivity.this.getSystemService("input_method")).showSoftInput(MainActivity.this.findViewById(R.id.et_addressSearch), 0);
                    return;
                case R.id.btn_cusSearch:
                    MainActivity mainActivity3 = MainActivity.this;
                    mainActivity3.pageNumber = 1;
                    mainActivity3.mainViewFlipper.setInAnimation(AnimationUtils.loadAnimation(MainActivity.this.getApplicationContext(), R.anim.slide_in_right));
                    MainActivity.this.mainViewFlipper.setOutAnimation(AnimationUtils.loadAnimation(MainActivity.this.getApplicationContext(), R.anim.slide_out_left));
                    MainActivity.this.mainViewFlipper.setDisplayedChild(2);
                    MainActivity.this.findViewById(R.id.et_customerSearch).requestFocus();
                    if (!((TextView) MainActivity.this.findViewById(R.id.et_order_name)).getText().toString().trim().isEmpty()) {
                        ((TextView) MainActivity.this.findViewById(R.id.et_customerSearch)).setText(((TextView) MainActivity.this.findViewById(R.id.et_order_name)).getText().toString().trim());
                        MainActivity.this.customerSearch();
                        return;
                    }
                    ((InputMethodManager) MainActivity.this.getSystemService("input_method")).showSoftInput(MainActivity.this.findViewById(R.id.et_customerSearch), 0);
                    return;
                case R.id.btn_customerSearch:
                    MainActivity.this.mainViewFlipper.setInAnimation(AnimationUtils.loadAnimation(MainActivity.this.getApplicationContext(), R.anim.slide_in_right));
                    MainActivity.this.mainViewFlipper.setOutAnimation(AnimationUtils.loadAnimation(MainActivity.this.getApplicationContext(), R.anim.slide_out_left));
                    MainActivity.this.customerSearch();
                    return;
                case R.id.btn_deliverySearchBtn:
                    MainActivity.this.mainViewFlipper.setInAnimation(AnimationUtils.loadAnimation(MainActivity.this.getApplicationContext(), R.anim.slide_in_right));
                    MainActivity.this.mainViewFlipper.setOutAnimation(AnimationUtils.loadAnimation(MainActivity.this.getApplicationContext(), R.anim.slide_out_left));
                    MainActivity.this.findViewById(R.id.progressBar).setVisibility(4);
                    MainActivity.this.addressListView.setVisibility(4);
                    MainActivity.this.findViewById(R.id.tv_address_noitem).setVisibility(4);
                    ((EditText) MainActivity.this.findViewById(R.id.et_addressSearch)).setText(str);
                    MainActivity mainActivity4 = MainActivity.this;
                    mainActivity4.pageNumber = 1;
                    mainActivity4.addressSearchMode = false;
                    mainActivity4.mainViewFlipper.setDisplayedChild(5);
                    MainActivity.this.findViewById(R.id.et_addressSearch).requestFocus();
                    ((InputMethodManager) MainActivity.this.getSystemService("input_method")).showSoftInput(MainActivity.this.findViewById(R.id.et_addressSearch), 0);
                    return;
                case R.id.btn_main_getorder:
                    MainActivity mainActivity5 = MainActivity.this;
                    mainActivity5.pageNumber = 0;
                    mainActivity5.getOrderBtn();
                    return;
                case R.id.btn_main_logout:
                    int i2 = MainActivity.this.page;
                    if (i2 == 0) {
                        EnvironmentClass environmentClass = new EnvironmentClass(MainActivity.this.getApplicationContext());
                        environmentClass.put("auto-login", false);
                        environmentClass.put("ssbio-id", str);
                        environmentClass.put("ssbio-pw", str);
                        MainActivity mainActivity6 = MainActivity.this;
                        mainActivity6.intent = new Intent(mainActivity6.getApplicationContext(), LoginActivity.class);
                        MainActivity mainActivity7 = MainActivity.this;
                        mainActivity7.startActivity(mainActivity7.intent);
                        MainActivity.this.overridePendingTransition(R.anim.fadein, R.anim.fadeout);
                        MainActivity.this.finish();
                        return;
                    } else if (i2 == 1) {
                        MainActivity.this.findViewById(R.id.btn_order).performClick();
                        return;
                    } else {
                        return;
                    }
                case R.id.btn_main_order:
                    MainActivity mainActivity8 = MainActivity.this;
                    mainActivity8.pageNumber = 0;
                    mainActivity8.orderBtn();
                    return;
                case R.id.btn_order:
                    if (((TextView) MainActivity.this.findViewById(R.id.et_order_name)).getText().toString().trim().isEmpty()) {
                        MainActivity.this.findViewById(R.id.et_order_name).requestFocus();
                        Toast.makeText(MainActivity.this.getApplicationContext(), "고객명이 입력되지 않았습니다.", 0).show();
                        return;
                    } else if (((TextView) MainActivity.this.findViewById(R.id.et_order_call)).getText().toString().trim().isEmpty() && !((CheckBox) MainActivity.this.findViewById(R.id.checkBox4)).isChecked()) {
                        MainActivity.this.findViewById(R.id.et_order_call).requestFocus();
                        Toast.makeText(MainActivity.this.getApplicationContext(), "자택 전화번호가 입력되지 않았습니다.", 0).show();
                        return;
                    } else if (((TextView) MainActivity.this.findViewById(R.id.et_order_phone)).getText().toString().trim().isEmpty() && !((CheckBox) MainActivity.this.findViewById(R.id.checkBox3)).isChecked()) {
                        MainActivity.this.findViewById(R.id.et_order_phone).requestFocus();
                        Toast.makeText(MainActivity.this.getApplicationContext(), "휴대전화가 입력되지 않았습니다.", 0).show();
                        return;
                    } else if (((TextView) MainActivity.this.findViewById(R.id.et_order_address)).getText().toString().trim().isEmpty()) {
                        MainActivity.this.findViewById(R.id.et_order_address).requestFocus();
                        Toast.makeText(MainActivity.this.getApplicationContext(), "자택 및 직장주소가 입력되지 않았습니다.", 0).show();
                        return;
                    } else if (((TextView) MainActivity.this.findViewById(R.id.et_order_delivery)).getText().toString().trim().isEmpty()) {
                        MainActivity.this.findViewById(R.id.et_order_delivery).requestFocus();
                        Toast.makeText(MainActivity.this.getApplicationContext(), "상품 배송지가 입력되지 않았습니다.", 0).show();
                        return;
                    } else if (MainActivity.this.addedProducts.size() <= 0) {
                        MainActivity.this.addedProductListView.requestFocus();
                        Toast.makeText(MainActivity.this.getApplicationContext(), "제품을 한 개 이상 추가 하십시오.", 0).show();
                        return;
                    } else {
                        MainActivity.this.mainViewFlipper.setDisplayedChild(7);
                        MainActivity.this.dataSave();
                        Iterator it = MainActivity.this.addedProducts.iterator();
                        String str2 = str;
                        while (it.hasNext()) {
                            ProductClass productClass = (ProductClass) it.next();
                            str2 = str2 + "<product>" + productClass.getProductCode() + "<br>" + productClass.getProductPrice() + "<br>" + productClass.getProductCount() + "<br>" + productClass.getETC();
                        }
                        ArrayList arrayList = new ArrayList();
                        arrayList.addAll(Module.getInstance().account);
                        arrayList.add(new NameValuePairClass("pc", str2));
                        try {
                            AsyncTaskClass asyncTaskClass = new AsyncTaskClass(MainActivity.this.getApplicationContext(), new OnTaskFinished() {
                                public void onFeedRetrieved(String str) {
                                    if (!str.equals("ok")) {
                                        Toast.makeText(MainActivity.this.getApplicationContext(), str, 1).show();
                                        MainActivity.this.mainViewFlipper.setDisplayedChild(0);
                                        return;
                                    }
                                    MainActivity.this.mainViewFlipper.setDisplayedChild(6);
                                    MainActivity.this.OrderReset();
                                }
                            }, ResponseType.POST, arrayList);
                            String[] strArr = new String[1];
                            StringBuilder sb = new StringBuilder();
                            sb.append(Module.getInstance().server);
                            sb.append("admin.php?t=setOrder&ac=");
                            sb.append(String.valueOf(Module.getInstance().account_code));
                            sb.append("&cc=");
                            if (MainActivity.this.selectedCustomer != null) {
                                str = String.valueOf(MainActivity.this.selectedCustomer.getCustomerCode());
                            }
                            sb.append(str);
                            sb.append("&ca=");
                            sb.append(URLEncoder.encode(((EditText) MainActivity.this.findViewById(R.id.et_order_address)).getText().toString() + "<other>" + ((EditText) MainActivity.this.findViewById(R.id.et_order_address_more)).getText().toString(), "UTF-8"));
                            sb.append("&call=");
                            sb.append(URLEncoder.encode(((EditText) MainActivity.this.findViewById(R.id.et_order_call)).getText().toString(), "UTF-8"));
                            sb.append("&od=");
                            sb.append(URLEncoder.encode(((EditText) MainActivity.this.findViewById(R.id.et_order_delivery)).getText().toString() + "<other>" + ((EditText) MainActivity.this.findViewById(R.id.et_order_delivery_more)).getText().toString(), "UTF-8"));
                            sb.append("&cp=");
                            sb.append(URLEncoder.encode(((EditText) MainActivity.this.findViewById(R.id.et_order_phone)).getText().toString(), "UTF-8"));
                            sb.append("&cn=");
                            sb.append(URLEncoder.encode(((EditText) MainActivity.this.findViewById(R.id.et_order_name)).getText().toString(), "UTF-8"));
                            sb.append("&oe=");
                            sb.append(URLEncoder.encode(((EditText) MainActivity.this.findViewById(R.id.et_etc)).getText().toString()));
                            strArr[0] = sb.toString();
                            asyncTaskClass.execute(strArr);
                            return;
                        } catch (UnsupportedEncodingException e) {
                            e.printStackTrace();
                            return;
                        }
                    }
                case R.id.btn_reset:
                    new AlertDialog.Builder(MainActivity.this).setOnCancelListener(new DialogInterface.OnCancelListener() {
                        public void onCancel(DialogInterface dialogInterface) {
                        }
                    }).setNegativeButton("취소", new DialogInterface.OnClickListener() {
                        public void onClick(DialogInterface dialogInterface, int i) {
                        }
                    }).setPositiveButton(Html.fromHtml("<font color=red>주문 초기화"), new DialogInterface.OnClickListener() {
                        public void onClick(DialogInterface dialogInterface, int i) {
                            MainActivity.this.OrderReset();
                        }
                    }).setMessage("현재 주문을 초기화 하시겠습니까?").show();
                    return;
                case R.id.btn_result_home:
                    MainActivity.this.mainViewFlipper.setInAnimation(AnimationUtils.loadAnimation(MainActivity.this.getApplicationContext(), R.anim.fadein));
                    MainActivity.this.mainViewFlipper.setOutAnimation(AnimationUtils.loadAnimation(MainActivity.this.getApplicationContext(), R.anim.fadeout));
                    MainActivity.this.title.setText("성신 판매접수 - 홈");
                    MainActivity.this.findViewById(R.id.btn_main_logout).setVisibility(0);
                    ((TextView) MainActivity.this.findViewById(R.id.btn_main_logout)).setBackgroundResource(R.drawable.corner_cell_red);
                    ((TextView) MainActivity.this.findViewById(R.id.btn_main_logout)).setTextColor(MainActivity.this.getResources().getColor(R.color.white));
                    ((TextView) MainActivity.this.findViewById(R.id.btn_main_logout)).setText("로그아웃");
                    MainActivity mainActivity9 = MainActivity.this;
                    mainActivity9.page = 0;
                    mainActivity9.pageNumber = 0;
                    mainActivity9.mainViewFlipper.setDisplayedChild(4);
                    MainActivity.this.navigation.getMenu().getItem(0).setChecked(true);
                    return;
                default:
                    return;
            }
        }
    };
    CustomerAdapter customerAdapter;
    ListView customerListView;
    /* access modifiers changed from: private */
    public ArrayList<CustomerClass> customers = new ArrayList<>();
    Intent intent;
    private BottomNavigationView.OnNavigationItemSelectedListener mOnNavigationItemSelectedListener = new BottomNavigationView.OnNavigationItemSelectedListener() {
        public boolean onNavigationItemSelected(@NonNull MenuItem menuItem) {
            MainActivity.this.findViewById(R.id.progressBar).setVisibility(4);
            switch (menuItem.getItemId()) {
                case R.id.navigation_dashboard:
                    MainActivity.this.orderBtn();
                    return true;
                case R.id.navigation_home:
                    MainActivity mainActivity = MainActivity.this;
                    mainActivity.pageNumber = 0;
                    mainActivity.page = 0;
                    mainActivity.mainViewFlipper.setInAnimation(AnimationUtils.loadAnimation(MainActivity.this.getApplicationContext(), R.anim.fadein));
                    MainActivity.this.mainViewFlipper.setOutAnimation(AnimationUtils.loadAnimation(MainActivity.this.getApplicationContext(), R.anim.fadeout));
                    MainActivity.this.title.setText("성신 판매접수 - 홈");
                    MainActivity.this.findViewById(R.id.btn_main_logout).setVisibility(0);
                    ((TextView) MainActivity.this.findViewById(R.id.btn_main_logout)).setBackgroundResource(R.drawable.corner_cell_red);
                    ((TextView) MainActivity.this.findViewById(R.id.btn_main_logout)).setTextColor(MainActivity.this.getResources().getColor(R.color.white));
                    ((TextView) MainActivity.this.findViewById(R.id.btn_main_logout)).setText("로그아웃");
                    MainActivity.this.mainViewFlipper.setDisplayedChild(4);
                    return true;
                case R.id.navigation_notifications:
                    MainActivity.this.getOrderBtn();
                    return true;
                default:
                    return false;
            }
        }
    };
    ResultAdapter m_adapter;
    ViewFlipper mainViewFlipper;
    /* access modifiers changed from: private */
    public DisplayMetrics metrics;
    BottomNavigationView navigation;
    OrderAdapter orderAdapter;
    ListView orderListView;
    /* access modifiers changed from: private */
    public ArrayList<OrderClass> orders = new ArrayList<>();
    int page = 0;
    int pageNumber = 0;
    ListView productListView;
    CustomerClass selectedCustomer;
    /* access modifiers changed from: private */
    public ArrayList<db_ss_order> ss_order = new ArrayList<>();
    TextView title;
    private Toast toast;

    /* access modifiers changed from: protected */
    public void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        setContentView((int) R.layout.activity_main);
        this.metrics = new DisplayMetrics();
        this.navigation = (BottomNavigationView) findViewById(R.id.navigation);
        this.navigation.setOnNavigationItemSelectedListener(this.mOnNavigationItemSelectedListener);
        this.mainViewFlipper = (ViewFlipper) findViewById(R.id.mainViewFlipper);
        this.mainViewFlipper.setDisplayedChild(4);
        getSupportActionBar().setTitle((CharSequence) "홈");
        getSupportActionBar().hide();
        this.title = (TextView) findViewById(R.id.title);
        this.title.setText("성신 판매접수 - 홈");
        ((TextView) findViewById(R.id.tv_main_account_name)).setText(Module.getInstance().account_name + "님 로그인 중 입니다.");
        ((TextView) findViewById(R.id.tv_main_account_code)).setText(String.valueOf(Module.getInstance().account_code));
        ((TextView) findViewById(R.id.tv_main_account_gb)).setText(Module.getInstance().getAccountGBString());
        ((TextView) findViewById(R.id.tv_main_account_team)).setText(Module.getInstance().getTeamString());
        findViewById(R.id.btn_main_logout).setOnClickListener(this.clickListener);
        findViewById(R.id.btn_main_order).setOnClickListener(this.clickListener);
        findViewById(R.id.btn_main_getorder).setOnClickListener(this.clickListener);
        this.productListView = (ListView) findViewById(R.id.selectProductListView);
        this.addedProductListView = (ListView) findViewById(R.id.addedProductListView);
        this.customerListView = (ListView) findViewById(R.id.cusSearchListView);
        this.orderListView = (ListView) findViewById(R.id.getOrderListView);
        this.addressListView = (ListView) findViewById(R.id.addressListView);
        this.addedProducts = new ArrayList<>();
        findViewById(R.id.btn_addProduct).setOnClickListener(this.clickListener);
        findViewById(R.id.btn_customerSearch).setOnClickListener(this.clickListener);
        findViewById(R.id.btn_cusSearch).setOnClickListener(this.clickListener);
        findViewById(R.id.btn_order).setOnClickListener(this.clickListener);
        findViewById(R.id.btn_addressSearchBtn).setOnClickListener(this.clickListener);
        findViewById(R.id.btn_deliverySearchBtn).setOnClickListener(this.clickListener);
        findViewById(R.id.btn_addressSearch).setOnClickListener(this.clickListener);
        findViewById(R.id.btn_result_home).setOnClickListener(this.clickListener);
        findViewById(R.id.btn_reset).setOnClickListener(this.clickListener);
        ((EditText) findViewById(R.id.et_order_call)).addTextChangedListener(new PhoneNumberFormattingTextWatcher());
        ((EditText) findViewById(R.id.et_order_phone)).addTextChangedListener(new PhoneNumberFormattingTextWatcher());
        ((EditText) findViewById(R.id.et_customerSearch)).addTextChangedListener(new PhoneNumberFormattingTextWatcher());
        ((CheckBox) findViewById(R.id.checkBox2)).setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            public void onCheckedChanged(CompoundButton compoundButton, boolean z) {
                if (z) {
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_address)).setText(((EditText) MainActivity.this.findViewById(R.id.et_order_delivery)).getText().toString());
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_address_more)).setText(((EditText) MainActivity.this.findViewById(R.id.et_order_delivery_more)).getText().toString());
                    return;
                }
                ((EditText) MainActivity.this.findViewById(R.id.et_order_address)).setText(BuildConfig.FLAVOR);
                ((EditText) MainActivity.this.findViewById(R.id.et_order_address_more)).setText(BuildConfig.FLAVOR);
            }
        });
        ((CheckBox) findViewById(R.id.checkBox3)).setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            public void onCheckedChanged(CompoundButton compoundButton, boolean z) {
                if (z) {
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_phone)).setText(BuildConfig.FLAVOR);
                    MainActivity.this.findViewById(R.id.et_order_phone).setEnabled(false);
                    return;
                }
                MainActivity.this.findViewById(R.id.et_order_phone).setEnabled(true);
            }
        });
        ((CheckBox) findViewById(R.id.checkBox4)).setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            public void onCheckedChanged(CompoundButton compoundButton, boolean z) {
                if (z) {
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_call)).setText(BuildConfig.FLAVOR);
                    MainActivity.this.findViewById(R.id.et_order_call).setEnabled(false);
                    return;
                }
                MainActivity.this.findViewById(R.id.et_order_call).setEnabled(true);
            }
        });
        ((RadioButton) findViewById(R.id.rb_road)).setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            public void onCheckedChanged(CompoundButton compoundButton, boolean z) {
                if (z) {
                    ((RadioButton) MainActivity.this.findViewById(R.id.rb_dong)).setChecked(false);
                }
            }
        });
        ((RadioButton) findViewById(R.id.rb_dong)).setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            public void onCheckedChanged(CompoundButton compoundButton, boolean z) {
                if (z) {
                    ((RadioButton) MainActivity.this.findViewById(R.id.rb_road)).setChecked(false);
                }
            }
        });
        findViewById(R.id.et_addressSearch).setOnKeyListener(new View.OnKeyListener() {
            public boolean onKey(View view, int i, KeyEvent keyEvent) {
                if (i != 66) {
                    return false;
                }
                MainActivity.this.searchAddress();
                return false;
            }
        });
        findViewById(R.id.et_customerSearch).setOnKeyListener(new View.OnKeyListener() {
            public boolean onKey(View view, int i, KeyEvent keyEvent) {
                if (i != 66) {
                    return false;
                }
                MainActivity.this.customerSearch();
                return false;
            }
        });
        ((EditText) findViewById(R.id.productListSearch)).addTextChangedListener(new TextWatcher() {
            public void beforeTextChanged(CharSequence charSequence, int i, int i2, int i3) {
            }

            public void onTextChanged(CharSequence charSequence, int i, int i2, int i3) {
            }

            public void afterTextChanged(Editable editable) {
                try {
                    MainActivity.this.m_adapter.filter(editable.toString());
                } catch (Exception unused) {
                }
            }
        });
    }

    /* access modifiers changed from: private */
    public void OrderReset() {
        ((TextView) findViewById(R.id.et_order_name)).setText(BuildConfig.FLAVOR);
        ((TextView) findViewById(R.id.et_order_call)).setText(BuildConfig.FLAVOR);
        ((TextView) findViewById(R.id.et_order_phone)).setText(BuildConfig.FLAVOR);
        ((TextView) findViewById(R.id.et_order_address)).setText(BuildConfig.FLAVOR);
        ((TextView) findViewById(R.id.et_order_address_more)).setText(BuildConfig.FLAVOR);
        ((TextView) findViewById(R.id.et_order_delivery)).setText(BuildConfig.FLAVOR);
        ((TextView) findViewById(R.id.et_order_delivery_more)).setText(BuildConfig.FLAVOR);
        ((TextView) findViewById(R.id.et_etc)).setText(BuildConfig.FLAVOR);
        ((CheckBox) findViewById(R.id.checkBox2)).setChecked(false);
        ((CheckBox) findViewById(R.id.checkBox3)).setChecked(false);
        ((CheckBox) findViewById(R.id.checkBox4)).setChecked(false);
        this.addedProducts = new ArrayList<>();
        this.addedAdapter = new AddedProductAdapter(getApplicationContext(), this.addedProducts, this.metrics);
        this.addedProductListView.setAdapter(this.addedAdapter);
        findViewById(R.id.et_order_name).requestFocus();
    }

    public void orderBtn() {
        this.page = 1;
        this.navigation.getMenu().getItem(1).setChecked(true);
        this.mainViewFlipper.setInAnimation(AnimationUtils.loadAnimation(getApplicationContext(), R.anim.fadein));
        this.mainViewFlipper.setOutAnimation(AnimationUtils.loadAnimation(getApplicationContext(), R.anim.fadeout));
        this.title.setText("성신 판매접수 - 주문접수");
        findViewById(R.id.btn_main_logout).setVisibility(0);
        ((TextView) findViewById(R.id.btn_main_logout)).setBackgroundResource(R.drawable.corner_cell_yellow);
        ((TextView) findViewById(R.id.btn_main_logout)).setText("주문완료");
        ((TextView) findViewById(R.id.btn_main_logout)).setTextColor(getResources().getColor(R.color.black));
        this.pageNumber = 0;
        this.mainViewFlipper.setDisplayedChild(0);
    }

    public void getOrderBtn() {
        this.page = 2;
        this.navigation.getMenu().getItem(2).setChecked(true);
        this.mainViewFlipper.setInAnimation(AnimationUtils.loadAnimation(getApplicationContext(), R.anim.fadein));
        this.mainViewFlipper.setOutAnimation(AnimationUtils.loadAnimation(getApplicationContext(), R.anim.fadeout));
        this.pageNumber = 0;
        this.title.setText("성신 판매접수 - 조회");
        findViewById(R.id.btn_main_logout).setVisibility(4);
        this.mainViewFlipper.setDisplayedChild(3);
        findViewById(R.id.progressBar).setVisibility(0);
        findViewById(R.id.tv_order_nocontent).setVisibility(4);
        final ArrayList arrayList = new ArrayList();
        arrayList.addAll(Module.getInstance().account);
        arrayList.add(new NameValuePairClass("ac", String.valueOf(Module.getInstance().account_code)));
        GregorianCalendar gregorianCalendar = new GregorianCalendar(Locale.KOREA);
        gregorianCalendar.setTime(new Date());
        gregorianCalendar.add(6, -7);
        ((TextView) findViewById(R.id.tv_orderText)).setText(new SimpleDateFormat("yyyy년 MM월 dd일").format(gregorianCalendar.getTime()) + " ~ " + new SimpleDateFormat("yyyy년 MM월 dd일").format(new Date()));
        this.ss_order = new ArrayList<>();
        AsyncTaskClass asyncTaskClass = new AsyncTaskClass(getApplicationContext(), new OnTaskFinished() {
            public void onFeedRetrieved(String str) {
                MainActivity.products = new ArrayList<>();
                for (String split : Module.getInstance().RemoveEmptyEntity(str.split("<split>"))) {
                    String[] RemoveEmptyEntity = Module.getInstance().RemoveEmptyEntity(split.split("<next>"));
                    MainActivity.products.add(new ProductClass(RemoveEmptyEntity[0], Integer.valueOf(RemoveEmptyEntity[2]).intValue(), RemoveEmptyEntity[3], Integer.valueOf(RemoveEmptyEntity[4]).intValue(), Integer.valueOf(RemoveEmptyEntity[5]).intValue()));
                }
                MainActivity mainActivity = MainActivity.this;
                mainActivity.m_adapter = new ResultAdapter(mainActivity.getApplicationContext(), MainActivity.products, MainActivity.this.metrics);
                MainActivity.this.productListView.setAdapter(MainActivity.this.m_adapter);
                new AsyncTaskClass(MainActivity.this.getApplicationContext(), new OnTaskFinished() {
                    public void onFeedRetrieved(String str) {
                        if (str.trim().isEmpty()) {
                            MainActivity.this.findViewById(R.id.tv_order_nocontent).setVisibility(0);
                        }
                        try {
                            JSONArray jSONArray = new JSONArray(new JSONObject(str).getString("ss_order"));
                            for (int i = 0; i < jSONArray.length(); i++) {
                                MainActivity.this.ss_order.add(new db_ss_order(jSONArray.getJSONObject(i)));
                            }
                        } catch (JSONException e) {
                            e.printStackTrace();
                        }
                        ArrayList unused = MainActivity.this.orders = new ArrayList();
                        MainActivity.this.orderAdapter = new OrderAdapter(MainActivity.this.getApplicationContext(), MainActivity.this.ss_order, MainActivity.this.metrics);
                        MainActivity.this.orderListView.setAdapter(MainActivity.this.orderAdapter);
                        MainActivity.this.findViewById(R.id.progressBar).setVisibility(4);
                    }
                }, ResponseType.POST, arrayList).execute(new String[]{Module.getInstance().server + "admin.php?t=getOrderV3&pt=" + String.valueOf(Module.getInstance().team_code)});
            }
        }, ResponseType.POST, Module.getInstance().account);
        asyncTaskClass.execute(new String[]{Module.getInstance().server + "admin.php?t=getProduct&pt=" + String.valueOf(Module.getInstance().team_code)});
    }

    /* access modifiers changed from: private */
    public void customerSearch() {
        findViewById(R.id.progressBar).setVisibility(0);
        findViewById(R.id.tv_customer_nocontent).setVisibility(4);
        findViewById(R.id.cusSearchListView).setVisibility(4);
        if (((EditText) findViewById(R.id.et_customerSearch)).getText().toString().trim().equals("010")) {
            findViewById(R.id.tv_customer_nocontent).setVisibility(0);
            findViewById(R.id.progressBar).setVisibility(4);
            ((TextView) findViewById(R.id.tv_customer_nocontent)).setText("'010'은 검색할 수 없습니다.");
            return;
        }
        ((TextView) findViewById(R.id.tv_customer_nocontent)).setText("조회자료가 없습니다.");
        try {
            AsyncTaskClass asyncTaskClass = new AsyncTaskClass(getApplicationContext(), new OnTaskFinished() {
                public void onFeedRetrieved(String str) {
                    ArrayList unused = MainActivity.this.customers = new ArrayList();
                    for (String split : Module.getInstance().RemoveEmptyEntity(str.split("<split>"))) {
                        String[] split2 = split.split("<next>");
                        MainActivity.this.customers.add(new CustomerClass(Integer.valueOf(split2[0]).intValue(), split2[1], split2[2], split2[3], split2.length < 5 ? BuildConfig.FLAVOR : split2[4]));
                    }
                    if (MainActivity.this.customers.size() <= 0) {
                        MainActivity.this.findViewById(R.id.tv_customer_nocontent).setVisibility(0);
                        MainActivity.this.findViewById(R.id.cusSearchListView).setVisibility(4);
                    } else {
                        MainActivity.this.findViewById(R.id.cusSearchListView).setVisibility(0);
                    }
                    MainActivity mainActivity = MainActivity.this;
                    mainActivity.customerAdapter = new CustomerAdapter(mainActivity.getApplicationContext(), MainActivity.this.customers, MainActivity.this.metrics);
                    MainActivity.this.customerListView.setAdapter(MainActivity.this.customerAdapter);
                    MainActivity.this.findViewById(R.id.progressBar).setVisibility(4);
                }
            }, ResponseType.POST, Module.getInstance().account);
            asyncTaskClass.execute(new String[]{Module.getInstance().server + "admin.php?t=searchCustomer&cc=" + URLEncoder.encode(((EditText) findViewById(R.id.et_customerSearch)).getText().toString().trim(), "UTF-8")});
        } catch (UnsupportedEncodingException e) {
            e.printStackTrace();
        }
    }

    public View getViewByPosition(int i, ListView listView) {
        int firstVisiblePosition = listView.getFirstVisiblePosition();
        int childCount = (listView.getChildCount() + firstVisiblePosition) - 1;
        if (i < firstVisiblePosition || i > childCount) {
            return listView.getAdapter().getView(i, (View) null, listView);
        }
        return listView.getChildAt(i - firstVisiblePosition);
    }

    /* access modifiers changed from: private */
    public void searchAddress() {
        this.addressListView.setVisibility(4);
        findViewById(R.id.progressBar).setVisibility(0);
        findViewById(R.id.tv_address_noitem).setVisibility(4);
        String str = ((RadioButton) findViewById(R.id.rb_road)).isChecked() ? "road" : "dong";
        try {
            String encode = URLEncoder.encode(((EditText) findViewById(R.id.et_addressSearch)).getText().toString(), "UTF-8");
            AsyncTaskClass asyncTaskClass = new AsyncTaskClass(getApplicationContext(), new OnTaskFinished() {
                public void onFeedRetrieved(String str) {
                    String str2;
                    ArrayList unused = MainActivity.this.addresses = new ArrayList();
                    try {
                        XmlPullParserFactory newInstance = XmlPullParserFactory.newInstance();
                        newInstance.setNamespaceAware(true);
                        XmlPullParser newPullParser = newInstance.newPullParser();
                        newPullParser.setInput(new StringReader(str));
                        int eventType = newPullParser.getEventType();
                        String str3 = null;
                        String str4 = BuildConfig.FLAVOR;
                        String str5 = str4;
                        String str6 = str5;
                        while (eventType != 1) {
                            if (eventType == 2) {
                                str2 = newPullParser.getName();
                                if (str2.equals("newAddressListAreaCd")) {
                                    str3 = str2;
                                    str4 = BuildConfig.FLAVOR;
                                    str5 = str4;
                                    str6 = str5;
                                    eventType = newPullParser.next();
                                }
                            } else if (eventType != 3) {
                                if (eventType == 4) {
                                    if (!str3.isEmpty()) {
                                        if (str3.equals("zipNo")) {
                                            str4 = newPullParser.getText();
                                        }
                                        if (str3.equals("lnmAdres")) {
                                            str5 = newPullParser.getText();
                                        }
                                        if (str3.equals("rnAdres")) {
                                            str6 = newPullParser.getText();
                                        }
                                    }
                                }
                                eventType = newPullParser.next();
                            } else {
                                str2 = newPullParser.getName();
                                if (str2.equals("newAddressListAreaCd")) {
                                    MainActivity.this.addresses.add(new AddressClass(str4, str5, str6));
                                }
                            }
                            str3 = str2;
                            eventType = newPullParser.next();
                        }
                        if (MainActivity.this.addresses.size() <= 0) {
                            MainActivity.this.findViewById(R.id.tv_address_noitem).setVisibility(0);
                        }
                        MainActivity.this.addressAdapter = new AddressAdapter(MainActivity.this.getApplicationContext(), MainActivity.this.addresses, MainActivity.this.metrics);
                        MainActivity.this.addressListView.setAdapter(MainActivity.this.addressAdapter);
                        MainActivity.this.addressListView.setVisibility(0);
                        MainActivity.this.findViewById(R.id.progressBar).setVisibility(4);
                    } catch (UnsupportedEncodingException e) {
                        e.printStackTrace();
                    } catch (XmlPullParserException e2) {
                        e2.printStackTrace();
                    } catch (IOException e3) {
                        e3.printStackTrace();
                    }
                }
            }, ResponseType.GET, (ArrayList<NameValuePairClass>) null);
            asyncTaskClass.execute(new String[]{"http://openapi.epost.go.kr/postal/retrieveNewAdressAreaCdService/retrieveNewAdressAreaCdService/getNewAddressListAreaCd?ServiceKey=wQ%2FAbKiAjfgBNNG5F%2FGgFypOBN8CyMtru7UsQjAcgMKc50%2BhY7D0aHspt9HIFoUifdgTmEbPK8%2BdumuI9EWVvQ%3D%3D&countPerPage=100&currentPage=1&searchSe=" + str + "&srchwrd=" + encode});
        } catch (UnsupportedEncodingException e) {
            e.printStackTrace();
        }
    }

    private class CustomerAdapter extends ArrayAdapter<CustomerClass> {
        private View.OnClickListener buttonClickListener = new View.OnClickListener() {
            public void onClick(View view) {
                CustomerClass customerClass = (CustomerClass) CustomerAdapter.this.items.get(((Integer) view.getTag()).intValue());
                MainActivity.this.selectedCustomer = customerClass;
                if (customerClass.getCustomerCall().isEmpty()) {
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_call)).setText(BuildConfig.FLAVOR);
                    ((CheckBox) MainActivity.this.findViewById(R.id.checkBox4)).setChecked(true);
                } else {
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_call)).setText(customerClass.getCustomerCall());
                    ((CheckBox) MainActivity.this.findViewById(R.id.checkBox4)).setChecked(false);
                }
                if (customerClass.getCustomerPhone().isEmpty()) {
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_phone)).setText(BuildConfig.FLAVOR);
                    ((CheckBox) MainActivity.this.findViewById(R.id.checkBox3)).setChecked(true);
                } else {
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_phone)).setText(customerClass.getCustomerPhone());
                    ((CheckBox) MainActivity.this.findViewById(R.id.checkBox3)).setChecked(false);
                }
                ((EditText) MainActivity.this.findViewById(R.id.et_order_name)).setText(customerClass.getCustomerName());
                if (customerClass.getCustomerAddress().indexOf("<other>") > 0) {
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_address)).setText(customerClass.getCustomerAddress().substring(0, customerClass.getCustomerAddress().indexOf("<other>")));
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_address_more)).setText(customerClass.getCustomerAddress().substring(customerClass.getCustomerAddress().indexOf("<other>") + 7));
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_delivery)).setText(customerClass.getCustomerAddress().substring(0, customerClass.getCustomerAddress().indexOf("<other>")));
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_delivery_more)).setText(customerClass.getCustomerAddress().substring(customerClass.getCustomerAddress().indexOf("<other>") + 7));
                } else {
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_address)).setText(customerClass.getCustomerAddress());
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_address_more)).setText(BuildConfig.FLAVOR);
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_delivery)).setText(customerClass.getCustomerAddress());
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_delivery_more)).setText(BuildConfig.FLAVOR);
                }
                MainActivity.this.mainViewFlipper.setDisplayedChild(0);
                MainActivity.this.pageNumber = 0;
                ((InputMethodManager) MainActivity.this.getSystemService("input_method")).hideSoftInputFromWindow(MainActivity.this.findViewById(R.id.et_order_delivery).getWindowToken(), 0);
            }
        };
        private Context context;
        /* access modifiers changed from: private */
        public ArrayList<CustomerClass> items;
        private DisplayMetrics metrics_;
        private ViewHolder viewHolder = null;

        public CustomerAdapter(Context context2, ArrayList<CustomerClass> arrayList, DisplayMetrics displayMetrics) {
            super(context2, R.layout.layout_customer_list, arrayList);
            this.items = arrayList;
            this.metrics_ = displayMetrics;
            this.context = context2;
        }

        public View getView(int i, View view, ViewGroup viewGroup) {
            CustomerClass customerClass = this.items.get(i);
            if (view == null) {
                this.viewHolder = new ViewHolder();
                view = ((LayoutInflater) MainActivity.this.getSystemService("layout_inflater")).inflate(R.layout.layout_customer_list, (ViewGroup) null);
                this.viewHolder.customer_code = (TextView) view.findViewById(R.id.tv_customer_code);
                this.viewHolder.customer_name = (TextView) view.findViewById(R.id.tv_customer_name);
                this.viewHolder.customer_call = (TextView) view.findViewById(R.id.tv_customer_call);
                this.viewHolder.customer_phone = (TextView) view.findViewById(R.id.tv_customer_phone);
                this.viewHolder.customer_address = (TextView) view.findViewById(R.id.tv_customer_address);
                this.viewHolder.btn = (RelativeLayout) view.findViewById(R.id.button);
                view.setTag(this.viewHolder);
            } else {
                this.viewHolder = (ViewHolder) view.getTag();
            }
            if (customerClass != null) {
                this.viewHolder.customer_code.setText(String.valueOf(customerClass.getCustomerCode()));
                this.viewHolder.customer_name.setText(customerClass.getCustomerName());
                if (customerClass.getCustomerCall().isEmpty()) {
                    this.viewHolder.customer_call.setText("-");
                } else {
                    this.viewHolder.customer_call.setText(customerClass.getCustomerCall());
                }
                if (customerClass.getCustomerPhone().isEmpty()) {
                    this.viewHolder.customer_phone.setText("-");
                } else {
                    this.viewHolder.customer_phone.setText(customerClass.getCustomerPhone());
                }
                this.viewHolder.customer_address.setText(customerClass.getCustomerAddress().replace("<other>", " "));
                this.viewHolder.btn.setTag(Integer.valueOf(i));
                this.viewHolder.btn.setOnClickListener(this.buttonClickListener);
            }
            return view;
        }

        class ViewHolder {
            public RelativeLayout btn = null;
            public TextView customer_address = null;
            public TextView customer_call = null;
            public TextView customer_code = null;
            public TextView customer_name = null;
            public TextView customer_phone = null;

            ViewHolder() {
            }
        }
    }

    /* access modifiers changed from: private */
    public void dataSave() {
        for (int i = 0; i < this.addedAdapter.items.size(); i++) {
            View viewByPosition = getViewByPosition(i, this.addedProductListView);
            this.addedProducts.get(i).setProductCount(Integer.valueOf(((TextView) viewByPosition.findViewById(R.id.et_product_stock)).getText().toString()).intValue());
            if (!((TextView) viewByPosition.findViewById(R.id.et_product_price)).getText().toString().isEmpty()) {
                this.addedProducts.get(i).setProductPrice(Integer.valueOf(((TextView) viewByPosition.findViewById(R.id.et_product_price)).getText().toString()).intValue());
            } else {
                this.addedProducts.get(i).setProductPrice(0);
            }
            this.addedProducts.get(i).setOrderEtc(((TextView) viewByPosition.findViewById(R.id.et_product_etc)).getText().toString());
        }
    }

    private class AddedProductAdapter extends ArrayAdapter<ProductClass> {
        private View.OnClickListener buttonClickListener = new View.OnClickListener() {
            public void onClick(View view) {
                switch (view.getId()) {
                    case R.id.btn_10minus:
                        EditText editText = (EditText) view.getTag();
                        int intValue = Integer.valueOf(editText.getText().toString()).intValue();
                        if (intValue <= 10) {
                            editText.setText("1");
                        } else {
                            editText.setText(String.valueOf(intValue - 10));
                        }
                        ((InputMethodManager) MainActivity.this.getSystemService("input_method")).hideSoftInputFromWindow(editText.getWindowToken(), 0);
                        return;
                    case R.id.btn_10plus:
                        EditText editText2 = (EditText) view.getTag();
                        int intValue2 = Integer.valueOf(editText2.getText().toString()).intValue() + 10;
                        if (((ProductClass) AddedProductAdapter.this.items.get(((Integer) editText2.getTag()).intValue())).getProductStock() > intValue2) {
                            editText2.setText(String.valueOf(intValue2));
                            ((InputMethodManager) MainActivity.this.getSystemService("input_method")).hideSoftInputFromWindow(editText2.getWindowToken(), 0);
                            return;
                        }
                        return;
                    case R.id.btn_minus:
                        EditText editText3 = (EditText) view.getTag();
                        ProductClass productClass = (ProductClass) AddedProductAdapter.this.items.get(((Integer) editText3.getTag()).intValue());
                        int intValue3 = Integer.valueOf(editText3.getText().toString()).intValue();
                        if (intValue3 > 1) {
                            editText3.setText(String.valueOf(intValue3 - 1));
                            ((InputMethodManager) MainActivity.this.getSystemService("input_method")).hideSoftInputFromWindow(editText3.getWindowToken(), 0);
                            return;
                        }
                        return;
                    case R.id.btn_plus:
                        EditText editText4 = (EditText) view.getTag();
                        int intValue4 = Integer.valueOf(editText4.getText().toString()).intValue();
                        if (((ProductClass) AddedProductAdapter.this.items.get(((Integer) editText4.getTag()).intValue())).getProductStock() > intValue4) {
                            editText4.setText(String.valueOf(intValue4 + 1));
                            ((InputMethodManager) MainActivity.this.getSystemService("input_method")).hideSoftInputFromWindow(editText4.getWindowToken(), 0);
                            return;
                        }
                        return;
                    case R.id.recycle:
                        final ProductClass productClass2 = (ProductClass) AddedProductAdapter.this.items.get(((Integer) view.getTag()).intValue());
                        ((InputMethodManager) MainActivity.this.getSystemService("input_method")).hideSoftInputFromWindow(MainActivity.this.findViewById(R.id.et_order_call).getWindowToken(), 0);
                        AlertDialog.Builder positiveButton = new AlertDialog.Builder(MainActivity.this).setOnCancelListener(new DialogInterface.OnCancelListener() {
                            public void onCancel(DialogInterface dialogInterface) {
                            }
                        }).setNegativeButton("취소", new DialogInterface.OnClickListener() {
                            public void onClick(DialogInterface dialogInterface, int i) {
                            }
                        }).setPositiveButton(Html.fromHtml("<font color=red>지우기"), new DialogInterface.OnClickListener() {
                            public void onClick(DialogInterface dialogInterface, int i) {
                                MainActivity.this.dataSave();
                                AddedProductAdapter.this.items.remove(productClass2);
                                AddedProductAdapter.this.refreshEvents((ArrayList<ProductClass>) null);
                            }
                        });
                        positiveButton.setMessage(Html.fromHtml("<font color=red>" + productClass2._product_name + "</font> 제품을 주문목록에서 지우겠습니까?")).show();
                        return;
                    default:
                        return;
                }
            }
        };
        private Context context;
        /* access modifiers changed from: private */
        public ArrayList<ProductClass> items;
        private DisplayMetrics metrics_;
        /* access modifiers changed from: private */
        public ViewHolder viewHolder = null;

        public AddedProductAdapter(Context context2, ArrayList<ProductClass> arrayList, DisplayMetrics displayMetrics) {
            super(context2, R.layout.layout_added_product_list, arrayList);
            this.items = arrayList;
            this.metrics_ = displayMetrics;
            this.context = context2;
        }

        public View getView(int i, View view, ViewGroup viewGroup) {
            final ProductClass productClass = this.items.get(i);
            if (view == null) {
                this.viewHolder = new ViewHolder();
                view = ((LayoutInflater) MainActivity.this.getSystemService("layout_inflater")).inflate(R.layout.layout_added_product_list, (ViewGroup) null);
                this.viewHolder.minus = (Button) view.findViewById(R.id.btn_minus);
                this.viewHolder.plus = (Button) view.findViewById(R.id.btn_plus);
                this.viewHolder.minus10 = (Button) view.findViewById(R.id.btn_10minus);
                this.viewHolder.plus10 = (Button) view.findViewById(R.id.btn_10plus);
                this.viewHolder.recycle = (ImageView) view.findViewById(R.id.recycle);
                this.viewHolder.product_name = (TextView) view.findViewById(R.id.tv_product_name);
                this.viewHolder.product_stock = (TextView) view.findViewById(R.id.tv_stock);
                this.viewHolder.product_price = (EditText) view.findViewById(R.id.et_product_price);
                this.viewHolder.product_count = (EditText) view.findViewById(R.id.et_product_stock);
                this.viewHolder.product_etc = (EditText) view.findViewById(R.id.et_product_etc);
                view.setTag(this.viewHolder);
            } else {
                this.viewHolder = (ViewHolder) view.getTag();
            }
            if (productClass != null) {
                this.viewHolder.product_name.setText(productClass.getProductName());
                TextView textView = this.viewHolder.product_stock;
                textView.setText("최대 가능 수량 : " + String.valueOf(productClass.getProductStock()) + "개");
                this.viewHolder.product_price.setHint(String.valueOf(productClass.getProductPrice()));
                this.viewHolder.product_price.setText(BuildConfig.FLAVOR);
                if (productClass.getProductPrice() != 0) {
                    this.viewHolder.product_price.setText(String.valueOf(productClass.getProductPrice()));
                }
                this.viewHolder.product_count.setText(String.valueOf(productClass.getProductCount()));
                this.viewHolder.product_etc.setText(productClass.getETC());
                this.viewHolder.recycle.setOnClickListener(this.buttonClickListener);
                this.viewHolder.minus.setOnClickListener(this.buttonClickListener);
                this.viewHolder.plus.setOnClickListener(this.buttonClickListener);
                this.viewHolder.minus10.setOnClickListener(this.buttonClickListener);
                this.viewHolder.plus10.setOnClickListener(this.buttonClickListener);
                this.viewHolder.product_count.setTag(Integer.valueOf(i));
                this.viewHolder.minus.setTag(this.viewHolder.product_count);
                this.viewHolder.plus.setTag(this.viewHolder.product_count);
                this.viewHolder.minus10.setTag(this.viewHolder.product_count);
                this.viewHolder.plus10.setTag(this.viewHolder.product_count);
                this.viewHolder.recycle.setTag(Integer.valueOf(i));
                this.viewHolder.product_count.setOnFocusChangeListener(new View.OnFocusChangeListener() {
                    public void onFocusChange(View view, boolean z) {
                        if (z) {
                            return;
                        }
                        if (AddedProductAdapter.this.viewHolder.product_count.getText().toString().isEmpty()) {
                            ((EditText) view).setText("1");
                        } else if (productClass.getProductStock() <= Integer.valueOf(AddedProductAdapter.this.viewHolder.product_count.getText().toString()).intValue()) {
                            ((EditText) view).setText(String.valueOf(productClass.getProductStock()));
                        }
                    }
                });
            }
            return view;
        }

        public void refreshEvents(ArrayList<ProductClass> arrayList) {
            if (arrayList != null) {
                this.items.clear();
                this.items.addAll(arrayList);
            }
            notifyDataSetChanged();
        }

        class ViewHolder {
            public Button minus = null;
            public Button minus10 = null;
            public Button plus = null;
            public Button plus10 = null;
            public EditText product_count = null;
            public EditText product_etc = null;
            public TextView product_name = null;
            public EditText product_price = null;
            public TextView product_stock = null;
            public ImageView recycle = null;

            ViewHolder() {
            }
        }
    }

    private class ResultAdapter extends ArrayAdapter<ProductClass> {
        private ArrayList<ProductClass> bin_items;
        private View.OnClickListener buttonClickListener = new View.OnClickListener() {
            public void onClick(View view) {
                ProductClass productClass = (ProductClass) ResultAdapter.this.items.get(((Integer) view.getTag()).intValue());
                if (productClass.getProductStock() <= 0) {
                    Toast.makeText(MainActivity.this.getApplicationContext(), "재고가 없는 제품 입니다.\n주문 할 수 없습니다.", 1).show();
                    return;
                }
                Iterator it = MainActivity.this.addedProducts.iterator();
                while (it.hasNext()) {
                    if (((ProductClass) it.next()).getProductCode().equals(productClass.getProductCode())) {
                        Toast.makeText(MainActivity.this.getApplicationContext(), "주문 목록에 이미 선택한 제품이 있습니다.", 1).show();
                        return;
                    }
                }
                if (MainActivity.this.addedProducts.size() <= 0) {
                    MainActivity.this.addedProducts.add(productClass);
                    MainActivity.this.addedAdapter = new AddedProductAdapter(MainActivity.this.getApplicationContext(), MainActivity.this.addedProducts, MainActivity.this.metrics);
                    MainActivity.this.addedProductListView.setAdapter(MainActivity.this.addedAdapter);
                } else {
                    MainActivity.this.dataSave();
                    MainActivity.this.addedProducts.add(productClass);
                    MainActivity.this.addedAdapter.refreshEvents((ArrayList<ProductClass>) null);
                }
                MainActivity.this.mainViewFlipper.setDisplayedChild(0);
                MainActivity.this.pageNumber = 0;
                MainActivity.this.addedProductListView.requestFocus();
                ((InputMethodManager) MainActivity.this.getSystemService("input_method")).hideSoftInputFromWindow(MainActivity.this.findViewById(R.id.et_order_delivery).getWindowToken(), 0);
            }
        };
        private Context context;
        /* access modifiers changed from: private */
        public ArrayList<ProductClass> items;
        private DisplayMetrics metrics_;
        private ViewHolder viewHolder = null;

        public ResultAdapter(Context context2, ArrayList<ProductClass> arrayList, DisplayMetrics displayMetrics) {
            super(context2, R.layout.layout_product_list, arrayList);
            this.items = arrayList;
            this.bin_items = new ArrayList<>();
            this.bin_items.addAll(arrayList);
            this.metrics_ = displayMetrics;
            this.context = context2;
        }

        public View getView(int i, View view, ViewGroup viewGroup) {
            ProductClass productClass = this.items.get(i);
            if (view == null) {
                this.viewHolder = new ViewHolder();
                view = ((LayoutInflater) MainActivity.this.getSystemService("layout_inflater")).inflate(R.layout.layout_product_list, (ViewGroup) null);
                this.viewHolder.btn = (RelativeLayout) view.findViewById(R.id.button);
                this.viewHolder.product_gb = (TextView) view.findViewById(R.id.tv_product_gb);
                this.viewHolder.product_name = (TextView) view.findViewById(R.id.tv_product_name);
                this.viewHolder.product_price = (TextView) view.findViewById(R.id.tv_product_price);
                this.viewHolder.product_stock = (TextView) view.findViewById(R.id.tv_product_stock);
                view.setTag(this.viewHolder);
            } else {
                this.viewHolder = (ViewHolder) view.getTag();
            }
            if (productClass != null) {
                this.viewHolder.product_gb.setText(productClass.getGB() == 1 ? "본품" : "사례");
                this.viewHolder.product_name.setText(productClass.getProductName());
                TextView textView = this.viewHolder.product_price;
                textView.setText("￦" + NumberFormat.getNumberInstance(Locale.US).format((long) productClass.getProductPrice()));
                TextView textView2 = this.viewHolder.product_stock;
                textView2.setText(String.valueOf(productClass.getProductStock()) + "개");
                this.viewHolder.btn.setOnClickListener(this.buttonClickListener);
                this.viewHolder.btn.setTag(Integer.valueOf(i));
            }
            return view;
        }

        public void filter(String str) {
            try {
                this.items.clear();
                if (str.length() == 0) {
                    this.items.addAll(this.bin_items);
                } else {
                    Iterator<ProductClass> it = this.bin_items.iterator();
                    while (it.hasNext()) {
                        ProductClass next = it.next();
                        str = str.toLowerCase(Locale.getDefault()).replace(" ", BuildConfig.FLAVOR);
                        if (next.getProductName().replace(" ", BuildConfig.FLAVOR).toLowerCase(Locale.getDefault()).contains(str)) {
                            this.items.add(next);
                        }
                    }
                }
            } catch (Exception unused) {
                this.items.clear();
                this.items.addAll(this.bin_items);
            }
            notifyDataSetChanged();
        }

        class ViewHolder {
            public RelativeLayout btn = null;
            public TextView product_gb = null;
            public TextView product_name = null;
            public TextView product_price = null;
            public TextView product_stock = null;

            ViewHolder() {
            }
        }
    }

    private class OrderAdapter extends ArrayAdapter<db_ss_order> {
        private View.OnClickListener buttonClickListener = new View.OnClickListener() {
            public void onClick(View view) {
                final db_ss_order db_ss_order = (db_ss_order) OrderAdapter.this.items.get(((Integer) view.getTag()).intValue());
                new AlertDialog.Builder(MainActivity.this).setOnCancelListener(new DialogInterface.OnCancelListener() {
                    public void onCancel(DialogInterface dialogInterface) {
                    }
                }).setNegativeButton("닫기", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialogInterface, int i) {
                    }
                }).setPositiveButton("확인", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialogInterface, int i) {
                        AsyncTaskClass asyncTaskClass = new AsyncTaskClass(MainActivity.this.getApplicationContext(), new OnTaskFinished() {
                            public void onFeedRetrieved(String str) {
                                if (str.trim().equals("ok")) {
                                    db_ss_order.order_status = 3;
                                    Toast.makeText(MainActivity.this.getApplicationContext(), "발송전 취소가 되었습니다.", 1).show();
                                    MainActivity.this.orderAdapter.refreshEvents();
                                    return;
                                }
                                Toast.makeText(MainActivity.this.getApplicationContext(), str, 1).show();
                            }
                        }, ResponseType.POST, Module.getInstance().account);
                        asyncTaskClass.execute(new String[]{Module.getInstance().server + "admin.php?t=setOrderStatus&tc=99&s=3&i=" + String.valueOf(db_ss_order.index) + "&od=" + db_ss_order.order_delivery + "&oe=" + db_ss_order.order_etc + "&oa=" + db_ss_order.order_address + "&pc=" + db_ss_order.getProducts() + "&ac=" + Module.getInstance().account_code, "UTF-8"});
                    }
                }).setTitle("발송전 취소").setMessage("발송전 취소를 하면 주문이 취소됩니다.\n취소 하시겠습니까?").show();
                ((InputMethodManager) MainActivity.this.getSystemService("input_method")).hideSoftInputFromWindow(MainActivity.this.findViewById(R.id.et_order_delivery).getWindowToken(), 0);
            }
        };
        private Context context;
        /* access modifiers changed from: private */
        public ArrayList<db_ss_order> items;
        private DisplayMetrics metrics_;
        private ViewHolder viewHolder = null;

        public OrderAdapter(Context context2, ArrayList<db_ss_order> arrayList, DisplayMetrics displayMetrics) {
            super(context2, R.layout.layout_order_list, arrayList);
            this.items = arrayList;
            this.metrics_ = displayMetrics;
            this.context = context2;
        }

        public View getView(int i, View view, ViewGroup viewGroup) {
            db_ss_order db_ss_order = this.items.get(i);
            if (view == null) {
                this.viewHolder = new ViewHolder();
                view = ((LayoutInflater) MainActivity.this.getSystemService("layout_inflater")).inflate(R.layout.layout_order_list, (ViewGroup) null);
                this.viewHolder.btn = (Button) view.findViewById(R.id.btn_cancel);
                this.viewHolder.order_index = (TextView) view.findViewById(R.id.tv_order_index);
                this.viewHolder.order_date = (TextView) view.findViewById(R.id.tv_order_date);
                this.viewHolder.order_cuscode = (TextView) view.findViewById(R.id.tv_order_cuscode);
                this.viewHolder.order_cusname = (TextView) view.findViewById(R.id.tv_order_cusname);
                this.viewHolder.order_cuscall = (TextView) view.findViewById(R.id.tv_order_cuscall);
                this.viewHolder.order_cusphone = (TextView) view.findViewById(R.id.tv_order_cusphone);
                this.viewHolder.order_cusdelivery = (TextView) view.findViewById(R.id.tv_order_cusdelivery);
                this.viewHolder.order_product_names = (TextView) view.findViewById(R.id.tv_order_product_name);
                this.viewHolder.order_product_price = (TextView) view.findViewById(R.id.tv_order_product_price);
                this.viewHolder.order_status = (TextView) view.findViewById(R.id.tv_order_status);
                this.viewHolder.order_delivery = (TextView) view.findViewById(R.id.tv_order_delivery);
                this.viewHolder.order_etc = (TextView) view.findViewById(R.id.tv_order_etc);
                view.setTag(this.viewHolder);
            } else {
                this.viewHolder = (ViewHolder) view.getTag();
            }
            if (db_ss_order != null) {
                this.viewHolder.order_index.setText(String.valueOf(db_ss_order.index));
                this.viewHolder.order_date.setText(db_ss_order.order_date);
                this.viewHolder.order_cuscode.setText(String.valueOf(db_ss_order.cus_code));
                this.viewHolder.order_cusname.setText(db_ss_order.cus_name);
                this.viewHolder.order_cuscall.setText(db_ss_order.getCall());
                this.viewHolder.order_cusphone.setText(db_ss_order.getPhone());
                this.viewHolder.order_cusdelivery.setText(db_ss_order.order_address);
                this.viewHolder.order_product_names.setText(db_ss_order._order_product_names);
                this.viewHolder.order_product_price.setText(db_ss_order._order_product_price);
                this.viewHolder.order_delivery.setText(db_ss_order.getDeliveryCode());
                this.viewHolder.order_etc.setText(db_ss_order.getETC());
                int intValue = Integer.valueOf(db_ss_order.order_status).intValue();
                this.viewHolder.order_status.setText(Html.fromHtml(intValue != 2 ? intValue != 3 ? intValue != 4 ? "<font color='#B913CF'>접수 대기" : "<font color='#7EB70B'>발송 완료" : "<font color=red>발송전 취소" : "<font color=blue>발송 전"));
                this.viewHolder.btn.setOnClickListener(this.buttonClickListener);
                this.viewHolder.btn.setTag(Integer.valueOf(i));
                if (db_ss_order.order_status == 3) {
                    this.viewHolder.btn.setText("발송전 취소됨");
                    this.viewHolder.btn.getBackground().setColorFilter(-12303292, PorterDuff.Mode.SRC_ATOP);
                    this.viewHolder.btn.setEnabled(false);
                } else if (db_ss_order.order_status == 4) {
                    this.viewHolder.btn.setText("발송 완료");
                    this.viewHolder.btn.getBackground().setColorFilter(-12303292, PorterDuff.Mode.SRC_ATOP);
                    this.viewHolder.btn.setEnabled(false);
                } else {
                    this.viewHolder.btn.setText("발송전 취소");
                    this.viewHolder.btn.getBackground().setColorFilter(SupportMenu.CATEGORY_MASK, PorterDuff.Mode.SRC_ATOP);
                    this.viewHolder.btn.setEnabled(true);
                }
            }
            return view;
        }

        public void refreshEvents() {
            notifyDataSetChanged();
        }

        class ViewHolder {
            public Button btn = null;
            public TextView order_cuscall = null;
            public TextView order_cuscode = null;
            public TextView order_cusdelivery = null;
            public TextView order_cusname = null;
            public TextView order_cusphone = null;
            public TextView order_date = null;
            public TextView order_delivery = null;
            public TextView order_etc = null;
            public TextView order_index = null;
            public TextView order_product_names = null;
            public TextView order_product_price = null;
            public TextView order_status = null;

            ViewHolder() {
            }
        }
    }

    private class AddressAdapter extends ArrayAdapter<AddressClass> {
        private View.OnClickListener buttonClickListener = new View.OnClickListener() {
            public void onClick(View view) {
                AddressClass addressClass = (AddressClass) AddressAdapter.this.items.get(((Integer) view.getTag()).intValue());
                MainActivity.this.pageNumber = 0;
                MainActivity.this.mainViewFlipper.setDisplayedChild(0);
                if (MainActivity.this.addressSearchMode) {
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_address)).setText("(우)" + addressClass._address_post + " " + addressClass._address_road);
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_address)).requestFocus();
                } else {
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_delivery)).setText("(우)" + addressClass._address_post + " " + addressClass._address_road);
                    ((EditText) MainActivity.this.findViewById(R.id.et_order_delivery)).requestFocus();
                }
                ((InputMethodManager) MainActivity.this.getSystemService("input_method")).hideSoftInputFromWindow(MainActivity.this.findViewById(R.id.et_order_delivery).getWindowToken(), 0);
            }
        };
        private Context context;
        /* access modifiers changed from: private */
        public ArrayList<AddressClass> items;
        private DisplayMetrics metrics_;
        private ViewHolder viewHolder = null;

        public AddressAdapter(Context context2, ArrayList<AddressClass> arrayList, DisplayMetrics displayMetrics) {
            super(context2, R.layout.layout_address_list, arrayList);
            this.items = arrayList;
            this.metrics_ = displayMetrics;
            this.context = context2;
        }

        public View getView(int i, View view, ViewGroup viewGroup) {
            AddressClass addressClass = this.items.get(i);
            if (view == null) {
                this.viewHolder = new ViewHolder();
                view = ((LayoutInflater) MainActivity.this.getSystemService("layout_inflater")).inflate(R.layout.layout_address_list, (ViewGroup) null);
                this.viewHolder.btn = (RelativeLayout) view.findViewById(R.id.button);
                this.viewHolder.address_post = (TextView) view.findViewById(R.id.tv_address_postcode);
                this.viewHolder.address_road = (TextView) view.findViewById(R.id.tv_address_road);
                this.viewHolder.address_dong = (TextView) view.findViewById(R.id.tv_address_dong);
                view.setTag(this.viewHolder);
            } else {
                this.viewHolder = (ViewHolder) view.getTag();
            }
            if (addressClass != null) {
                this.viewHolder.address_post.setText(addressClass._address_post);
                this.viewHolder.address_road.setText(addressClass._address_road);
                this.viewHolder.address_dong.setText(addressClass._address_dong);
                this.viewHolder.btn.setOnClickListener(this.buttonClickListener);
                this.viewHolder.btn.setTag(Integer.valueOf(i));
            }
            return view;
        }

        class ViewHolder {
            public TextView address_dong = null;
            public TextView address_post = null;
            public TextView address_road = null;
            public RelativeLayout btn = null;

            ViewHolder() {
            }
        }
    }

    public void onBackPressed() {
        int i = this.pageNumber;
        if (i > 0) {
            this.pageNumber = 0;
            this.mainViewFlipper.setInAnimation(AnimationUtils.loadAnimation(getApplicationContext(), R.anim.slide_in_left));
            this.mainViewFlipper.setOutAnimation(AnimationUtils.loadAnimation(getApplicationContext(), R.anim.slide_out_right));
            this.mainViewFlipper.setDisplayedChild(0);
        } else if (i != 0) {
        } else {
            if (System.currentTimeMillis() > this.backKeyPressedTime + 2000) {
                this.backKeyPressedTime = System.currentTimeMillis();
                showGuide();
            } else if (System.currentTimeMillis() <= this.backKeyPressedTime + 2000) {
                moveTaskToBack(true);
                finish();
                Process.killProcess(Process.myPid());
                this.toast.cancel();
            }
        }
    }

    private void showGuide() {
        this.toast = Toast.makeText(this, "[뒤로] 버튼을 한번 더 누르면 종료됩니다.", 0);
        this.toast.show();
    }
}
