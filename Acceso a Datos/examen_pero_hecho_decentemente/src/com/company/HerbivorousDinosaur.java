package com.company;

import java.time.LocalDate;

public class HerbivorousDinosaur extends Dinosaur {
    public String placeFound;

    public HerbivorousDinosaur(String species, Period period, LocalDate dateFound, String placeFound) {
        super(species, period, dateFound);
        this.placeFound = placeFound;
    }

    @Override
    public String toString() {
        return "HerbivorousDinosaur{" +
                "placeFound='" + placeFound + '\'' +
                ", species='" + species + '\'' +
                ", period=" + period +
                ", dateFound=" + dateFound +
                '}';
    }
}
