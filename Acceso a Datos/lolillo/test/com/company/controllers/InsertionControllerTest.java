package com.company.controllers;

import com.company.model.MockDAOTeam;
import com.company.model.Region;
import com.company.model.Team;

import javax.swing.*;

import java.util.ArrayList;

import static org.junit.Assert.*;

public class InsertionControllerTest {

    private InsertionController ins;

    @org.junit.Before
    public void setUp() throws Exception {
        ins = new InsertionController();
        ins.daoTeam = new MockDAOTeam();
    }

    @org.junit.Test
    public void insertTeam() {
        JTextField name = new JTextField();
        name.setText("testing");

        JComboBox<Region> region = new JComboBox<>();
        region.addItem(Region.KR);
        region.setSelectedIndex(0);

        assertTrue(ins.insertTeam(name, region));
    }

    @org.junit.Test
    public void inflateTeamCombo() {
        JComboBox<String> jComboBox = new JComboBox<>();
        ins.inflateTeamCombo(jComboBox);

        JComboBox<String> expectedComboBox = new JComboBox<>();
        ArrayList<Team> teams = (ArrayList<Team>) ins.daoTeam.getTeams();
        for (Team team: teams) {
            expectedComboBox.addItem(team.getName());
        }

        assertTrue(jComboBox.getModel().equals(jComboBox.getModel()));
    }
}