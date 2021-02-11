package com.company.model;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;

public class DAOTeam {
    private static DAOTeam instance;
    private Connection connection;
    private ArrayList<Team> teams = new ArrayList<>();

    private DAOTeam() {
        this.connection = DBConnection.getInstance().getConnection();
    }

    public boolean insertTeam(Team team) {
        boolean r = false;
        try {
            Statement statement = connection.createStatement();
            ResultSet rs = statement.executeQuery("INSERT INTO teams (name, region, championships) VALUES ('" + team.getName() + "','" + team.getRegion().getStr() + "'," + team.getChampionships() + ") RETURNING id");
            while (rs.next()) {
                team.setId(rs.getInt("id"));
                teams.add(team);
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return r;
    }

    public boolean deleteTeam(Team team) {
        boolean r = false;
        try {
            Statement statement = connection.createStatement();
            r = statement.execute("DELETE FROM teams WHERE id= "+ team.getId() + " RETURNING id");
            teams.remove(team);
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return r;
    }

    public boolean deleteTeams(List<Team> teams) {
        boolean r = false;
        String query = "DELETE FROM teams WHERE (id) IN (";
        for (int i = 0; i < teams.size(); i++) {
            if (i != 0) {
                query += "," + teams.get(i).getId();
            } else {
                query += teams.get(i).getId();
            }
        }
        query += ") RETURNING id";

        try {
            Statement statement = connection.createStatement();
            r = statement.execute(query);
            for (Team team: teams) {
                this.teams.remove(team);
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return r;
    }

    public Team getTeamFromDB(String name) {
        Team team = null;
        try {
            Statement statement = connection.createStatement();
            ResultSet r = statement.executeQuery("SELECT * FROM teams WHERE name='" + name + "'");

            while (r.next()) {
                team = new Team(r.getInt("id"), r.getString("name"), r.getString("region"), r.getInt("championships"));
            }

        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return team;
    }

    public Team getTeam(int teamId) {
        for (Team t: teams) {
            if (t.getId() == teamId) {
                return t;
            }
        }
        return null;
    }

    public List<Team> getTeams() {
        try {
            Statement statement = connection.createStatement();
            ResultSet r = statement.executeQuery("SELECT * FROM teams");

            while (r.next()) {
                Team team = new Team(r.getInt("id"), r.getString("name"), r.getString("region"), r.getInt("championships"));
                teams.add(team);
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return teams;
    }

    public static DAOTeam getInstance() {
        if (instance == null) {
            instance = new DAOTeam();
        }
        return instance;
    }
}
