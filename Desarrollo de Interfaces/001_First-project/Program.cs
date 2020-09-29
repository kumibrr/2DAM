using System;

namespace _001_First_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Ejercicio 1.");
            Console.WriteLine("");
            Console.WriteLine("Introducza un número");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introducza otro número");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a * b);
            Console.WriteLine("*****************************************************************");

            Console.WriteLine("Ejercicio 2.");
            Console.WriteLine("");
            Console.WriteLine("Introducza un número");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introducza otro número");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultado división: " + (a / b));
            Console.WriteLine("Resto división: " + (a % b));
            Console.WriteLine("*****************************************************************");

            Console.WriteLine("Ejercicio 3.");
            Console.WriteLine("");
            Console.WriteLine("Introducza un número");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introducza otro número");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultado (a+b)*(a-b): " + ((a + b) * (a - b)));
            Console.WriteLine("Resto a^2 -b^2: " + (Math.Pow(a, 2) * Math.Pow(b, 2)));
            Console.WriteLine("*****************************************************************");

            Console.WriteLine("Ejercicio 4.");
            Console.WriteLine("");
            Console.WriteLine("Introducza un número");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introducza otro número");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introducza otro número más");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultado suma: " + (a + b + c));

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Ejercicio 5.");
            Console.WriteLine("");
            Console.WriteLine("Introducza un número");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++) {
                Console.WriteLine(a + "*" + i + "=" + (a * i));
            }
            Console.WriteLine("*****************************************************************");
        }
    }
}
