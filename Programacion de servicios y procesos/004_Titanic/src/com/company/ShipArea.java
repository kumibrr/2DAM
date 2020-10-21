package com.company;

import java.util.ArrayList;

public enum ShipArea {
    BOW(2, 5, 7),
    STERN(12, 15, 7),
    STARBOARD(5, 9),
    PORT(1, 6);

    private ArrayList<Integer> stairs;

    private ShipArea(Integer ...numberOfStairs) {
        for (Integer stairs: numberOfStairs) {
            this.stairs.add(stairs);
        }
    }
}
