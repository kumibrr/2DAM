package com.company.controllers;

import com.company.model.*;

import javax.swing.*;

public class InsertionController {
    private DAOTeam daoTeam = DAOTeam.getInstance();
    private DAOPlayer daoPlayer = DAOPlayer.getInstance();
    private DAOMatch daoMatch = DAOMatch.getInstance();

    public void insertTeam(JTextField nameTextBox, JComboBox regionCombo) {
        daoTeam.insertTeam(new Team(0, nameTextBox.getText(), regionCombo.getSelectedItem().toString(), 0));
    }

    public void insertPlayer(String name, String lastname, String nick, String position, String team) {
        daoPlayer.insertPlayer(new Player(0, name, lastname, nick, position, daoTeam.getTeam(team)));
    }

    public void insertMatch(String teamA, String teamB) {
        daoMatch.insertMatch(new Match(0, daoTeam.getTeam(teamA), daoTeam.getTeam(teamB), null, null));
    }

    public JComboBox inflateRegionJComboBox(JComboBox cmb) {
        cmb.addItem(Region.EU.getStr());
        cmb.addItem(Region.KR.getStr());
        cmb.addItem(Region.CN.getStr());
        cmb.addItem(Region.NA.getStr());
        cmb.addItem(Region.AP.getStr());
        cmb.addItem(Region.SA.getStr());
        return cmb;
    }

    public JComboBox inflatePositionCombo(JComboBox cmb) {
        cmb.addItem(Position.TOP.getStr());
        cmb.addItem(Position.JUNGLE.getStr());
        cmb.addItem(Position.MIDLANE.getStr());
        cmb.addItem(Position.ADCARRY.getStr());
        cmb.addItem(Position.SUPPORT.getStr());
        return cmb;
    }

    public JComboBox inflateTeamCombo(JComboBox cmb) {
        for (Team t: daoTeam.getTeams()) {
            cmb.addItem(t.getName());
        }
        return cmb;
    }
}
