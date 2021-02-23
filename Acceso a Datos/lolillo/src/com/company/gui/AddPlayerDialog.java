package com.company.gui;

import com.company.controllers.InsertionController;

import javax.swing.*;
import java.awt.event.*;

public class AddPlayerDialog extends JDialog {
    private JPanel contentPane;
    private JButton buttonOK;
    private JButton buttonCancel;
    private JTextField nametxt;
    private JTextField lastnameTxt;
    private JTextField nickTxt;
    private JComboBox comboBox1;
    private JComboBox comboBox2;
    private final InsertionController insertionController = new InsertionController();

    public AddPlayerDialog() {
        setTitle("Añadir jugador");
        setContentPane(contentPane);
        setModal(true);
        getRootPane().setDefaultButton(buttonOK);
        insertionController.inflatePositionCombo(comboBox1);
        insertionController.inflateTeamCombo(comboBox2);

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
        // add your code here
        insertionController.insertPlayer(nametxt.getText(), lastnameTxt.getText(), nickTxt.getText(), comboBox1.getSelectedItem().toString(), comboBox2.getSelectedItem().toString());
        dispose();
    }

    private void onCancel() {
        // add your code here if necessary
        dispose();
    }

    public static void main(String[] args) {
        AddPlayerDialog dialog = new AddPlayerDialog();
        dialog.pack();
        dialog.setVisible(true);
        System.exit(0);
    }
}
