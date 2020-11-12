package com.company;

import java.time.LocalDate;

public abstract class Person implements Comparable<Person> {
    private final String dni;
    private final Country country;
    private final ShipArea shipArea;
    private final String name;
    private final LocalDate birthDate;
    private boolean hasDisability;

    public Person(
            String dni, Country country, ShipArea shipArea, String name, int birthDay, int birthMonth,
            int birthYear, boolean hasDisability
    ) {
        this.dni = dni;
        this.country = country;
        this.shipArea = shipArea;
        this.name = name;
        this.birthDate = LocalDate.of(birthYear, birthMonth, birthDay);
        this.hasDisability = hasDisability;
    }

    public Person(String dni) {
        this.dni = dni;
        this.country = null;
        this.shipArea = null;
        this.name = null;
        this.birthDate = null;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Person person = (Person) o;
        return dni.equals(person.dni);
    }

    @Override
    public String toString() {
        return  "dni='" + dni + '\'' +
                ", country=" + country +
                ", shipArea=" + shipArea +
                ", name='" + name + '\'' +
                ", birthDate=" + birthDate
                + ", ";
    }

    @Override
    public int compareTo(Person o) {
        return dni.compareTo(o.dni);
    }

    public boolean isChildren() {
        if (this.birthDate.getYear() > LocalDate.now().getYear() - 18) {
            return true;
        }
        return false;
    }

    public boolean isElder() {
        if (this.birthDate.getYear() < LocalDate.now().getYear() - 65) {
            return true;
        }
        return false;
    }

    public boolean isHandicapped() {
        return this.hasDisability;
    }

    public ShipArea getShipArea() {
        return shipArea;
    }
}
