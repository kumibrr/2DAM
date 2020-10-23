package com.company;

import java.util.Map;

public class TitanicManagement {
    private Map<Person, Person> peopleMap;
    private Map<Integer, Boat> boatsMap;

    public TitanicManagement(){
        boatsMap = BoatDAO.getBoats();
        peopleMap = PeopleDAO.getData();
    }

    public void printShit() {
        peopleMap.toString();
    }

}
