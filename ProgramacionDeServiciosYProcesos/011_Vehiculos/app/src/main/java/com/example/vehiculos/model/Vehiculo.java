package com.example.vehiculos.model;

public class Vehiculo {
    private int id;
    private String brand;
    private String model;
    private String registrationId;

    public Vehiculo(int id, String brand, String model, String registrationId) {
        this.id = id;
        this.registrationId = registrationId;
        this.model = model;
        this.brand = brand;
    }

    public int getId() {
        return id;
    }

    public String getBrand() {
        return brand;
    }

    public String getModel() {
        return model;
    }

    public String getRegistrationId() {
        return registrationId;
    }
}
