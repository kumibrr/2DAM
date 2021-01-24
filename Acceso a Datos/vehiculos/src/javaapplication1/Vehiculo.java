/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication1;

/**
 *
 * @author israeldelabarrera
 */
public class Vehiculo {

    private String brand;
    private String model;
    private String registration;
    
    public Vehiculo(){
        this.brand = "";
        this.model = "";
        this.registration = "";
    }
    
    public Vehiculo(String brand, String model, String registration) {
        this.brand = brand;
        this.model = model;
        this.registration = registration;
    }
    
    public String getBrand() {
        return this.brand;
    }
    
    public void setBrand(String brand) {
        this.brand = brand;
    }
    
    public String getModel() {
        return this.model;
    }
    
    public void setModel(String model) {
        this.model = model;
    }
    
    public String getRegistration() {
        return this.registration;
    }
    
    public void setRegistration(String registration) {
        this.registration = registration;
    }
    
}
