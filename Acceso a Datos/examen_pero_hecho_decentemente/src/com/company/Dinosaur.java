package com.company;

import java.time.LocalDate;
import java.util.Objects;

public abstract class Dinosaur implements Comparable<Dinosaur> {
    protected String species;
    protected Period period;
    protected LocalDate dateFound;

    public Dinosaur(String species, Period period, LocalDate dateFound) {
        this.dateFound = dateFound;
        this.species = species;
        this.period = period;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Dinosaur dinosaur = (Dinosaur) o;
        return Objects.equals(species, dinosaur.species) && period == dinosaur.period;
    }

    @Override
    public int hashCode() {
        return Objects.hash(species, period, dateFound);
    }

    @Override
    public int compareTo(Dinosaur o) {
        int r = this.period.ordinal() - o.period.ordinal();
        if (r != 0) {
            return r;
        } else {
            return this.dateFound.compareTo(o.dateFound);
        }
    }

}
