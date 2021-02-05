package com.kumibrr.stuffedlove;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.graphics.drawable.Drawable;
import android.net.Uri;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Adapter;
import android.widget.Button;
import android.widget.CompoundButton;

import com.kumibrr.stuffedlove.model.PlushSize;
import com.kumibrr.stuffedlove.model.StandardPlush;

import java.util.ArrayList;

public class PredeterminedOrderActivity extends AppCompatActivity {

    private ArrayList<StandardPlush> plushies;

    public static ArrayList<StandardPlush> selectedPlushies = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_predetermined_order);
        //TODO: GET PLUSHIES FROM DATABASE
        DBAccess dbAccess = DBAccess.getInstance(this);
        dbAccess.open();
        plushies = dbAccess.getPlushies(this);
        dbAccess.close();
        initRecycler();

        Button orderBtn = (Button) findViewById(R.id.btnMakeOrder2);

        orderBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                for (StandardPlush p: selectedPlushies) {
                    BasketActivity.items.add(p);
                    BasketActivity.quantity.add(1);
                }
                Intent intent = new Intent(PredeterminedOrderActivity.this, BasketActivity.class);
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

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.toolbar, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        startActivity(new Intent(PredeterminedOrderActivity.this, BasketActivity.class));
        return super.onOptionsItemSelected(item);
    }

}