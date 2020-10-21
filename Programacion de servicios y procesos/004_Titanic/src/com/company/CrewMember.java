package com.company;

public class CrewMember extends Person {

    CrewResponsability responsability;

    public CrewMember(
            String dni, Country country, ShipArea shipArea, String name, int birthDay, int birthMonth, int birthYear,
            CrewResponsability responsability
    ) {
        super(dni, country, shipArea, name, birthDay, birthMonth, birthYear);

        this.responsability = responsability;
    }
}
