package com.company;

import com.company.model.Vehiculo;

import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.util.List;

public class Controller {

    public static void loadTable(JTable table) {
        List<Vehiculo> vehiculos = DAOVehiculos.getInstance().getVehiculos();

        DefaultTableModel tableModel = new DefaultTableModel();
        tableModel.addColumn("Marca");
        tableModel.addColumn("Modelo");
        tableModel.addColumn("Matrícula");

        for (Vehiculo v: vehiculos) {
            Object[] vehiculoRow = new Object[3];
            vehiculoRow[0] = v.getBrand();
            vehiculoRow[1] = v.getModel();
            vehiculoRow[2] = v.getRegistration();
            tableModel.addRow(vehiculoRow);
        }
        table.setModel(tableModel);
    }

    private boolean insertVehiculo() {
        return false;
    }
}
