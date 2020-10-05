package com.elisrael;

import java.util.Scanner;

public class Ejercicio1 {
    static public void loopear() {
        // 1. Escribir un bucle equivalente al del siguiente programa sin utilizar el operador &&.

        int lim = 10;
        int c;

        Scanner scanner = new Scanner(System.in);

        /*
        for (int i = 0; i < lim && c != 0; i++, c = scanner.nextInt()) {

        }
         */
        int i = 0;
        do {
            c = scanner.nextInt();
            i++;
            if (i > lim) {
                break;
            }
        } while (c != 0);
    }
}
