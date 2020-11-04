package Program;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class GreetListener implements ActionListener {

    private Window window;

    public GreetListener(Window window) {
        this.window = window;
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        window.lblGreet.setText("Hey");
    }
}
