package com.example.vehiculos;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.example.vehiculos.model.Vehiculo;

import java.util.concurrent.atomic.AtomicReference;

public class VehiculoDetail extends AppCompatActivity {

    int index;
    DBAccess dbAccess;
    private int DATA_HAS_BEEN_UPDATED = 0;

    @Override
    public void onBackPressed() {
        if (DATA_HAS_BEEN_UPDATED == 0) {
            super.onBackPressed();
        } else {
            dataUpdated();
        }
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_vehiculo_detail);
        dbAccess = DBAccess.getInstance(this);
        AtomicReference<Intent> intent = new AtomicReference<>(getIntent());
        index = intent.get().getIntExtra("index", 0);
        Vehiculo vehiculo = dbAccess.getVehiculo(index);

        TextView brand = findViewById(R.id.brandInput);
        TextView model = findViewById(R.id.modelInput);
        TextView registration = findViewById(R.id.registrationInput);

        brand.setText(vehiculo.getBrand());
        model.setText(vehiculo.getModel());
        registration.setText(vehiculo.getRegistrationId());

        Button updateBtn = findViewById(R.id.button);
        Button deleteBtn = findViewById(R.id.button2);

        updateBtn.setOnClickListener(v -> {
            dbAccess.updateVehiculo(vehiculo.getId(), brand.getText().toString(), model.getText().toString(), registration.getText().toString(), index);
            Toast t = Toast.makeText(this, "Vehiculo actualizado correctamente", Toast.LENGTH_SHORT);
            DATA_HAS_BEEN_UPDATED = 1;
        });

        deleteBtn.setOnClickListener(v -> {
            dbAccess.deleteVehiculo(index);
            Toast t = Toast.makeText(this, "Vehiculo eliminado correctamente", Toast.LENGTH_SHORT);
            dataUpdated();
        });


    }

    private void dataUpdated() {
        Intent intent = new Intent(this, VehiculosActivity.class);
        intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
        startActivity(intent);
    }
}