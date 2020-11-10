package program;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class PanelColores extends JPanel implements ActionListener {
    private Window window;
    public JButton btnGreen = new JButton(), btnBlack = new JButton(), btnCyan = new JButton(), btnGoToPanelLista = new JButton();

    public PanelColores(Window window) {
        super();
        this.window = window;
        setButtons();
        addButtonsToPanel(btnBlack, btnGreen, btnCyan, btnGoToPanelLista);

    }

    public void setButtons() {
        btnBlack.setText("Negro");
        btnBlack.addActionListener(this);

        btnCyan.setText("Cián");
        btnCyan.addActionListener(this);

        btnGreen.setText("Verde");
        btnGreen.addActionListener(this);

        btnGoToPanelLista.setText("Ver lista de animales");
        // btnGoToPanelLista.addActionListener();
    }

    public void addButtonsToPanel(JButton ...button) {
        for (JButton btn : button) {
            this.add(btn);
        }
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        JButton btn = (JButton) e.getSource();
        String btnText = btn.getText();

        if (btnText.equals(btnBlack.getText())) {
            this.setBackground(Color.BLACK);
        } else if (btnText.equals(btnGreen.getText())) {
            this.setBackground(Color.GREEN);
        } else if (btnText.equals(btnCyan.getText())) {
            this.setBackground(Color.CYAN);
        } else if (btnText.equals(btnGoToPanelLista.getText())) {
            this.setVisible(false);
            this.window.changeView(new PanelLista(this.window));
        } else {
            this.setBackground(Color.LIGHT_GRAY);
        }
    }
}
