package com.company.model;

public class Vehiculo {
    private String brand;
    private String model;
    private String registration;

    public Vehiculo() {
        brand = "";
        model = "";
        registration = "";
    }

    public Vehiculo(String brand, String model, String registration) {
        this.brand = brand;
        this.model = model;
        this.registration = registration;
    }

    public String getBrand() {
        return brand;
    }

    public void setBrand(String brand) {
        this.brand = brand;
    }

    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        this.model = model;
    }

    public String getRegistration() {
        return registration;
    }

    public void setRegistration(String registration) {
        this.registration = registration;
    }
}
