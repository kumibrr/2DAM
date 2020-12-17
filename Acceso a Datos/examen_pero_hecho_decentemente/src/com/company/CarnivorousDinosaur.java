package com.company;

import java.time.LocalDate;
import java.util.ArrayList;

public class CarnivorousDinosaur extends Dinosaur {
    public ArrayList<String> favouritePrey = new ArrayList<String>();

    public CarnivorousDinosaur(String species, Period period, LocalDate dateFound, String... favouritePrey) {
        super(species, period, dateFound);
        for (String prey: favouritePrey) {
            this.favouritePrey.add(prey);
        }
    }
}

