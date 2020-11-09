package com.company;

import java.util.TreeMap;

public class PeopleDAO {

    public static TreeMap<Person, Person> getData() {
        TreeMap<Person, Person> data = new TreeMap<>();
        Person p = new Passenger(
                "31509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1933,
                3,
                false
        );
        data.put(p, p);

        p = new Passenger(
                "31509234F",
                Country.SPAIN,
                ShipArea.BOW,
                "Álvaro el xabo",
                22, 12,1938,
                7,
                true
        );
        data.put(p, p);
        p = new Passenger(
                "32409322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pipo Ventura",
                22, 12,1976,
                10,
                false
        );
        data.put(p, p);
        p = new Passenger(
                "31319322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Bárbara Kzachovste",
                22, 12,1987,
                7,
                false
        );
        data.put(p, p);
        p = new Passenger(
                "31578522F",
                Country.FRANCE,
                ShipArea.STERN,
                "Pablo Rivas",
                22, 12,1945,
                7,
                false
        );
        data.put(p, p);
        p = new Passenger(
                "31554522F",
                Country.FRANCE,
                ShipArea.STERN,
                "Pep Sánchez",
                22, 12,1977,
                7,
                false
        );
        data.put(p, p);
        p = new Passenger(
                "31509578F",
                Country.ITALY,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1987,
                7,
                true
        );
        data.put(p, p);
        p = new Passenger(
                "31340022F",
                Country.ITALY,
                ShipArea.STERN,
                "Pep Sánchez",
                22, 12,1996,
                2,
                false
        );
        data.put(p, p);
        p = new Passenger(
                "41509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,2014,
                2,
                false
        );
        data.put(p, p);
        p = new Passenger(
                "51509322F",
                Country.SPAIN,
                ShipArea.PORT,
                "Pep Sánchez",
                22, 12,2008,
                2,
                false
        );
        data.put(p, p);
        p = new Passenger(
                "61509322F",
                Country.SPAIN,
                ShipArea.PORT,
                "Pep Sánchez",
                22, 12,2014,
                2,
                false
        );
        data.put(p, p);
        p = new Passenger(
                "71509322F",
                Country.SPAIN,
                ShipArea.PORT,
                "Pep Sánchez",
                22, 12,2003,
                2,
                false
        );
        data.put(p, p);
        p = new Passenger(
                "81509322F",
                Country.ENGLAND,
                ShipArea.STARBOARD,
                "Pep Sánchez",
                22, 12,2015,
                5,
                false
        );
        data.put(p, p);
        p = new Passenger(
                "91509322F",
                Country.ENGLAND,
                ShipArea.STARBOARD,
                "Pep Sánchez",
                22, 12,1968,
                5,
                false
        );
        data.put(p, p);
        p = new Passenger(
                "11509322F",
                Country.SPAIN,
                ShipArea.STARBOARD,
                "Pep Sánchez",
                22, 12,1968,
                1,
                false
        );
        data.put(p, p);
        p = new Passenger(
                "21509322F",
                Country.GREECE,
                ShipArea.STARBOARD,
                "Pep Sánchez",
                22, 12,1985,
                1,
                false
        );
        data.put(p, p);
        p = new CrewMember(
                "30509322F",
                Country.SPAIN,
                ShipArea.PORT,
                "Pep Sánchez",
                22, 12,1986,
                CrewResponsability.HIGH
        );
        data.put(p, p);
        p = new CrewMember(
                "32509322F",
                Country.GREECE,
                ShipArea.PORT,
                "Pep Sánchez",
                22, 12,1934,
                CrewResponsability.LOW
        );
        data.put(p, p);
        p = new CrewMember(
                "33509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1945,
                CrewResponsability.MEDIUM
        );
        data.put(p, p);
        p = new CrewMember(
                "34509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1976,
                CrewResponsability.MAX
        );
        data.put(p, p);
        p = new CrewMember(
                "35509322F",
                Country.SPAIN,
                ShipArea.STERN,
                "Pep Sánchez",
                22, 12,2009,
                CrewResponsability.VERY_HIGH
        );
        data.put(p, p);
        p = new CrewMember(
                "36509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1992,
                CrewResponsability.HIGH
        );
        data.put(p, p);
        p = new CrewMember(
                "37509322F",
                Country.SPAIN,
                ShipArea.BOW,
                "Pep Sánchez",
                22, 12,1975,
                CrewResponsability.HIGH
        );
        data.put(p, p);
        return data;
    }

}
