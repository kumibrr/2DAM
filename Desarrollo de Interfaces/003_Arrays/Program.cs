using System;
using System.Collections.Generic;

namespace _003_Arrays
{
    struct priceAndDiscount
    {
        private double price;
        private double discount;

        public priceAndDiscount(double price, double discount)
        {
            this.price = price;
            this.discount = discount;
        }

        public double calcTotal()
        {
            return price - (price * discount / 100);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ejercicio1();   
            Ejercicio2();
        }
        
        static void ejercicio1() {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++) {
                
                Console.WriteLine($"Introduce el valor {i}: ");
                try {
                    arr[i] = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.WriteLine("Eso q es herman0 q me lías");
                    i--;
                }
            }
        
            int greatest = arr[0];
            int smallest = arr[0];
            foreach (int n in arr) {
                if (n > greatest) {
                    greatest = n;
                }
                if (n < smallest) {
                    smallest = n;
                }
            }
            Console.WriteLine($"El valor mínimo es \" {smallest} \" y el máximo es \' {greatest} \'");
        }

        static void Ejercicio2()
        {
            string[] items = new[] {"Camisa caballero", "Camisa señora", "Pantalón Caballero", "Pantalón señora"};
            priceAndDiscount[] pAd = new[]
            {
                new priceAndDiscount(25, 10), new priceAndDiscount(18, 5),
                new priceAndDiscount(33, 2), new priceAndDiscount(35, 0)
            };

            for (int i = 0; i < items.Length && i < pAd.Length; i++)
            {
                Console.WriteLine($"{items[i]} {pAd[i].calcTotal()}€");
            }
        }
    }
        
}
