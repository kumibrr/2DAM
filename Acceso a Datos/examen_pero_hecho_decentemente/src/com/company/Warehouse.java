package com.company;

import java.util.concurrent.SynchronousQueue;

public class Warehouse {
    private static Warehouse warehouse = null;
    SynchronousQueue<Dinosaur> fossils = new SynchronousQueue<>();

    private Warehouse() {

    }

    public static Warehouse getInstance() {
        if (warehouse == null) {
            warehouse = new Warehouse();
        }
        return warehouse;
    }
}
