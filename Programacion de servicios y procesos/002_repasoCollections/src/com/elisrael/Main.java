package com.elisrael;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) throws InterruptedException {
       /* GestionColas g = new GestionColas();
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
        System.out.println("***********************************");
        System.out.println(g.onInit.toString());
        System.out.println("***********************************");
        System.out.println(g.onExec.toString());
        */

        ArrayList<String> students = new ArrayList<String>();
        students.add("Alberto Camela");
        students.add("Armando bulla");
        students.add("benito elcamelas");
        students.add("fernando flo");
        students.add("Alex elcapo");
        students.add("felipe girocompleto");

        sortAndSanitize(students);
    }

    public static void sortAndSanitize(ArrayList<String> students) {
        for (int i = 0; i < students.size(); i++) {
            String[] stu = students.get(i).split("\\s+");
            System.out.println(stu[0]);
            System.out.println(stu[1]);
        }
    }
}
