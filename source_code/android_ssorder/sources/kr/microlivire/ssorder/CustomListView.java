package kr.microlivire.ssorder;

import android.content.Context;
import android.graphics.Canvas;
import android.util.AttributeSet;
import android.view.ViewGroup;
import android.widget.ListView;

public class CustomListView extends ListView {
    private ViewGroup.LayoutParams params;
    private int prevCount = 0;

    public CustomListView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
    }

    /* access modifiers changed from: protected */
    public void onDraw(Canvas canvas) {
        int count = getCount();
        if (count == 0) {
            this.prevCount = getCount();
            this.params = getLayoutParams();
            ViewGroup.LayoutParams layoutParams = this.params;
            layoutParams.height = 1;
            setLayoutParams(layoutParams);
            return;
        }
        if (count != this.prevCount) {
            this.prevCount = getCount();
            this.params = getLayoutParams();
            this.params.height = getCount() * (getChildAt(0).getHeight() + 4);
            setLayoutParams(this.params);
        }
        super.onDraw(canvas);
    }
}
