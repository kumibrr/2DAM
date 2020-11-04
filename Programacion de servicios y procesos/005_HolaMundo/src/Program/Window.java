package Program;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Window extends JFrame implements ActionListener {

    public JLabel lblGreet;
    public JButton btnShowHelloWorld;
    public JPanel panel;
    public JButton btnFarewell;

    public Window() {
        super();
        panel = new JPanel();
        setTitle("Hola Mundo");
        setVisible(true);
        this.getContentPane().setLayout(new FlowLayout());

        this.getContentPane().add(panel);
        btnShowHelloWorld = new JButton();
        btnShowHelloWorld.setText("Mostrar Hola Mundo");
        lblGreet = new JLabel();
        lblGreet.setText("Buenas, amige");
        btnFarewell = new JButton();
        btnFarewell.setText("Despedirse");

        panel.add(btnFarewell);
        panel.add(btnShowHelloWorld);
        panel.add(lblGreet);

        btnShowHelloWorld.addActionListener(this);
        btnFarewell.addActionListener(this);

//      btnShowHelloWorld.addActionListener(new GreetListener(this));

//        btnFarewell.addActionListener(new AbstractAction() {
//            @Override
//            public void actionPerformed(ActionEvent e) {
//                lblGreet.setText("Bye :'(");
//            }
//        });
//
//        btnShowHelloWorld.addActionListener(new AbstractAction() {
//            @Override
//            public void actionPerformed(ActionEvent e) {
//                lblGreet.setText("Yooooo");
//            }
//        });


//        this.pack();
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        JButton btn = (JButton) e.getSource();

        if (btn == btnShowHelloWorld) {
            lblGreet.setText("Eyyyy");
        } else if (btn == btnFarewell) {
            lblGreet.setText("Bye :'(");
        }
    }
}
