using System;

namespace _003_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ejercicio1();    
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
    }
}
