package com.company;

public class Passenger extends Person {

    private int cabinNumber;
    private boolean hasDisability;

    public Passenger(
            String dni, Country country, ShipArea shipArea, String name, int birthDay, int birthMonth,
            int birthYear, int cabinNumber, boolean hasDisability
    ) {
        super(dni, country, shipArea, name, birthDay, birthMonth, birthYear);
        this.cabinNumber = cabinNumber;
        this.hasDisability = hasDisability;
    }
}
