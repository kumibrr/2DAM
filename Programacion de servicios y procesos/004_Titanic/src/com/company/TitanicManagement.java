package com.company;

import java.util.Map;

public class TitanicManagement {
    public Map<Person, Person> peopleMap;
    public Map<Integer, Boat> boatsMap;

    public TitanicManagement(){
        boatsMap = BoatDAO.getBoats();
        peopleMap = PeopleDAO.getData();
    }

    public void Callout() {
        for (Map.Entry<Person, Person> p: peopleMap.entrySet()) {
            System.out.println(p.getValue().toString());
        }
        // Para obtener un valor Persona en específico, hay que crear una persona con el constructor del dni.
    }

}
