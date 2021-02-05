package com.kumibrr.stuffedlove.model;

import android.graphics.drawable.Drawable;
import android.net.Uri;

import com.kumibrr.stuffedlove.R;

public enum Animal {
    BEAR(R.drawable.teddy),
    GIRAFFE(R.drawable.giraffe),
    PANDA(R.drawable.panda),
    CAT(R.drawable.cat);

    private final int image;

    private Animal(int resource) {
        this.image = resource;
    }

    public int getImage() {
        return image;
    }
}
