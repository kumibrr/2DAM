package com.example.a007_introandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button button2 = findViewById(R.id.button2);
        button2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                TextView txt = findViewById(R.id.myText);
                txt.setText(R.string.greeting);
            }
        });
    }
    /*
    public void greet(View view) {
        TextView txt = findViewById(R.id.myText);
        txt.setText(R.string.greeting);
    }
    */

}