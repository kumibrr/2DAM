package com.example.vehiculos;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.example.vehiculos.model.Vehiculo;

public class VehiculoDetail extends AppCompatActivity {

    int index;
    DBAccess dbAccess;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_vehiculo_detail);
        dbAccess = DBAccess.getInstance(this);
        Intent intent = getIntent();
        index = intent.getIntExtra("index", 0);
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
        });

        deleteBtn.setOnClickListener(v -> {
            dbAccess.deleteVehiculo(index);
            Toast t = Toast.makeText(this, "Vehiculo eliminado correctamente", Toast.LENGTH_SHORT);
        });
    }
}