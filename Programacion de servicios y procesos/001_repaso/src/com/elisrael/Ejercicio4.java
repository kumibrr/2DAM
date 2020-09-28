package com.elisrael;

public class Ejercicio4 {
    public static void compararArrays() {
        int[] arr1 = {1,2,3};
        int[] arr2 = {1,3,3};

        if (arr1.length == arr2.length) {
            int notEqual = 0;
            for (int i = 0; i < arr1.length; i++) {
                if (arr1[i] != arr2[i]) {
                    notEqual++;
                }
            }
            if (notEqual > 0) {
                System.out.println("NOT EQUAL");
            } else {
                System.out.println("EQUAL");
            }
        } else {
            System.out.println("NOT EQUAL");
        }
    }
}
