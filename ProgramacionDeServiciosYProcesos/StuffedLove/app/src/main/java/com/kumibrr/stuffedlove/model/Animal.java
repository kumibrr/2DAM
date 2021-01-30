package com.kumibrr.stuffedlove.model;

import android.graphics.drawable.Drawable;
import android.net.Uri;

import com.kumibrr.stuffedlove.R;

public enum Animal {
    BEAR(R.drawable.teddy),
    GIRAFFE(R.drawable.giraffe),
    PANDA(R.drawable.panda),
    CAT(R.drawable.cat);

    private final Drawable image;

    private Animal(int resource) {
        this.image = Drawable.createFromPath(Uri.parse("android.resource:com.kumibrr.stuffedlove/" + resource).toString());
    }

    public Drawable getImage() {
        return image;
    }
}
