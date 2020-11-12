package com.elisrael;

import java.util.LinkedList;

public class Cola {

    private LinkedList<Proceso> queue = new LinkedList<Proceso>();
    private int priority;

    private Cola(int queuePriority) {
        this.priority = queuePriority;
    }

    public static Cola creaCola(int queuePriority) {
        return new Cola(queuePriority);
    }

    public boolean insCola(Proceso p) {
        if (getSize() < 10) {
            this.queue.add(p);
            return true;
        } else {
//             I'd rather throw an exception, but we were told not to use them yet.
            return false;
        }
    }

    public Proceso desenCola () {
        return queue.remove();
    }

    public boolean esVaciaCola() {
        return queue.isEmpty();
    }

    public int getSize() {
        return queue.size();
    }

    @Override
    public String toString() {
        return "Cola{" +
                "queue=" + this.queue +
                ", priority=" + priority +
                '}';
    }
}
