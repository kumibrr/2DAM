package com.kumibrr.stuffedlove.model;

import android.graphics.drawable.Drawable;

import java.util.ArrayList;
import java.util.List;

public class CustomPlush extends Plush {
    private Animal animal;
    private List<Accessory> accessories;

    public CustomPlush(PlushSize size, Animal animal, ArrayList<Accessory> accessories) {
        super(size, animal.getImage());
        this.animal = animal;
        for (Accessory accesory: accessories) {
            if (this.accessories != null) {
                this.accessories.add(accesory);
            }
        }
    }
}
