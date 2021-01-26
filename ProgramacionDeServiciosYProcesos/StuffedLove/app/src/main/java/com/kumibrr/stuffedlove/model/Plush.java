package com.kumibrr.stuffedlove.model;

import android.graphics.drawable.Drawable;

public abstract class Plush {
    private PlushSize size;
    private Drawable image;

    public Plush(PlushSize size, Drawable image) {
        this.size = size;
        this.image = image;
    }
}
