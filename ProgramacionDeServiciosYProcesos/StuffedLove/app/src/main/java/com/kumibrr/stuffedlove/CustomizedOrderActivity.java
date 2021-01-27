package com.kumibrr.stuffedlove;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.service.controls.Control;
import android.util.Log;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CompoundButton;
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

public class CustomizedOrderActivity extends CoreActivity {

    private PlushSize size;
    private Animal animal;
    private ArrayList<Accessory> accessories = new ArrayList<>();
    private ArrayList<CompoundButton> selectedAccesories = new ArrayList<>();
    private CompoundButton selectedAnimal;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_customized_order);

        Button makeOrder = (Button) findViewById(R.id.btnMakeOrder);
        RadioGroup sizeGroup = (RadioGroup) findViewById(R.id.radiogroupSize);
        RadioButton radioBear = (RadioButton) findViewById(R.id.rbtnBear);
        RadioButton radioGiraffe = (RadioButton) findViewById(R.id.rbtnGiraffe);
        RadioButton radioPanda = (RadioButton) findViewById(R.id.rbtnPanda);
        RadioButton radioCat = (RadioButton) findViewById(R.id.rbtnCat);
        CheckBox dress = (CheckBox) findViewById(R.id.chkDress);
        CheckBox suit = (CheckBox) findViewById(R.id.chkSuit);
        CheckBox bag = (CheckBox) findViewById(R.id.chkBag);
        CheckBox suitcase = (CheckBox) findViewById(R.id.chkSuitcase);

        makeOrder.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Intent intent = new Intent(CustomizedOrderActivity.this, ThankyouActivity.class);
                intent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
                startActivity(intent);
            }
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

    CompoundButton.OnCheckedChangeListener OnCheckBoxCheckedChangeListener = new CompoundButton.OnCheckedChangeListener() {
        @Override
        public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
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
        }
    };

}