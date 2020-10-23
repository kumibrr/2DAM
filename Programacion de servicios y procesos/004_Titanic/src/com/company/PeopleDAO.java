package com.company;

import java.util.TreeMap;

public class PeopleDAO {

    public static TreeMap<Person, Person> getData() {
        TreeMap<Person, Person> data = new TreeMap<Person, Person>();
        Person p = new Passenger(
                "31509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                3,
                true
        );
        data.put(p, p);

        p = new Passenger(
                "31509234F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pablo Pérez",
                22, 12,1933,
                3,
                true
        );

        p = new Passenger(
                "32409322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pipo ",
                22, 12,1933,
                3,
                true
        );

        p = new Passenger(
                "31319322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                3,
                true
        );

        p = new Passenger(
                "31578522F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                3,
                true
        );

        p = new Passenger(
                "31554522F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                3,
                true
        );

        p = new Passenger(
                "31509578F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                3,
                true
        );

        p = new Passenger(
                "31340022F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                3,
                true
        );

        p = new Passenger(
                "41509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                3,
                true
        );

        p = new Passenger(
                "51509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                3,
                true
        );

        p = new Passenger(
                "61509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                3,
                true
        );

        p = new Passenger(
                "71509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                3,
                true
        );

        p = new Passenger(
                "81509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                3,
                true
        );

        p = new Passenger(
                "91509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                3,
                true
        );

        p = new Passenger(
                "11509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                3,
                true
        );

        p = new Passenger(
                "21509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                3,
                true
        );

        p = new CrewMember(
                "30509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                CrewResponsability.HIGH
        );

        p = new CrewMember(
                "32509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                CrewResponsability.LOW
        );

        p = new CrewMember(
                "33509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                CrewResponsability.MEDIUM
        );

        p = new CrewMember(
                "34509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                CrewResponsability.MAX
        );

        p = new CrewMember(
                "35509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                CrewResponsability.VERY_HIGH
        );

        p = new CrewMember(
                "36509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                CrewResponsability.HIGH
        );

        p = new CrewMember(
                "37509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                CrewResponsability.HIGH
        );

        return new TreeMap<Person, Person>();
    }

}
