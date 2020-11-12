package com.company;

public class Passenger extends Person {

    private int cabinNumber;

    public Passenger(
            String dni, Country country, ShipArea shipArea, String name, int birthDay, int birthMonth,
            int birthYear, int cabinNumber, boolean hasDisability
    ) {
        super(dni, country, shipArea, name, birthDay, birthMonth, birthYear, hasDisability);
        this.cabinNumber = cabinNumber;
    }

    @Override
    public String toString() {
        return "Passenger{" + super.toString() +
                "cabinNumber=" + cabinNumber +
                '}';
    }

    public int getCabinNumber() {
        return cabinNumber;
    }

}
