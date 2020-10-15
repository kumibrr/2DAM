using System;

namespace _006_OOP
{
    public class Bank
    {
        private Customer[] customers = new Customer[3];

        public Bank()
        {
            customers[0] = new Customer("Ana", 15300);
            customers[1] = new Customer("Alejandro", 4.32);
            customers[2] = new Customer("Pepe", 1345);
        }

        public void MainMenu()
        {
            Boolean menu = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccionar cliente: ");
                for (int i = 0; i < customers.Length; i++)
                {
                    Console.WriteLine($"{i}. {customers[i].name}");
                }
                Console.WriteLine("Elige el cliente que va a operar o pulse 'x': ");
                string option = Console.ReadLine();
                if (option.Equals("x")) {
                    menu = true;
                } else {
                    Operate(customers[Int32.Parse(option)]);
                }
            } while (menu == false);
        }

        public void Operate(Customer c)
        {
            Boolean menu = false;

            do
            {
                Console.Clear();
                Console.WriteLine($"¿Qué desea hacer, {c.name}?");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Sacar");
                Console.WriteLine("3. Ver saldo");
                Console.WriteLine("4. Salir");
                int option = Int32.Parse(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Introduzca la cantidad a depositar:");
                        Double d = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Hecho. Pulse cualquier tecla para salir...");
                        c.Deposit(d);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Introduzca la cantidad a sacar:");
                        Double s = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Hecho. Pulse cualquier tecla para salir...");
                        c.Withdraw(s);
                        break;
                    case 3:
                        Console.WriteLine($"Su saldo es: {c.getCash()}");
                        Console.WriteLine("Pulse cualquier tecla para salir...");
                        Console.ReadLine();
                        break;
                    case 4:
                        menu = true;
                        break;
                }
                
            } while (menu == false);
        }
    }


}