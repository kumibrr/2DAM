package com.company;

import java.time.LocalDate;
import java.util.Objects;

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
        this.birthDate = LocalDate.of(birthYear, birthMonth, birthDay);
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Person person = (Person) o;
        return dni.equals(person.dni);
    }

    @Override
    public int hashCode() {
        return Objects.hash(dni);
    }

    @Override
    public String toString() {
        return "Person{" +
                "dni='" + dni + '\'' +
                ", country=" + country +
                ", shipArea=" + shipArea +
                ", name='" + name + '\'' +
                ", birthDate=" + birthDate +
                '}';
    }
}
