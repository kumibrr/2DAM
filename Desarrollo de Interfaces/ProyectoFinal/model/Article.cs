using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Article
    {
        public string id;
        public string description;
        public int quantity;
        public int price;

        public Article(string id, string description, int quantity)
        {
            this.id = id;
            this.description = description;
            this.quantity = quantity;
        }
    }
}
