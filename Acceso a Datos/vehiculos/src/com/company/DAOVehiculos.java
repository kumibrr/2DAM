package com.company;

import com.company.model.Vehiculo;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;

public class DAOVehiculos implements IDAOVehiculo {

    private ArrayList<Vehiculo> list = new ArrayList<>();
    private static DAOVehiculos daoVehiculos;
    private Connection connection;

    private DAOVehiculos() {
        try {
            Class.forName("org.mariadb.jdbc.Driver");
        } catch (ClassNotFoundException ex) {
            System.out.println(ex);
        }
        try {
            connection = DriverManager.getConnection("jdbc:mariadb://localhost:3306/vehiculosbd", "vehiculosuser", "**ocT9idomiNqRsA!8hp");
            Statement statement = connection.createStatement();
            parseQuery(statement.executeQuery("SELECT marca.name, modelo.name, vehiculo.matricula from vehiculo inner join (modelo, marca) on vehiculo.modelo_id = modelo.id and modelo.marca_id = marca.id_marca;"));
        } catch (SQLException throwables) {
            throwables.printStackTrace();
        }
    }

    private void parseQuery(ResultSet rs) throws SQLException {
        while (rs.next()) {
            list.add(new Vehiculo(rs.getString("name"), rs.getString("modelo.name"), rs.getString("matricula")));
        }
    }

    public static DAOVehiculos getInstance() {
        if (daoVehiculos == null) {
            daoVehiculos = new DAOVehiculos();
        }
        return daoVehiculos;
    }

    @Override
    public int insertVehiculo(Vehiculo vehiculo) {
        if (list.add(vehiculo)) {
            return 1;
        }
        return 0;
    }

    @Override
    public int removeVehiculo(Vehiculo vehiculo) {
        if (list.remove(vehiculo)) {
            return 1;
        }
        return 0;
    }

    @Override
    public int removeVehiculo(String matricula) {
        for (Vehiculo v: list) {
            if (v.getRegistration() == matricula) {
                if (list.remove(v)) {
                    return 1;
                }
            }
        }
        return 0;
    }

    @Override
    public int removeVehiculos(List<Vehiculo> lstVehiculos) {
        int r = 1;
        for (Vehiculo v: lstVehiculos) {
            if (!list.remove(v)) {
                r = 0;
            }
        }
        return r;
    }

    @Override
    public Vehiculo getVehiculo(String matricula) {
        for (Vehiculo v: list) {
            if (v.getRegistration() == matricula) {
                return v;
            }
        }
        return null;
    }

    @Override
    public List<Vehiculo> getVehiculos() {
        return list;
    }
}