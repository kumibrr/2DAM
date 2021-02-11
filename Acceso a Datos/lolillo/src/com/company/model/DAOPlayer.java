package com.company.model;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;

public class DAOPlayer {
    private static DAOPlayer instance;
    private Connection connection;
    private ArrayList<Player> players = new ArrayList<>();

    private DAOPlayer() { this.connection = DBConnection.getInstance().getConnection(); }

    public boolean insertPlayer(Player player) {
        boolean r = false;
        try {
            Statement statement = connection.createStatement();
            ResultSet rs = statement.executeQuery("INSERT INTO players (firstname, lastname, nickname, position, team) VALUES ('"+ player.getFirstName() + "', '"+ player.getLastName() + "', '"+ player.getNickName() + "', '"+ player.getPosition().getStr() + "'," + player.getTeam().getId() + ")");
            while (rs.next()) {
                player.setId(rs.getInt("id"));
                players.add(player);
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return r;
    }

    public boolean deletePlayer(Player player) {
        boolean r = false;
        try {
            Statement statement = connection.createStatement();
            r = statement.execute("DELETE FROM players WHERE id= "+ player.getId() + " RETURNING id");
            players.remove(player);
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return r;
    }

    public Player getPlayerFromDB(String nickname) {
        Player player = null;
        try {
            Statement statement = connection.createStatement();
            ResultSet r = statement.executeQuery("SELECT * FROM players WHERE nickname='" + nickname + "'");

            while (r.next()) {
                player = new Player(r.getInt("id"), r.getString("firstName"), r.getString("lastName"), r.getString("nickName"), r.getString("position"), DAOTeam.getInstance().getTeam(r.getInt("team")));
            }

        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return player;
    }

    public List<Player> getPlayers() {
        try {
            Statement statement = connection.createStatement();
            ResultSet r = statement.executeQuery("SELECT * FROM players");

            while (r.next()) {
                Player player = player = new Player(r.getInt("id"), r.getString("firstName"), r.getString("lastName"), r.getString("nickName"), r.getString("position"), DAOTeam.getInstance().getTeam(r.getInt("team")));
                players.add(player);
            }
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
        return players;
    }

    public Player getPlayer(String nickName) {
        for (Player p: players) {
            if (p.getNickName() == nickName) {
                return p;
            }
        }
        return null;
    }

    public static DAOPlayer getInstance() {
        if (instance == null) {
            instance = new DAOPlayer();
        }
        return instance;
    }
}
