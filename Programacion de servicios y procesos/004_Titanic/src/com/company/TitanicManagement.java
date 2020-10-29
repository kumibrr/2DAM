package com.company;

import com.sun.tools.jconsole.JConsoleContext;

import java.util.Map;
import java.util.TreeMap;

public class TitanicManagement {
    private Map<Person, Person> peopleMap;
    private Map<Integer, Boat> boatsMap;

    public TitanicManagement(){
        boatsMap = BoatDAO.getBoats();
        peopleMap = PeopleDAO.getData();
    }

    public void Callout() {
        System.out.println(boatsMap.toString());
        for (Map.Entry<Person, Person> p: peopleMap.entrySet()) {
            System.out.println(p.getValue().toString());
        }
    }

}
