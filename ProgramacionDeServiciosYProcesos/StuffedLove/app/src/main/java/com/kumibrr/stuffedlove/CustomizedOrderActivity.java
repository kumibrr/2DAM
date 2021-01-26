package com.kumibrr.stuffedlove;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.service.controls.Control;
import android.util.Log;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Toast;

import com.kumibrr.stuffedlove.model.CustomPlush;
import com.kumibrr.stuffedlove.model.Plush;
import com.kumibrr.stuffedlove.model.PlushSize;

import java.util.ArrayList;
import java.util.List;

public class CustomizedOrderActivity extends CoreActivity {

    private PlushSize size;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_customized_order);

        Button makeOrder = (Button) findViewById(R.id.btnMakeOrder);
        RadioGroup sizeGroup = (RadioGroup) findViewById(R.id.radiogroupSize);



        makeOrder.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Intent intent = new Intent(CustomizedOrderActivity.this, ThankyouActivity.class);
                intent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
                startActivity(intent);
            }
        });

        sizeGroup.setOnCheckedChangeListener(new RadioGroup.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(RadioGroup group, int checkedId) {
                switch (checkedId) {
                    case R.id.rbtnSmall:
                        size = PlushSize.SMALL;
                        break;
                    case R.id.rbtnMedium:
                        size = PlushSize.MEDIUM;
                        break;
                    case R.id.rbtnBig:
                        size = PlushSize.BIG;
                        break;
                    case R.id.rbtnGiant:
                        size = PlushSize.GIANT;
                        break;
                }
                Log.d("STATE", size.toString());
            }
        });
    }

}