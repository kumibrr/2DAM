package program;

import javax.swing.*;

public class Window extends JFrame {

    private JPanel currentPanel = new JPanel();

    public Window() {
        super();
        this.changeView(new PanelColores(this));
        setVisible(true);
    }

    public void changeView(JPanel panel) {
        this.getContentPane().remove(currentPanel);
        this.currentPanel = panel;
        this.getContentPane().add(currentPanel);
        this.setTitle(panel.getName());
    }

}
