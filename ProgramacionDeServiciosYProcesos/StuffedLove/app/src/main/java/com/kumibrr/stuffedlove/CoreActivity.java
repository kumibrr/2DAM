package com.kumibrr.stuffedlove;

import android.app.Activity;
import android.os.Bundle;

import androidx.appcompat.app.AppCompatActivity;

public abstract class CoreActivity extends AppCompatActivity {

    private int layout;

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

    }

    public void setLayout(int layout) {
        this.layout = layout;
    }

    public void changeBackground() {

    }
}