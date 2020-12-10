package com.company;

public class Main {

    public static void main(String[] args) {
        System.out.println(sum(5, 10));
    }

    public static int sum(int j, int k) {
        if (k > j) {
            return k + sum(j,k - 1);
        } else {
            return 0;
        }
    }
}
