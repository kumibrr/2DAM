package com.company.model;

import java.util.ArrayList;
import java.util.List;

public class MockDAOTeam extends DAOTeam {

    List<Team> teams;

    public MockDAOTeam() {
        super();
        teams = new ArrayList<>();
    }

    @Override
    public List<Team> getTeams() {
        teams.add(new Team(0,"test", "EU", 0));
        teams.add(new Team(1,"test1", "KR", 1));
        teams.add(new Team(2,"test2", "CN", 2));
        teams.add(new Team(3,"test3", "NA", 3));

        return teams;
    }

    @Override
    public boolean insertTeam(Team team) {
        teams.add(team);
        return true;
    }
}