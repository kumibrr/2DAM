package com.company.gui;

import com.company.controllers.TableController;

import javax.swing.*;
import javax.swing.event.ChangeEvent;
import javax.swing.event.ChangeListener;
import java.awt.*;

public class MainWindow extends JFrame{
    private JPanel panel1;
    private JButton añadirButton;
    private JButton eliminarButton;
    private JTabbedPane tabbedPane1;
    private JComboBox comboBox1;
    private JTable matchTable;
    private JTable playerTable;
    private JTable teamTable;
    private JLabel stateLabel;

    public MainWindow() {
        super("Torneo WORLDS");
        setContentPane(panel1);
        stateLabel.setText("Estado: Cargando Equipos");

        TableController.inflateTable(teamTable, "daoTeam");
        stateLabel.setText("Estado: Listo");

        tabbedPane1.addChangeListener(e -> {
            int i = tabbedPane1.getSelectedIndex();
            switch (i) {
                case 0:
                    stateLabel.setText("Estado: Cargando Equipos");
                    TableController.inflateTable(teamTable, "daoTeam");
                    stateLabel.setText("Estado: Listo");
                    break;
                case 1:
                    stateLabel.setText("Estado: Cargando Jugadores");
                    TableController.inflateTable(playerTable, "daoPlayer");
                    stateLabel.setText("Estado: Listo");
                    break;
                case 2:
                    //Load matchTable
                    break;
            }
        });
    }
}
