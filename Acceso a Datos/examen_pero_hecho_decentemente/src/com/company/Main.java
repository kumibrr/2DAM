package com.company;

public class Main {

    public static void main(String[] args) {
	// write your code here
        try {
            DinosaurController controller = new DinosaurController(new Museum("Aha"));
            System.out.println(controller.toString());
        } catch (Exception e) {
            System.out.println(e);
        }
    }
}
