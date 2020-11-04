package program;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Window extends JFrame implements ActionListener {

    public JPanel panel;
    public JButton btnGreen = new JButton(), btnBlack = new JButton(), btnCyan = new JButton();

    public Window() {
        super();
        panel = new JPanel();
        this.getContentPane().add(panel);
        setTitle("Colores");
        setVisible(true);
        
        setButtons();
        addButtonsToPanel(btnBlack, btnGreen, btnCyan);

    }

    public void setButtons() {
        btnBlack.setText("Negro");
        btnBlack.addActionListener(this);

        btnCyan.setText("Cián");
        btnCyan.addActionListener(this);

        btnGreen.setText("Verde");
        btnGreen.addActionListener(this);
    }

    public void addButtonsToPanel(JButton ...button) {
        for (JButton btn : button) {
            panel.add(btn);
        }
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        JButton btn = (JButton) e.getSource();

        if (btn == btnBlack) {
            panel.setBackground(Color.BLACK);
        } else if(btn == btnCyan) {
            panel.setBackground(Color.CYAN);
        } else if(btn == btnGreen) {
            panel.setBackground(Color.green);
        }
    }
}
