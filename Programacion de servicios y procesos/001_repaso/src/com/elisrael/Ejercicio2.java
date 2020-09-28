package com.elisrael;

import java.util.Scanner;

public class Ejercicio2 {
    public static void isPrime() {
        Scanner scanner = new Scanner(System.in);

        int n = scanner.nextInt();
        int oc = 0;
        for (int i = 1; i <= n; i++) {
            if ((n & i) == 0) {
                oc++;
            }
        }

        if (oc > 2) {
            System.out.println("No primo");
        } else {
            System.out.println("primo");
        }

    }
}
