package com.kumibrr.stuffedlove;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;

import com.kumibrr.stuffedlove.model.Plush;
import com.kumibrr.stuffedlove.model.PlushSize;
import com.kumibrr.stuffedlove.model.StandardPlush;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;

public class BasketActivity extends AppCompatActivity {

    public static ArrayList<Plush> items = new ArrayList<>();
    public static ArrayList<Integer> quantity = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_basket);
        initRecycler();

        findViewById(R.id.btnMakeOrder3).setOnClickListener(v -> {
            items.clear();
            quantity.clear();
            Intent intent = new Intent(BasketActivity.this, ThankyouActivity.class);
            intent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
            startActivity(intent);
        });
    }

    private void initRecycler() {
        RecyclerView v = findViewById(R.id.RecyclerBasket);
        v.setLayoutManager(new LinearLayoutManager(this));
        BasketAdapter adapter = new BasketAdapter(items, quantity);
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
        startActivity(new Intent(BasketActivity.this, MainActivity.class));
        return super.onOptionsItemSelected(item);
    }
}