using System;

namespace _002_Ejercicio_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el número:");
            int fact = Int32.Parse(Console.ReadLine());

            int r = 1;
            for (int i = 1; i - 1 < fact; i++)
            {
                r = r * i;
            }
            
            Console.WriteLine($"El factorial de {fact} es: {r}");
        }
    }
}
