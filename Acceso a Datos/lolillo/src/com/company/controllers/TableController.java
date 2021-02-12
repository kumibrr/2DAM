package com.company.controllers;

import com.company.gui.MainWindow;
import com.company.model.*;

import javax.swing.*;
import javax.swing.table.*;

public class TableController {
    private DAOTeam daoTeam = DAOTeam.getInstance();
    private DAOPlayer daoPlayer = DAOPlayer.getInstance();
    private DAOMatch daoMatch = DAOMatch.getInstance();
    private MainWindow window;

    public TableController(MainWindow window) {
        this.window = window;
    }

    public void inflateTable(JTable table, String dao) {
        DefaultTableModel tableModel = new DefaultTableModel();
        switch (dao) {
            case "daoTeam":
                tableModel.addColumn("id");
                tableModel.addColumn("Nombre");
                tableModel.addColumn("Región");
                tableModel.addColumn("Copas");

                for (Team team: daoTeam.getTeams()) {
                    Object[] teamRow = new Object[4];
                    teamRow[0] = team.getId();
                    teamRow[1] = team.getName();
                    teamRow[2] = team.getRegion();
                    teamRow[3] = team.getChampionships();
                    tableModel.addRow(teamRow);
                }
                table.setModel(tableModel);
                table.getColumnModel().getColumn(2).setCellEditor(new DefaultCellEditor(createRegionCombo()));
                break;
            case "daoPlayer":
                tableModel.addColumn("id");
                tableModel.addColumn("Nickname");
                tableModel.addColumn("Nombre");
                tableModel.addColumn("Apellidos");
                tableModel.addColumn("Posición");
                tableModel.addColumn("Equipo");

                for (Player player: daoPlayer.getPlayers()) {
                    Object[] playerRow = new Object[6];
                    playerRow[0] = player.getId();
                    playerRow[1] = player.getNickName();
                    playerRow[2] = player.getFirstName();
                    playerRow[3] = player.getLastName();
                    playerRow[4] = player.getPosition().getStr();
                    playerRow[5] = player.getTeam().getName();
                    tableModel.addRow(playerRow);
                }
                table.setModel(tableModel);
                table.getColumnModel().getColumn(4).setCellEditor(new DefaultCellEditor(createPositionCombo()));
                table.getColumnModel().getColumn(5).setCellEditor(new DefaultCellEditor(createTeamCombo()));
                break;
            case "daoMatch":
                tableModel.addColumn("id");
                tableModel.addColumn("Equipo A");
                tableModel.addColumn("Equipo B");
                tableModel.addColumn("Equipo ganador");
                tableModel.addColumn("Jugador MVP");

                daoPlayer.getPlayers();
                for (Match match: daoMatch.getMatches()) {
                    Object[] matchRow = new Object[5];
                    matchRow[0] = match.getId();
                    matchRow[1] = match.getTeamA().getName();
                    matchRow[2] = match.getTeamB().getName();
                    if (match.getWinner() == null) {
                        matchRow[3] = "Partida no disputada.";
                        matchRow[4] = " - ";
                    } else if (match.getMvp() == null) {
                        matchRow[3] = match.getWinner().getName();
                        matchRow[4] = " - ";
                    }
                    else {
                        matchRow[3] = match.getWinner().getName();
                        matchRow[4] = match.getMvp().getNickName();
                    }
                    tableModel.addRow(matchRow);
                }
                table.setModel(tableModel);
                table.getColumnModel().getColumn(3).setCellEditor(new DefaultCellEditor(createTeamCombo()));
                break;
        }
    }

    public void updateRow(TableModel model, String dao, int rowIndex) {
        switch (dao){
            case "daoTeam":
                Team t = daoTeam.getTeam((int) model.getValueAt(rowIndex, 0));
                t.setName(model.getValueAt(rowIndex, 1).toString());
                t.setRegion(Region.getRegion(model.getValueAt(rowIndex, 2).toString()));
                t.setChampionships((int) model.getValueAt(rowIndex, 3));
                daoTeam.updateTeam(t);
                break;
            case "daoPlayer":
                Player p = daoPlayer.getPlayer((int) model.getValueAt(rowIndex, 0));
                p.setFirstName(model.getValueAt(rowIndex, 2).toString());
                p.setLastName(model.getValueAt(rowIndex, 3).toString());
                p.setNickName(model.getValueAt(rowIndex, 1).toString());
                p.setPosition(Position.getPosition(model.getValueAt(rowIndex, 4).toString()));
                p.setTeam(daoTeam.getTeam(model.getValueAt(rowIndex, 5).toString()));
                daoPlayer.updatePlayer(p);
                break;
            case "daoMatch":
                if (model.getValueAt(rowIndex, 3).toString().equals(model.getValueAt(rowIndex, 1).toString()) || model.getValueAt(rowIndex, 3).toString().equals(model.getValueAt(rowIndex, 2).toString())) {
                    Match m = daoMatch.getMatch((int) model.getValueAt(rowIndex, 0));
                    m.setWinner(daoTeam.getTeam(model.getValueAt(rowIndex, 3).toString()));
                    m.setMvp(daoPlayer.getPlayer(model.getValueAt(rowIndex, 4).toString()));
                    daoMatch.updateMatch(m);
                } else {
                    window.showError("Los equipos deben coincidir", "IO Error");
                    model.setValueAt(null, rowIndex, 3);
                }

                break;
        }
    }

    public void deleteRow(TableModel model, String dao, int rowIndex) {
        switch (dao) {
            case "daoTeam":
                daoTeam.deleteTeam(daoTeam.getTeam((int) model.getValueAt(rowIndex, 0)));
                break;
            case "daoPlayer":
                daoPlayer.deletePlayer(daoPlayer.getPlayer((int) model.getValueAt(rowIndex, 0)));
                break;
            case "daoMatch":
                daoMatch.deleteMatch(daoMatch.getMatch((int) model.getValueAt(rowIndex, 0)));
                break;
        }
    }

    public JComboBox createRegionCombo() {
        JComboBox cmb = new JComboBox();
        cmb.addItem(Region.EU.getStr());
        cmb.addItem(Region.KR.getStr());
        cmb.addItem(Region.CN.getStr());
        cmb.addItem(Region.NA.getStr());
        cmb.addItem(Region.AP.getStr());
        cmb.addItem(Region.SA.getStr());
        return cmb;
    }

    public JComboBox createPositionCombo() {
        JComboBox cmb = new JComboBox();
        cmb.addItem(Position.TOP.getStr());
        cmb.addItem(Position.JUNGLE.getStr());
        cmb.addItem(Position.MIDLANE.getStr());
        cmb.addItem(Position.ADCARRY.getStr());
        cmb.addItem(Position.SUPPORT.getStr());
        return cmb;
    }

    public JComboBox createTeamCombo() {
        JComboBox cmb = new JComboBox();
        for (Team t: daoTeam.getTeams()) {
            cmb.addItem(t.getName());
        }
        return cmb;
    }


}
