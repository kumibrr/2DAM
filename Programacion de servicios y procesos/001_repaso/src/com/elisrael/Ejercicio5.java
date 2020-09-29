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

    public static ArrayList<Integer> contarElementos(ArrayList<Integer> numeros, int n, int i) {
        //Contar todas las ocurrencias de el mismo número en un array.

        return null;
    }
}
