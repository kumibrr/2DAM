package com.company;

import java.util.ArrayList;

public class DinosaurController {
    ArrayList<Museum> museums = new ArrayList<>();
    Warehouse warehouse = Warehouse.getInstance();

    public DinosaurController(Museum... museums) {
        for (Museum museum: museums) {
            this.museums.add(museum);
        }
    }

    @Override
    public String toString() {
        return "DinosaurController{\n" +
                "museums=" + museums +
                "\n warehouse=" + warehouse +
                '}';
    }
}
