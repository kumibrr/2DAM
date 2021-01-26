package com.kumibrr.stuffedlove.model;

import android.graphics.drawable.Drawable;

import java.util.List;

public class CustomPlush extends Plush {
    private Animal animal;
    private List<Accessory> accessories;

    public CustomPlush(PlushSize size, Drawable image, Animal animal, Accessory... accessories) {
        super(size, image);
        this.animal = animal;
        for (Accessory accesory: accessories) {
            this.accessories.add(accesory);
        }
    }
}
