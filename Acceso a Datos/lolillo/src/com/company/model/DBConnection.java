package com.company.model;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class DBConnection {
    private Connection connection;
    private static DBConnection instance;

    private DBConnection() {
        try {
            Class.forName("org.mariadb.jdbc.Driver");
        } catch (ClassNotFoundException ex) {
            System.out.println(ex);
        }
        try {
            connection = DriverManager.getConnection("jdbc:mariadb://localhost:3306/lolillo", "vehiculosuser", "**ocT9idomiNqRsA!8hp");
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
    }

    public static DBConnection getInstance() {
        if (instance == null) {
            instance = new DBConnection();
        }
        return instance;
    }

    public Connection getConnection() {
        return connection;
    }
}
