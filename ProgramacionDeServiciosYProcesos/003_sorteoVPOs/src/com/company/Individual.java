package com.company;

public class Individual extends Participant {
    IndividualKind kind;

    public Individual(String name, String id, IndividualKind tipo) {
        super(name, id);
        this.kind = tipo;
    }

    @Override
    public String toString() {
        return "Individual{" +
                "tipo=" + kind +
                ", name='" + name + '\'' +
                ", id='" + id + '\'' +
                '}';
    }
}
