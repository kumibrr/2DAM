package com.kumibrr.stuffedlove;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class OrderActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_order);

        Button favourite = (Button) findViewById(R.id.btnFavourite);
        Button custom = (Button) findViewById(R.id.btnCustom);
        Button prefab = (Button) findViewById(R.id.btnPrefab);

//        favourite.setOnClickListener(new View.OnClickListener() {
//            @Override
//            public void onClick(View v) {
//                startActivity(new Intent(OrderActivity.this, OrderActivity.class));
//            }
//        });

        custom.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(OrderActivity.this, CustomizedOrderActivity.class));
            }
        });

        prefab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(OrderActivity.this, PredeterminedOrderActivity.class));
            }
        });

    }
}