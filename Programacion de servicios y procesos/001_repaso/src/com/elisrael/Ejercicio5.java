package com.elisrael;

import java.util.ArrayList;

public class Ejercicio5 {

    public static int potenciaRecursiva(int number, int times) {
        times--;
        if (times == 0) {
            return number;
        } else {
            return potenciaRecursiva((number * 2),times);
        }
    }

    public static double mediaRecursiva(ArrayList<Integer> arr) {
        return mediaRecursiva(arr, 0);
    }

    private static double mediaRecursiva(ArrayList<Integer> arr, int index) {
        int r = 0;

        if (index >= arr.size() ) {
            return 0;
        } else if (index == 0) {
            double add = mediaRecursiva(arr, index++);
            add += arr.get(0);
            return add / arr.size();
        } else {
            return mediaRecursiva(arr, index++) + arr.get(index);
        }
    }


}
