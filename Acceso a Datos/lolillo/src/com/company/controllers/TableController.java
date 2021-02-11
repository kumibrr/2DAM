package com.company.controllers;

import com.company.model.DAOPlayer;
import com.company.model.DAOTeam;
import com.company.model.Player;
import com.company.model.Team;

import javax.swing.*;
import javax.swing.table.DefaultTableModel;

public class TableController {

    public static void inflateTable(JTable table, String dao) {
        DefaultTableModel tableModel = new DefaultTableModel();
        switch (dao) {
            case "daoTeam":
                tableModel.addColumn("Nombre");
                tableModel.addColumn("Región");
                tableModel.addColumn("Copas");

                for (Team team: DAOTeam.getInstance().getTeams()) {
                    Object[] teamRow = new Object[3];
                    teamRow[0] = team.getName();
                    teamRow[1] = team.getRegion();
                    teamRow[2] = team.getChampionships();
                    tableModel.addRow(teamRow);
                }
                table.setModel(tableModel);
                break;
            case "daoPlayer":
                tableModel.addColumn("Nickname");
                tableModel.addColumn("Nombre");
                tableModel.addColumn("Apellidos");
                tableModel.addColumn("Posición");
                tableModel.addColumn("Equipo");

                for (Player player: DAOPlayer.getInstance().getPlayers()) {
                    Object[] playerRow = new Object[5];
                    playerRow[0] = player.getNickName();
                    playerRow[1] = player.getFirstName();
                    playerRow[2] = player.getLastName();
                    playerRow[3] = player.getPosition().getStr();
                    playerRow[4] = player.getTeam().getName();
                    tableModel.addRow(playerRow);
                }
                table.setModel(tableModel);
                break;
        }
    }

}
