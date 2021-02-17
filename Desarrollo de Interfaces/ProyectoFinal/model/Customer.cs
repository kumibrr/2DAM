using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Customer
    {
        public string firstName;
        public string lastName;
        public string phone;
        public string cellphone;
        public string email;

        public Customer(string firstName, string lastName, string phone, string cellphone, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.cellphone = cellphone;
            this.email = email;
        }
    }
}
