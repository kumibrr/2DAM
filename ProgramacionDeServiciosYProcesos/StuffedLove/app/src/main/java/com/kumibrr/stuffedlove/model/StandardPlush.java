package com.kumibrr.stuffedlove.model;

import android.graphics.drawable.Drawable;

public class StandardPlush extends Plush {
    private String name;

    public StandardPlush(PlushSize size, int image, String name) {
        super(size, image);
        this.name = name;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
}
