package com.company.model;

public class Match {
    private int id;
    private Team teamA;
    private Team teamB;
    private Player mvp;

    public Match(int id, Team teamA, Team teamB, Player mvp) {
        this.id = id;
        this.teamA = teamA;
        this.teamB = teamB;
        this.mvp = mvp;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Team getTeamA() {
        return teamA;
    }

    public void setTeamA(Team teamA) {
        this.teamA = teamA;
    }

    public Team getTeamB() {
        return teamB;
    }

    public void setTeamB(Team teamB) {
        this.teamB = teamB;
    }

    public Player getMvp() {
        return mvp;
    }

    public void setMvp(Player mvp) {
        this.mvp = mvp;
    }
}
