package com.company;

import javax.swing.*;
import javax.swing.table.JTableHeader;

public class Mainform extends JFrame {
    private JPanel panel;
    private JTextField textField1;
    private JButton registrarButton;
    private JTextField textField2;
    private JTextField textField3;
    private JTable table1;
    private JButton leerButton;

    public Mainform() {
        super("Vehículos");
        setContentPane(panel);
    }

    private void createUIComponents() {
        // TODO: place custom component creation code here
        String[] tableHeader = new String[] {"Marca", "Modelo", "Matrícula"};
        String[][] data = new String[][] {{"Tesla", "Model X", "ADN7746DS"}};
        table1 = new JTable(data, tableHeader);
    }
}
