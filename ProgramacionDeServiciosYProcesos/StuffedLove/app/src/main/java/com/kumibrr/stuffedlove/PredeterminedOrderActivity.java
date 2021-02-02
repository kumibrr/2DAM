package com.kumibrr.stuffedlove;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.graphics.drawable.Drawable;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Adapter;
import android.widget.Button;
import android.widget.CompoundButton;

import com.kumibrr.stuffedlove.model.PlushSize;
import com.kumibrr.stuffedlove.model.StandardPlush;

import java.util.ArrayList;

public class PredeterminedOrderActivity extends AppCompatActivity {

    private ArrayList<StandardPlush> plushies = new ArrayList<>();

    private ArrayList<CompoundButton> selectedPlushies = new ArrayList<>();

//    private CheckBox chopper;
//    private CheckBox koda;
//    private CheckBox ori;
//    private CheckBox revali;
//    private CheckBox bokoblin;
//    private CheckBox doctorBear;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_predetermined_order);
        plushies.add(new StandardPlush(PlushSize.GIANT, getDrawable(R.drawable.chopper), "Chopper"));
        plushies.add(new StandardPlush(PlushSize.GIANT, getDrawable(R.drawable.koda), "Koda"));
        initRecycler();

//        chopper = findViewById(R.id.chkChopper);
//        koda = findViewById(R.id.chkKoda);
//        ori = findViewById(R.id.chkOri);
//        revali = findViewById(R.id.chkRevali);
//        bokoblin = findViewById(R.id.chkBokoblin);
//        doctorBear = findViewById(R.id.chkDoctor);
//        ImageView imgChopper = findViewById(R.id.imgChopper);
//        ImageView imgKoda = findViewById(R.id.imgKoda);
//        ImageView imgOri = findViewById(R.id.imgOri);
//        ImageView imgRevali = findViewById(R.id.imgRevali);
//        ImageView imgBokoblin = findViewById(R.id.imgBokoblin);
//        ImageView imgDoctorBear = findViewById(R.id.imgDoctorBear);


        Button orderBtn = (Button) findViewById(R.id.btnMakeOrder2);

        orderBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(PredeterminedOrderActivity.this, ThankyouActivity.class);
                intent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
                startActivity(intent);
            }
        });


//        imgChopper.setOnClickListener(imageViewOnClickListener);
//        imgKoda.setOnClickListener(imageViewOnClickListener);
//        imgOri.setOnClickListener(imageViewOnClickListener);
//        imgRevali.setOnClickListener(imageViewOnClickListener);
//        imgBokoblin.setOnClickListener(imageViewOnClickListener);
//        imgDoctorBear.setOnClickListener(imageViewOnClickListener);

    }

    private void initRecycler() {
        RecyclerView v = findViewById(R.id.RecyclerPredeterminedPlushies);
        v.setLayoutManager(new LinearLayoutManager(this));
        PredeterminedOrderAdapter adapter = new PredeterminedOrderAdapter(plushies);
        v.setAdapter(adapter);
    }

//    CompoundButton.OnCheckedChangeListener OnCheckBoxCheckedChangeListener = (buttonView, isChecked) -> {
//        if (selectedPlushies.indexOf(buttonView) == -1) {
//            selectedPlushies.add(buttonView);
//            switch (buttonView.getId()) {
//                case R.id.chkChopper:
//                    selectedPlushies.add(new StandardPlush());
//                    break;
//                case R.id.chkKoda:
//                    selectedPlushies.add(new StandardPlush());
//                    break;
//                case R.id.chkOri:
//                    selectedPlushies.add(new StandardPlush());
//                    break;
//                case R.id.chkRevali:
//                    selectedPlushies.add(new StandardPlush());
//                    break;
//                case R.id.chkBokoblin:
//                    selectedPlushies.add(new StandardPlush());
//                    break;
//                case R.id.chkDoctor:
//                    selectedPlushies.add(new StandardPlush());
//                    break;
//            }
//        } else {
//            selectedPlushies.remove(selectedPlushies.indexOf(buttonView));
//            switch (buttonView.getId()) {
//                case R.id.chkChopper:
//                    accessories.remove(Accessory.DRESS);
//                    break;
//                case R.id.chkKoda:
//                    accessories.remove(Accessory.BAG);
//                    break;
//                case R.id.chkOri:
//                    accessories.remove(Accessory.SUIT);
//                    break;
//                case R.id.chkRevali:
//                    accessories.remove(Accessory.SUITCASE);
//                    break;
//                case R.id.chkBokoblin:
//                    break;
//                case R.id.chkDoctor:
//                    break;
//            }
//        }
//    };

//    View.OnClickListener imageViewOnClickListener = v -> {
//        if (v.equals(findViewById(R.id.imgChopper))) {
//            chopper.toggle();
//        } else if (v.equals(findViewById(R.id.imgKoda))) {
//            koda.toggle();
//        } else if ((v.equals(findViewById(R.id.imgOri)))) {
//            ori.toggle();
//        } else if ((v.equals(findViewById(R.id.imgRevali)))) {
//            revali.toggle();
//        } else if ((v.equals(findViewById(R.id.imgBokoblin)))) {
//            bokoblin.toggle();
//        } else if ((v.equals(findViewById(R.id.imgDoctorBear)))) {
//            doctorBear.toggle();
//        }
//    };


}