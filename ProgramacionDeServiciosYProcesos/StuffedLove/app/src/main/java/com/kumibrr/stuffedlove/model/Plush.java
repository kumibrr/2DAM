package com.kumibrr.stuffedlove.model;

import android.graphics.drawable.Drawable;

public abstract class Plush {
    private PlushSize size;
    private int imageID;

    public Plush(PlushSize size, int imageID) {
        this.size = size;
        this.imageID = imageID;
    }

    public PlushSize getSize() {
        return size;
    }

    public void setSize(PlushSize size) {
        this.size = size;
    }

    public int getImageID() {
        return imageID;
    }

    public void setImageID(int image) {
        this.imageID = image;
    }
}
