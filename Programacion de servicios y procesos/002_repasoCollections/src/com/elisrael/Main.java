package com.elisrael;

public class Main {

    public static void main(String[] args) throws InterruptedException {
        GestionColas g = new GestionColas();
        System.out.println(g.firstQueue.toString());
        System.out.println("***********************************");
        System.out.println(g.secondQueue.toString());
        System.out.println("***********************************");
        System.out.println(g.thirdQueue.toString());
        System.out.println("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
        Thread t = new Thread(g);
        t.start();
        g.play();
        System.out.println("***********************************");
        System.out.println(g.firstQueue.toString());
        System.out.println("***********************************");
        System.out.println(g.secondQueue.toString());
        System.out.println("***********************************");
        System.out.println(g.thirdQueue.toString());
    }
}
