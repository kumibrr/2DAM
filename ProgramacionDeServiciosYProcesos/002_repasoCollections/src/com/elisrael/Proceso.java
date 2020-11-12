package com.elisrael;

import java.util.Random;

public class Proceso {
    Integer ID;
    Integer priority;
    Integer processingTime;
    Random rng = new Random();

    public Proceso(){
        this.ID = rng.nextInt(1000) + 1;
        this.priority = rng.nextInt(3) + 1;
        do {
            this.processingTime = rng.nextInt(2000) + 1;
        } while (processingTime < 300);
    }

    @Override
    public String toString() {
        return "Proceso{" +
                "ID=" + ID +
                ", priority=" + priority +
                ", processingTime=" + processingTime +
                '}';
    }

    public void Execute() throws InterruptedException {
        System.out.println("En ejecución: ");
        System.out.println(toString());
        Thread.sleep(processingTime);
    }
}
