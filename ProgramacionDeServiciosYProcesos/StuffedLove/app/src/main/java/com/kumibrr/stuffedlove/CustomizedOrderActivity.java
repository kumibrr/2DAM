package com.kumibrr.stuffedlove;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.service.controls.Control;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.ImageView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Toast;

import com.kumibrr.stuffedlove.model.Accessory;
import com.kumibrr.stuffedlove.model.Animal;
import com.kumibrr.stuffedlove.model.CustomPlush;
import com.kumibrr.stuffedlove.model.Plush;
import com.kumibrr.stuffedlove.model.PlushSize;

import java.util.ArrayList;
import java.util.List;

public class CustomizedOrderActivity extends AppCompatActivity {

    private PlushSize size;
    private Animal animal;
    private ArrayList<Accessory> accessories = new ArrayList<>();
    private ArrayList<CompoundButton> selectedAccesories = new ArrayList<>();
    private CompoundButton selectedAnimal;

    private RadioButton radioBear;
    RadioButton radioGiraffe;
    RadioButton radioPanda;
    RadioButton radioCat;
    CheckBox dress;
    CheckBox suit;
    CheckBox bag;
    CheckBox suitcase;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_customized_order);

        Button makeOrder = (Button) findViewById(R.id.btnMakeOrder);
        RadioGroup sizeGroup = findViewById(R.id.radiogroupSize);
        radioBear = findViewById(R.id.rbtnBear);
        radioGiraffe = findViewById(R.id.rbtnGiraffe);
        radioPanda = findViewById(R.id.rbtnPanda);
        radioCat = findViewById(R.id.rbtnCat);
        dress = findViewById(R.id.chkDress);
        suit = findViewById(R.id.chkSuit);
        bag = findViewById(R.id.chkBag);
        suitcase = findViewById(R.id.chkSuitcase);
        ImageView imgBear = findViewById(R.id.imgBear);
        ImageView imgGiraffe = findViewById(R.id.imgGiraffe);
        ImageView imgPanda = findViewById(R.id.imgPanda);
        ImageView imgCat = findViewById(R.id.imgCat);
        ImageView imgDress = findViewById(R.id.imgDress);
        ImageView imgSuit = findViewById(R.id.imgSuit);
        ImageView imgBag = findViewById(R.id.imgBag);
        ImageView imgSuitcase = findViewById(R.id.imgSuitcase);

        makeOrder.setOnClickListener(v -> {
            BasketActivity.items.add(new CustomPlush(size, animal, accessories));
            BasketActivity.quantity.add(1);

            Intent intent = new Intent(CustomizedOrderActivity.this, BasketActivity.class);
            intent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
            startActivity(intent);
        });

        sizeGroup.setOnCheckedChangeListener(new RadioGroup.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(RadioGroup group, int checkedId) {
                switch (checkedId) {
                    case R.id.rbtnSmall:
                        size = PlushSize.SMALL;
                        break;
                    case R.id.rbtnMedium:
                        size = PlushSize.MEDIUM;
                        break;
                    case R.id.rbtnBig:
                        size = PlushSize.BIG;
                        break;
                    case R.id.rbtnGiant:
                        size = PlushSize.GIANT;
                        break;
                }
                Log.d("SIZE", size.toString());
            }
        });

        radioBear.setOnCheckedChangeListener(OnRadioButtonCheckedListener);
        radioGiraffe.setOnCheckedChangeListener(OnRadioButtonCheckedListener);
        radioPanda.setOnCheckedChangeListener(OnRadioButtonCheckedListener);
        radioCat.setOnCheckedChangeListener(OnRadioButtonCheckedListener);
        dress.setOnCheckedChangeListener(OnCheckBoxCheckedChangeListener);
        suit.setOnCheckedChangeListener(OnCheckBoxCheckedChangeListener);
        bag.setOnCheckedChangeListener(OnCheckBoxCheckedChangeListener);
        suitcase.setOnCheckedChangeListener(OnCheckBoxCheckedChangeListener);
        imgBear.setOnClickListener(imageViewOnClickListener);
        imgGiraffe.setOnClickListener(imageViewOnClickListener);
        imgPanda.setOnClickListener(imageViewOnClickListener);
        imgCat.setOnClickListener(imageViewOnClickListener);
        imgDress.setOnClickListener(imageViewOnClickListener);
        imgSuit.setOnClickListener(imageViewOnClickListener);
        imgBag.setOnClickListener(imageViewOnClickListener);
        imgSuitcase.setOnClickListener(imageViewOnClickListener);

    }

    CompoundButton.OnCheckedChangeListener OnRadioButtonCheckedListener = new CompoundButton.OnCheckedChangeListener() {

        @Override
        public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
            if (selectedAnimal != null) {
                selectedAnimal.setChecked(false);
            }
            selectedAnimal = buttonView;

            switch (buttonView.getId()) {
                case R.id.rbtnBear:
                    animal = Animal.BEAR;
                    break;
                case R.id.rbtnGiraffe:
                    animal = Animal.GIRAFFE;
                    break;
                case R.id.rbtnPanda:
                    animal = Animal.PANDA;
                    break;
                case R.id.rbtnCat:
                    animal = Animal.CAT;
                    break;
            }
        }
    };

    CompoundButton.OnCheckedChangeListener OnCheckBoxCheckedChangeListener = (buttonView, isChecked) -> {
        if (selectedAccesories.indexOf(buttonView) == -1) {
            selectedAccesories.add(buttonView);
            switch (buttonView.getId()) {
                case R.id.chkDress:
                    accessories.add(Accessory.DRESS);
                    break;
                case R.id.chkBag:
                    accessories.add(Accessory.BAG);
                    break;
                case R.id.chkSuit:
                    accessories.add(Accessory.SUIT);
                    break;
                case R.id.chkSuitcase:
                    accessories.add(Accessory.SUITCASE);
                    break;
            }
        } else {
            selectedAccesories.remove(selectedAccesories.indexOf(buttonView));
            switch (buttonView.getId()) {
                case R.id.chkDress:
                    accessories.remove(Accessory.DRESS);
                    break;
                case R.id.chkBag:
                    accessories.remove(Accessory.BAG);
                    break;
                case R.id.chkSuit:
                    accessories.remove(Accessory.SUIT);
                    break;
                case R.id.chkSuitcase:
                    accessories.remove(Accessory.SUITCASE);
                    break;
            }
        }
        Log.d("ACCESORIES_ENUM", accessories.toString());
        Log.d("ACCESORIES_VIEW", selectedAccesories.toString());
    };

    View.OnClickListener imageViewOnClickListener = v -> {
        if (v.equals(findViewById(R.id.imgBear))) {
            radioBear.toggle();
        } else if (v.equals(findViewById(R.id.imgGiraffe))) {
            radioGiraffe.toggle();
        } else if ((v.equals(findViewById(R.id.imgPanda)))) {
            radioPanda.toggle();
        } else if ((v.equals(findViewById(R.id.imgCat)))) {
            radioCat.toggle();
        } else if ((v.equals(findViewById(R.id.imgDress)))) {
            dress.toggle();
        } else if ((v.equals(findViewById(R.id.imgSuit)))) {
            suit.toggle();
        } else if ((v.equals(findViewById(R.id.imgBag)))) {
            bag.toggle();
        } else if ((v.equals(findViewById(R.id.imgSuitcase)))) {
            suitcase.toggle();
        }
    };

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.toolbar, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        startActivity(new Intent(CustomizedOrderActivity.this, BasketActivity.class));
        return super.onOptionsItemSelected(item);
    }

}