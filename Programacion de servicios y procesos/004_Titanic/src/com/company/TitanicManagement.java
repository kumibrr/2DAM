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
                

            }
        }
    }

    public void evacuate() {
        classifyPeople();
        allocateToBoat();

    }

    public Passenger[] getChild(ShipArea location) {
        // returns an array: child and adult.
        Passenger[] childAndCompanion = new Passenger[2];
        for(Passenger kid: kids) {
            if (kid.getShipArea().equals(location)) {
                childAndCompanion[0] = getChildCompanion(kid.getCabinNumber());
                childAndCompanion[1] = kid;
                kids.remove(kid);
            }
        }
        return childAndCompanion;
    }

    public boolean theresPeopleInShip() {
        return kids.size() > 0 && elders.size() > 0 && handicapped.size() > 0 && adults.size() > 0 && crew.size() > 0;
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
