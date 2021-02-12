package com.company.model;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;

public class DAOMatch {
    private static DAOMatch instance;
    private Connection connection;
    private ArrayList<Match> matches;

    private DAOMatch() { this.connection = DBConnection.getInstance().getConnection();}

    public Match insertMatch(Match match) {
        try {
            Statement statement = connection.createStatement();
            ResultSet rs = statement.executeQuery("INSERT INTO matches (teamA, teamB) VALUES ('" + match.getTeamA().getId() + "', '" + match.getTeamB().getId() + "')");
            while (rs.next()) {
                match.setId(rs.getInt("id"));
                matches.add(match);
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return match;
    }

    public boolean deleteMatch(Match match) {
        boolean r = false;
        try {
            Statement statement = connection.createStatement();
            r = statement.execute("DELETE FROM matches WHERE id="+ match.getId() +" RETURNING id");
            matches.remove(match);
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }

        return r;
    }

    public List<Match> getMatches() {
        if (matches == null) {
            matches = new ArrayList<>();
            try {
                Statement statement = connection.createStatement();
                ResultSet r = statement.executeQuery("SELECT * FROM matches");
                matches.clear();
                DAOTeam daoteam = DAOTeam.getInstance();
                DAOPlayer daoPlayer = DAOPlayer.getInstance();
                while (r.next()) {
                    Match match = new Match(r.getInt("id"), daoteam.getTeam(r.getInt("teamA")), daoteam.getTeam(r.getInt("teamB")), daoteam.getTeam(r.getInt("winner")), daoPlayer.getPlayer(r.getInt("MVP")));
                    matches.add(match);
                }
            } catch (SQLException throwables) {
                throwables.printStackTrace();
            }
        }
        return matches;
    }

    public Match getMatch(int id) {
        for (Match m: matches) {
            if (m.getId() == id) {
                return m;
            }
        }
        return null;
    }

    public boolean updateMatch(Match match) {
        boolean r = false;
        try {
            Statement statement = connection.createStatement();
            r = statement.execute("UPDATE matches SET teamA=" + match.getTeamA().getId() + " , teamB=" + match.getTeamB().getId() + ", winner=" + match.getWinner().getId() + ", MVP=" + null + " WHERE id=" + match.getId());
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return r;
    }

    public static DAOMatch getInstance() {
        if (instance == null) {
            instance = new DAOMatch();
        }
        return instance;
    }
}
