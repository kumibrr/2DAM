package com.example.vehiculos;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import com.example.vehiculos.model.Vehiculo;

import java.util.ArrayList;

public class DBAccess {
    private SQLiteOpenHelper openHelper;
    private SQLiteDatabase database;
    private static DBAccess instance;
    private ArrayList<Vehiculo> vehiculos = new ArrayList<>();


    private DBAccess(Context context) {
        this.openHelper = new DBOpenHelper(context);
        open();
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

    public Vehiculo getVehiculo(int index) {
        return vehiculos.get(index);
    }

    public ArrayList<Vehiculo> getVehiculos() {
        vehiculos.clear();
        Cursor cursor = database.rawQuery("SELECT * FROM vehiculo;", null);
        cursor.moveToFirst();
        while (!cursor.isAfterLast()) {
            vehiculos.add(new Vehiculo(cursor.getInt(0), cursor.getString(1), cursor.getString(2), cursor.getString(3)));
            cursor.moveToNext();
        }
        cursor.close();
        return vehiculos;
    }

    public void updateVehiculo(int id, String brand, String model, String registrationId, int index) {
        SQLiteDatabase db = openHelper.getWritableDatabase();
        String query = "UPDATE vehiculo SET brand='" + brand + "', model='" + model + "', registration='" + registrationId + "' WHERE id=" + id + ";";
        db.execSQL(query);
    }

    public void deleteVehiculo(int index) {
        SQLiteDatabase db = openHelper.getWritableDatabase();
        String query = "DELETE FROM vehiculo WHERE id=" + index + ";";
        db.execSQL(query);
        vehiculos.remove(index);
    }

    public void insertVehiculo(String brand, String model, String registrationId) {
        SQLiteDatabase db = openHelper.getWritableDatabase();
        String query = "INSERT INTO vehiculo (brand, model, registration) VALUES ('"+ brand + "', '"+ model +"', '"+ registrationId +"')";
        db.execSQL(query);
    }
}
