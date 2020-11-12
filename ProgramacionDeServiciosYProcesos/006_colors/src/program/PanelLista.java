package program;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class PanelLista extends JPanel implements ActionListener {
    private Window window;

    public PanelLista(Window window) {
        super();
        this.window = window;
        JButton mainMenu = new JButton();
        mainMenu.setText("Volver");
        mainMenu.addActionListener(this);
        this.add(mainMenu);

        JList list = new JList();
        DefaultListModel modelo = new DefaultListModel();

        modelo.addElement("Perro 🐶");
        modelo.addElement("Gato 🐱");
        modelo.addElement("Tortuga 🐢");
        modelo.addElement("Pinguino 🐧");
        modelo.addElement("Oso Panda 🐼");

        list.setModel(modelo);
        this.add(list);

        this.setVisible(true);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        this.setVisible(false);
        this.window.changeView(new PanelLista(this.window));
    }
}
