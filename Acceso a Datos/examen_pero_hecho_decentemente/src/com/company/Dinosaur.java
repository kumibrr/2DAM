package com.company;

import java.time.LocalDate;

public abstract class Dinosaur {
    protected String species;
    protected Period period;
    protected LocalDate dateFound;

    public Dinosaur(String species, Period period, LocalDate dateFound) {
        this.dateFound = dateFound;
        this.species = species;
        this.period = period;
    }
}
