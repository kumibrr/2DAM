using System;

namespace _006_OOP
{
    public class Operations
    {
        public static void showAllOperations()
        {
            Console.WriteLine("Introduzca el primer valor: ");
            int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduzca el segundo valor: ");
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"" +
                              $"suma: {add(a, b)} \n" +
                              $"resta: {substract(a, b)} \n" +
                              $"multiplicación: {multiply(a, b)} \n" +
                              $"división: {division(a, b)}"
            );
        }

        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int substract(int a, int b)
        {
            return a - b;
        }

        public static int multiply(int a, int b)
        {
            return a * b;
        }
        
        public static float division(int a, int b)
        {
            return (float) a / b;
        }
    }
}