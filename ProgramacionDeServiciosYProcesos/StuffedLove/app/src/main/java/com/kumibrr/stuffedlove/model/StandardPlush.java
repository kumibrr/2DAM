package com.kumibrr.stuffedlove.model;

import android.graphics.drawable.Drawable;

public class StandardPlush extends Plush {
    private String name;

    public StandardPlush(PlushSize size, Drawable image, String name) {
        super(size, image);
        this.name = name;
    }
}
