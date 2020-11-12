package com.company;

import java.util.Arrays;

public class Boat {
    private static int autoAdd = 1;
    private int id;
    private int capacity;
    private ShipArea location;
    private Person[] peopleAlocated;
    private int peopleAlocatedInd;

    public Boat(int capacity, ShipArea location) {
        this.id = autoAdd;  autoAdd++;
        this.capacity = capacity;
        this.location = location;
        peopleAlocatedInd = 0;
        peopleAlocated = new Person[capacity];
    }

    public void add(Person person) {
        if (peopleAlocatedInd < capacity) {
            this.peopleAlocated[peopleAlocatedInd] = person;
            this.peopleAlocatedInd++;
        }
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

    @Override
    public String toString() {
        return "Boat{" +
                "id=" + id +
                ", capacity=" + capacity +
                ", location=" + location +
                ", peopleAlocated=" + Arrays.toString(peopleAlocated) +
                ", peopleAlocatedInd=" + peopleAlocatedInd +
                '}';
    }
}
