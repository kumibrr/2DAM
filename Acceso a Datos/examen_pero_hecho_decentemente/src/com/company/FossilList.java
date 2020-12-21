package com.company;

import java.util.HashMap;

public class FossilList extends HashMap<Dinosaur, Dinosaur> {

    public void insertDinosaur(Dinosaur dinosaur) throws DinoRepeException {
        if (this.containsKey(dinosaur)) {
            throw new DinoRepeException();
        } else {
            this.put(dinosaur, dinosaur);
        }
    }

    /**
     *
     * @param dinosaur to extract from the list and move.
     * @param museum if set to "NULL", the dinosaur will go to the Warehouse queue.
     */
    public void extractDinosaur(Dinosaur dinosaur, Museum museum) {
        if (museum != null) {
            this.remove(dinosaur);
            museum.fossils.put(dinosaur, dinosaur);
        } else {
            Warehouse.getInstance().fossils.add(dinosaur);
        }
    }

}
