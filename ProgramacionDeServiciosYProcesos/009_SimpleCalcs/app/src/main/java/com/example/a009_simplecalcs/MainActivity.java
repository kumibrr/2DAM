package com.example.a009_simplecalcs;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        EditText n1 = findViewById(R.id.inFirstNumber);
        EditText n2 = findViewById(R.id.inFirstNumber);

        Button add = findViewById(R.id.btnAddNumbers);
        Button substract = findViewById(R.id.btnSubstractNumbers);

        TextView txtResult = findViewById(R.id.txtResult);
        
    }
}