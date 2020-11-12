package com.company;

import java.util.TreeMap;

public class BoatDAO {
    public static TreeMap<Integer, Boat> getBoats() {

        TreeMap<Integer, Boat> r = new TreeMap<>();

        Boat boat = new Boat(5, ShipArea.BOW);
        r.put(boat.getId(), boat);

        boat = new Boat(5, ShipArea.PORT);
        r.put(boat.getId(), boat);

        boat = new Boat(5, ShipArea.STARBOARD);
        r.put(boat.getId(), boat);

        boat = new Boat(5, ShipArea.STERN);
        r.put(boat.getId(), boat);

        boat = new Boat(3, ShipArea.BOW);
        r.put(boat.getId(), boat);


        return r;
    }
}
