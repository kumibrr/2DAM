package com.company;

import javax.swing.*;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;
import javax.swing.table.DefaultTableModel;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Mainform extends JFrame {
    private JPanel panel;
    private JButton btnSubmit;
    private JButton btnRead;
    private JTable table1;
    private JTextField textField1;
    private JTextField textField2;
    private JTextField textField3;

    public Mainform() {
        super("Vehículos");
        setContentPane(panel);
        addActionListeners();
        Controller.loadTable(table1);
    }

    public void addActionListeners() {
        table1.getSelectionModel().addListSelectionListener(new ListSelectionListener() {
            @Override
            public void valueChanged(ListSelectionEvent e) {
                String brand = (String) table1.getValueAt(table1.getSelectedRow(), 0);
                String model = (String) table1.getValueAt(table1.getSelectedRow(), 1);
                String registration = (String) table1.getValueAt(table1.getSelectedRow(), 2);
                textField1.setText(brand);
                textField2.setText(model);
                textField3.setText(registration);
            }
        });
    }

    public void setData(DAOVehiculos data) {
    }

    public void getData(DAOVehiculos data) {
    }

    public boolean isModified(DAOVehiculos data) {
        return false;
    }
}
