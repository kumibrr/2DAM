package com.company.gui;

import com.company.controllers.InsertionController;

import javax.swing.*;
import java.awt.event.*;

public class AddMatchDialog extends JDialog {
    private JPanel contentPane;
    private JButton buttonOK;
    private JButton buttonCancel;
    private JComboBox cmbTeamA;
    private JComboBox cmbTeamB;
    private final InsertionController insertionController = new InsertionController();

    public AddMatchDialog() {
        setTitle("Añadir partido");
        setContentPane(contentPane);
        setModal(true);
        insertionController.inflateTeamCombo(cmbTeamA);
        insertionController.inflateTeamCombo(cmbTeamB);
        getRootPane().setDefaultButton(buttonOK);

        buttonOK.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                onOK();
            }
        });

        buttonCancel.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                onCancel();
            }
        });

        // call onCancel() when cross is clicked
        setDefaultCloseOperation(DO_NOTHING_ON_CLOSE);
        addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
                onCancel();
            }
        });

        // call onCancel() on ESCAPE
        contentPane.registerKeyboardAction(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                onCancel();
            }
        }, KeyStroke.getKeyStroke(KeyEvent.VK_ESCAPE, 0), JComponent.WHEN_ANCESTOR_OF_FOCUSED_COMPONENT);
    }

    private void onOK() {
        String teamA = cmbTeamA.getSelectedItem().toString();
        String teamB = cmbTeamB.getSelectedItem().toString();
        if (!teamA.equals(teamB)) {
            insertionController.insertMatch(teamA, teamB);
            dispose();
        } else {
            JOptionPane.showMessageDialog(this, "Un equipo no puede jugar contra él mismo, no?", "Equipos iguales", JOptionPane.ERROR_MESSAGE);
        }
    }

    private void onCancel() {
        // add your code here if necessary
        dispose();
    }

    public static void main(String[] args) {
        AddMatchDialog dialog = new AddMatchDialog();
        dialog.pack();
        dialog.setVisible(true);
        System.exit(0);
    }
}
