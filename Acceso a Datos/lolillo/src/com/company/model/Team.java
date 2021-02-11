package com.company.model;

public class Team {
    private int id;
    private String name;
    private Region region;
    private int championships;

    public Team(int id, String name, String region, int championships) {
        this.id = id;
        this.name = name;
        this.region = Region.getRegion(region);
        this.championships = championships;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Region getRegion() {
        return region;
    }

    public void setRegion(Region region) {
        this.region = region;
    }

    public int getChampionships() {
        return championships;
    }

    public void setChampionships(int championships) {
        this.championships = championships;
    }
}
