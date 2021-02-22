package com.example.vehiculos;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;

public class InsertVehiculo extends AppCompatActivity {

    DBAccess dbAccess;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_insert_vehiculo);

        dbAccess = DBAccess.getInstance(this);

        Button insertBtn = findViewById(R.id.insertButton);
        EditText brand = findViewById(R.id.txtMarca);
        EditText model = findViewById(R.id.txtModelo);
        EditText registration = findViewById(R.id.txtMatricula);

        insertBtn.setOnClickListener(v -> {
            dbAccess.insertVehiculo(brand.getText().toString(), model.getText().toString(), registration.getText().toString());
            Intent intent = new Intent(this, VehiculosActivity.class);
            intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
            startActivity(intent);
        });
    }
}