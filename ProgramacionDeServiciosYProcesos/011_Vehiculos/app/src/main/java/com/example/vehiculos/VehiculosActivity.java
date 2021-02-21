package com.example.vehiculos;

import android.content.Intent;
import android.os.Bundle;
import android.view.MotionEvent;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.google.android.material.floatingactionbutton.FloatingActionButton;

public class VehiculosActivity extends AppCompatActivity {
    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_vehiculos);

        RecyclerView rv = findViewById(R.id.RecyclerVehiculos);
        rv.setLayoutManager(new LinearLayoutManager(this));
        VehiculosAdapter adapter = new VehiculosAdapter(getApplicationContext());
        rv.setAdapter(adapter);

        FloatingActionButton fb = findViewById(R.id.floatingActionButton);

        fb.setOnClickListener(v -> {
            startActivity(new Intent(this, InsertVehiculo.class));
        });
    }
}
