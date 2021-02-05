package com.kumibrr.stuffedlove;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class AddedToShoppingList extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_added_to_shopping_list);

        Button shoppingListButton = findViewById(R.id.buttonCarrito);
        Button keepShopping = findViewById(R.id.btnGoOrder);
        shoppingListButton.setOnClickListener(shopping);
        keepShopping.setOnClickListener(order);

    }

    View.OnClickListener shopping = v -> {
        Intent intent = new Intent(AddedToShoppingList.this, BasketActivity.class);
        intent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
        startActivity(intent);
    };

    View.OnClickListener order = v -> {
        Intent intent = new Intent(AddedToShoppingList.this, OrderActivity.class);
        intent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
        startActivity(intent);
    };
}