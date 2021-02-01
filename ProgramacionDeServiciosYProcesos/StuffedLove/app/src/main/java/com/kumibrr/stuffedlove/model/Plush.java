package com.kumibrr.stuffedlove.model;

import android.graphics.drawable.Drawable;

public abstract class Plush {
    private PlushSize size;
    private Drawable image;

    public Plush(PlushSize size, Drawable image) {
        this.size = size;
        this.image = image;
    }

    public PlushSize getSize() {
        return size;
    }

    public void setSize(PlushSize size) {
        this.size = size;
    }

    public Drawable getImage() {
        return image;
    }

    public void setImage(Drawable image) {
        this.image = image;
    }
}
