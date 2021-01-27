package com.company;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.Set;
import java.util.TreeSet;

public class DinosaurController {
    ArrayList<Museum> museums = new ArrayList<>();
    Warehouse warehouse = Warehouse.getInstance();

    public DinosaurController(Museum... museums) throws DinoRepeException {
        for (Museum museum: museums) {
            museum.fossils.insertDinosaur(new HerbivorousDinosaur("Terasaurio", Period.CRETACEOUS, LocalDate.now(), "El congo belga"));
            this.museums.add(museum);
        }
    }

    @Override
    public String toString() {

        //TODO: USAR STRINGBUILDER

        String r = "DinosaurController{\n" +
                "museums=";

        for (Museum museum : museums) {
            r += "\t" + museum.name + "[";
            Set k = museum.fossils.keySet();
            Iterator<Object> it = k.iterator();
            while (it.hasNext()) {
                r += museum.fossils.get(it.next()).toString();
            }
            r += "]\n";
        }

        r += "Warehouse=[";
        r += warehouse.fossils.toString();

        return r;
    }

    public String nombresDinosaurios() {
        TreeSet<Dinosaur> dinosaurTreeset = new TreeSet<Dinosaur>();
        for (Museum museum: museums) {
            Set k = museum.fossils.keySet();
            Iterator<Object> it = k.iterator();
            while (it.hasNext()) {
                dinosaurTreeset.add(museum.fossils.get(it.next()));
            }
        }

        Dinosaur[] warehouse = (Dinosaur[]) this.warehouse.fossils.toArray();
        for (Dinosaur dino: warehouse) {
            dinosaurTreeset.add(dino);
        }

        String r = "";
        for (Dinosaur dino: dinosaurTreeset) {
            r += dino.species + "\t";
        }

        return r;
    }
}
