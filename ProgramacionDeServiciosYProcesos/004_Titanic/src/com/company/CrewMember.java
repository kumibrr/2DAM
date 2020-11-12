package com.company;

public class CrewMember extends Person {

    CrewResponsability responsability;

    public CrewMember(
            String dni, Country country, ShipArea shipArea, String name, int birthDay, int birthMonth, int birthYear,
            CrewResponsability responsability, boolean hasDisability
    ) {
        super(dni, country, shipArea, name, birthDay, birthMonth, birthYear, hasDisability);

        this.responsability = responsability;
    }

    @Override
    public String toString() {
        return "CrewMember{" + super.toString() +
                "responsability=" + responsability +
                '}';
    }
}
