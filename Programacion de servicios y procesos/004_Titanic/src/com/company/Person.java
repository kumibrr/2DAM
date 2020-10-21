package com.company;

import java.time.LocalDate;

public abstract class Person {
    private String dni;
    private Country country;
    private ShipArea shipArea;
    private String name;
    private LocalDate birthDate;

    public Person(
            String dni, Country country, ShipArea shipArea, String name, int birthDay, int birthMonth,
            int birthYear
    ) {
        this.dni = dni;
        this.country = country;
        this.shipArea = shipArea;
        this.name = name;
        this.birthDate = LocalDate.of(birthYear, birthDay, birthMonth);
    }
}
