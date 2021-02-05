package com.kumibrr.stuffedlove;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.graphics.drawable.Drawable;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Adapter;
import android.widget.Button;
import android.widget.CompoundButton;

import com.kumibrr.stuffedlove.model.PlushSize;
import com.kumibrr.stuffedlove.model.StandardPlush;

import java.util.ArrayList;

public class PredeterminedOrderActivity extends AppCompatActivity {

    private ArrayList<StandardPlush> plushies = new ArrayList<>();

    public static ArrayList<StandardPlush> selectedPlushies = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_predetermined_order);
        //TODO: GET PLUSHIES FROM DATABASE
        plushies.add(new StandardPlush(PlushSize.GIANT, getDrawable(R.drawable.chopper), "Chopper"));
        plushies.add(new StandardPlush(PlushSize.GIANT, getDrawable(R.drawable.koda), "Koda"));
        initRecycler();

        Button orderBtn = (Button) findViewById(R.id.btnMakeOrder2);

        orderBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(PredeterminedOrderActivity.this, ThankyouActivity.class);
                intent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
                startActivity(intent);
            }
        });

    }

    private void initRecycler() {
        RecyclerView v = findViewById(R.id.RecyclerPredeterminedPlushies);
        v.setLayoutManager(new LinearLayoutManager(this));
        PredeterminedOrderAdapter adapter = new PredeterminedOrderAdapter(plushies);
        v.setAdapter(adapter);
    }

}