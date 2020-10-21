package com.company;

public class Boat {
    private static int autoAdd = 1;
    private int id;
    private int capacity;
    private ShipArea location;

    public Boat(int capacity, ShipArea location) {
        this.id = autoAdd;  autoAdd++;
        this.capacity = capacity;
        this.location = location;
    }

}
