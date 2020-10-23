package com.company;

import java.util.TreeMap;

public class Main {

    public static void main(String[] args) {
        TreeMap<Integer, Boat> b = BoatDAO.getBoats();

	    System.out.println();
    }
}
