package com.company.gui;

import com.company.controllers.TableController;

import javax.swing.*;
import javax.swing.event.ChangeEvent;
import javax.swing.event.ChangeListener;
import javax.swing.event.TableModelEvent;
import javax.swing.event.TableModelListener;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyListener;

public class MainWindow extends JFrame{
    private JPanel panel1;
    private JButton addButton;
    private JButton deleteButton;
    private JTabbedPane tabbedPane1;
    private JTable matchTable;
    private JTable playerTable;
    private JTable teamTable;
    private JLabel stateLabel;

    public MainWindow() {
        super("Torneo WORLDS");
        setContentPane(panel1);
        TableController tableController = new TableController(this);
        stateLabel.setText("Estado: Cargando Equipos");

        tableController.inflateTable(teamTable, "daoTeam");
        teamTable.removeColumn(teamTable.getColumnModel().getColumn(0));
        stateLabel.setText("Estado: Listo");

        tabbedPane1.addChangeListener(e -> {
            int i = tabbedPane1.getSelectedIndex();
            switch (i) {
                case 0:
                    stateLabel.setText("Estado: Cargando Equipos");
                    tableController.inflateTable(teamTable, "daoTeam");
                    teamTable.removeColumn(teamTable.getColumnModel().getColumn(0));
                    stateLabel.setText("Estado: Listo");
                    break;
                case 1:
                    stateLabel.setText("Estado: Cargando Jugadores");
                    tableController.inflateTable(playerTable, "daoPlayer");
                    playerTable.removeColumn(playerTable.getColumnModel().getColumn(0));

                    playerTable.getModel().addTableModelListener(ev -> {
                        tableController.updateRow(playerTable.getModel(), "daoPlayer", ev.getFirstRow());
                    });

                    stateLabel.setText("Estado: Listo");
                    break;
                case 2:
                    stateLabel.setText("Estado: Cargando Partidas");
                    tableController.inflateTable(matchTable, "daoMatch");
                    matchTable.removeColumn(matchTable.getColumnModel().getColumn(0));

                    matchTable.getModel().addTableModelListener(ev -> {
                        tableController.updateRow(matchTable.getModel(), "daoMatch", ev.getFirstRow());
                    });

                    stateLabel.setText("Estado: Listo");
                    break;
            }
        });

        teamTable.getModel().addTableModelListener(e -> {
            tableController.updateRow(teamTable.getModel(), "daoTeam", e.getFirstRow());
        });

        deleteButton.addActionListener(e -> {
            int i = tabbedPane1.getSelectedIndex();
            switch (i) {
                case 0:
                    if (teamTable.getSelectedRow() != -1) {
                        tableController.deleteRow(teamTable.getModel(), "daoTeam", teamTable.getSelectedRow());
                        stateLabel.setText("Estado: Cargando Equipos");
                        tableController.inflateTable(teamTable, "daoTeam");
                        teamTable.removeColumn(teamTable.getColumnModel().getColumn(0));
                        stateLabel.setText("Estado: Listo");
                    } else {
                        showError("Debe seleccionar una fila para borrarla.", "Acción no permitida");
                    }
                    break;
                case 1:
                    if (playerTable.getSelectedRow() != -1) {
                        tableController.deleteRow(playerTable.getModel(), "daoPlayer", playerTable.getSelectedRow());
                        stateLabel.setText("Estado: Cargando Jugadores");
                        tableController.inflateTable(playerTable, "daoPlayer");
                        playerTable.removeColumn(playerTable.getColumnModel().getColumn(0));

                        playerTable.getModel().addTableModelListener(ev -> {
                            tableController.updateRow(playerTable.getModel(), "daoPlayer", ev.getFirstRow());
                        });

                        stateLabel.setText("Estado: Listo");
                    } else {
                        showError("Debe seleccionar una fila para borrarla.", "Acción no permitida");
                    }
                    break;
                case 2:
                    if (matchTable.getSelectedRow() != -1) {
                        tableController.deleteRow(matchTable.getModel(), "daoMatch", matchTable.getSelectedRow());
                        stateLabel.setText("Estado: Cargando Partidas");
                        tableController.inflateTable(matchTable, "daoMatch");
                        matchTable.removeColumn(matchTable.getColumnModel().getColumn(0));

                        matchTable.getModel().addTableModelListener(ev -> {
                            tableController.updateRow(matchTable.getModel(), "daoMatch", ev.getFirstRow());
                        });

                        stateLabel.setText("Estado: Listo");
                    } else {
                        showError("Debe seleccionar una fila para borrarla.", "Acción no permitida");
                    }
                    break;
            }
        });

        addButton.addActionListener(e -> {
            int i = tabbedPane1.getSelectedIndex();
            switch (i) {
                case 0:
                    AddTeamDialog.main(null);
                    break;
                case 1:
                    AddPlayerDialog.main(null);
                    break;
                case 2:
                    AddMatchDialog.main(null);
                    break;
            }
        });
    }

    public void showError(String message, String title) {
        JOptionPane.showMessageDialog(panel1, message, title, JOptionPane.ERROR_MESSAGE);
    }

}
