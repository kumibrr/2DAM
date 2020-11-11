package com.company;

public class Boat {
    private static int autoAdd = 1;
    private int id;
    private int capacity;
    private ShipArea location;
    private Person[] peopleAlocated = new Person[capacity];
    private int peopleAlocatedInd = 0;

    public Boat(int capacity, ShipArea location) {
        this.id = autoAdd;  autoAdd++;
        this.capacity = capacity;
        this.location = location;
    }

    public void add(Person person) {
        this.peopleAlocated[peopleAlocatedInd] = person;
        peopleAlocatedInd++;
    }

    public int getSeatsAvailable() {
        return capacity - peopleAlocatedInd + 1;
    }

    public int getId() {
        return id;
    }

    public ShipArea getLocation() {
        return location;
    }

    public String toString() {
        return "\tcapacidad: " + capacity + "\tLugar: " + location;
    }
}
