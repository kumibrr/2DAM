package com.company;

import java.util.TreeSet;

public class Museum {
    public String name;
    public FossilList fossils = new FossilList();

    public Museum(String name) {
        this.name = name;
    }

    public String dinoPresas() {
        TreeSet<String> preySet = new TreeSet<>();
        for (Dinosaur dinoKey: fossils.keySet()) {
            Dinosaur dino = fossils.get(dinoKey);
            if (dino instanceof CarnivorousDinosaur) {
                preySet.add(((CarnivorousDinosaur) dino).favouritePrey.toString());
            }
        }
        String r = "";
        for (String prey: preySet) {
            r += prey + " ";
        }

        return r;
    }
}
