using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.model
{
    class Workcentre
    {
        private string id;
        ArrayList orders = new ArrayList();

        public Workcentre(string id)
        {
            this.id = id;
        }
        public void addOrder(Order order)
        {
            orders.Add(order);
        }
    }
}
