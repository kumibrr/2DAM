package com.company;

import java.util.ArrayList;
import java.util.Map;

public class TitanicManagement {
    public Map<Person, Person> peopleMap;
    public Map<Integer, Boat> boatsMap;

    ArrayList<Passenger> kids = new ArrayList<>();
    ArrayList<Passenger> elders = new ArrayList<>();
    ArrayList<Person> handicapped = new ArrayList<>();
    ArrayList<Passenger> adults = new ArrayList<>();
    ArrayList<CrewMember> crew = new ArrayList<>();

    public TitanicManagement(){
        boatsMap = BoatDAO.getBoats();
        peopleMap = PeopleDAO.getData();
    }

    public void arrangePassengers(Person person) {
        if (person.isChildren()) {
            kids.add((Passenger) person);
        } else if (person.isElder()) {
            elders.add((Passenger) person);
        } else if (person.isHandicapped()) {
            handicapped.add(person);
        } else {
            adults.add((Passenger) person);
        }
    }

    public void classifyPeople() {
        for (Map.Entry<Person, Person> p: peopleMap.entrySet()) {
            Person person = p.getValue();

            if (person instanceof Passenger) {
                arrangePassengers(person);
            }

            if (person instanceof CrewMember) {
                CrewMember crewm = (CrewMember) person;
            }
        }
    }

    public void allocateToBoat() {
        while (theresPeopleInShip()) {
            for (Map.Entry<Integer, Boat> boatRaw: boatsMap.entrySet()) {
                Boat boat = boatRaw.getValue();
                Person[] people = getPerson(boat.getLocation());
                for (Person p: people) {
                    boat.add(p);
                }
            }
        }
    }

    public Person[] getPerson(ShipArea location) {
        if (kids.size() > 0) {
            return getChild(location);
        } else if (elders.size() > 0) {
            return getPassenger(location, elders);
        } else if (adults.size() > 0) {
            return getPassenger(location, adults);
        } else {
            return getCrew(location, crew);
        }
    }

    public void evacuate() {
        classifyPeople();
        allocateToBoat();
        for (Map.Entry<Integer, Boat> boatRaw: boatsMap.entrySet()) {
            System.out.println(boatRaw.getValue().toString());
        }
    }

    public Passenger[] getPassenger(ShipArea location, ArrayList<Passenger> p) {
        Passenger[] passengerRet = new Passenger[1];

        for (int i = p.size() - 1; i >= 0; i--) {
            if (p.get(i).getShipArea().equals(location)) {
                passengerRet[0] = p.get(i);
                p.remove(i);
            }
        }
        return passengerRet;
    }

    public CrewMember[] getCrew(ShipArea location, ArrayList<CrewMember> p) {
        CrewMember[] personRet = new CrewMember[1];

        for (int i = p.size() - 1; i >= 0; i--) {
            if (p.get(i).getShipArea().equals(location)) {
                personRet[0] = p.get(i);
                p.remove(i);
            }
        }
        return personRet;
    }

    public Passenger[] getChild(ShipArea location) {
        // returns an array: child and adult.
        Passenger[] childAndCompanion = new Passenger[2];
        for(int i = kids.size() - 1; i >= 0; i--) {
            if (kids.get(i).getShipArea().equals(location)) {
                childAndCompanion[0] = getChildCompanion(kids.get(i).getCabinNumber());
                childAndCompanion[1] = kids.get(i);
                kids.remove(i);
            }
        }
        return childAndCompanion;
    }

    public boolean theresPeopleInShip() {
        return kids.size() > 0 || elders.size() > 0 || handicapped.size() > 0 || adults.size() > 0 || crew.size() > 0;
    }

    public Passenger getChildCompanion(int cabin) {
        Passenger companion = null;

        for (Passenger elder: elders) {
            if (elder.getCabinNumber() == cabin) {
                companion = elder;
            }
        }
        for (Person disabledPerson: handicapped) {
            if (disabledPerson instanceof Passenger) {
                Passenger disabledPassenger = (Passenger) disabledPerson;
                if (disabledPassenger.getCabinNumber() == cabin) {
                    companion = disabledPassenger;
                }
            }
        }
        for (Passenger adult: adults) {
            if (adult.getCabinNumber() == cabin) {
                companion = adult;
            }
        }
        return companion;
    }

}
