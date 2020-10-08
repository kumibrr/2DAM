package com.elisrael;

import java.util.Vector;

public class GestionColas implements Runnable {
    Cola firstQueue = Cola.creaCola(1);
    Cola secondQueue = Cola.creaCola(2);
    Cola thirdQueue = Cola.creaCola(3);
    Vector<Proceso> onInit = new Vector<>();
    Vector<Proceso> onExec = new Vector<>();


    public GestionColas() throws InterruptedException {
        for (int i = 0; i < 10; i++) {
            onInit.add(new Proceso());
            onExec.add(new Proceso());
        }
        for (int i = 0; i < 10; i++) {
            onExec.add(new Proceso());
        }
        addToQueues(true);
    }

    public void addToQueues(boolean onInit) throws InterruptedException {

        if (onInit) {
            do {
                insertInQueue(this.onInit);
            } while (!this.onInit.isEmpty());
        }else {
            do {
                Thread.sleep(3000);
                insertInQueue(this.onExec);
            } while (!this.onExec.isEmpty());
        }
    }

    private void insertInQueue(Vector<Proceso> queue) {
        Proceso p;
        p = queue.remove(0);
        System.out.println("Insertando " + p.toString());
        switch (p.priority) {
            case 1:
                firstQueue.insCola(p);
                break;
            case 2:
                secondQueue.insCola(p);
                break;
            case 3:
                thirdQueue.insCola(p);
                break;
            default:
                System.out.println("Error al añadir a cola");
        }
    }

    public void play() throws InterruptedException {
        Proceso p;
        do {
            if (!firstQueue.esVaciaCola()) {
                p = firstQueue.desenCola();
                p.Execute();
            } else if (!secondQueue.esVaciaCola()) {
                p = secondQueue.desenCola();
                p.Execute();
            } else if (!thirdQueue.esVaciaCola()) {
                p = thirdQueue.desenCola();
                p.Execute();
            } else {
                System.out.println("Las colas están vacías actualmente");
            }

        } while (
                !firstQueue.esVaciaCola() || !secondQueue.esVaciaCola() || !thirdQueue.esVaciaCola()
                || !onInit.isEmpty() || !onExec.isEmpty()
        );
    }

    @Override
    public void run() {
        try {
            addToQueues(false);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}
