package com.kumibrr.stuffedlove;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import com.kumibrr.stuffedlove.model.PlushSize;
import com.kumibrr.stuffedlove.model.StandardPlush;

import java.util.ArrayList;

public class DBAccess {
    private SQLiteOpenHelper openHelper;
    private SQLiteDatabase database;
    private static DBAccess instance;


    private DBAccess(Context context) {
        this.openHelper = new DBOpenHelper(context);
    }

    public static DBAccess getInstance(Context context) {
        if (instance == null) {
            instance = new DBAccess(context);
        }
        return instance;
    }

    public void open() {
        this.database = openHelper.getReadableDatabase();
    }

    public void close() {
        if (database != null) {
            this.database.close();
        }
    }

    public ArrayList<StandardPlush> getPlushies(Context context) {
        ArrayList<StandardPlush> list = new ArrayList<>();
        Cursor cursor = database.rawQuery("SELECT * FROM PredeterminedPlush;", null);
        cursor.moveToFirst();
        while (!cursor.isAfterLast()) {
            list.add(new StandardPlush(PlushSize.MEDIUM, context.getResources().getIdentifier(cursor.getString(2), "drawable", context.getPackageName()), cursor.getString(1)));
            cursor.moveToNext();
        }
        cursor.close();
        return list;
    }
}