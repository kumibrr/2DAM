package com.elisrael;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {
        // Ejercicio1.loopear();
        // Ejercicio2.isPrime();
        // Ejercicio3.sumarVector();
        // Ejercicio4.compararArrays();
        ArrayList<Integer> arr = new ArrayList<Integer>();

        for (int i = 0; i < 15; i++) {
            arr.add(i);
        }

        System.out.println(Ejercicio5.mediaRecursiva(arr));
    }
}
