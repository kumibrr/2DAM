package com.example.a009_simplecalcs;

import android.view.View;
import android.widget.TextView;

public class ButtonHandler implements View.OnClickListener {

    private MainActivity activity;

    ButtonHandler (MainActivity activity) {
        this.activity = activity;
    }

    @Override
    public void onClick(View v) {
        TextView rawA = activity.findViewById(R.id.inFirstNumber);
        TextView rawB = activity.findViewById(R.id.inSecondNumber);
        Integer a = Integer.parseInt(rawA.getText().toString());
        Integer b = Integer.parseInt(rawB.getText().toString());
        Integer r;
        TextView result = activity.findViewById(R.id.txtResult);

        switch (v.getId()) {
            case R.id.btnAddNumbers:
                r = a + b;
                result.setText(r.toString());
                break;
            case R.id.btnSubstractNumbers:
                r = a - b;
                result.setText(r.toString());
                break;
        }
    }
}
