using System;

namespace _001_First_project
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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

            */
            /*String str = "";
            bool loop = true;

            Console.Write("Escribe la clave elegida: ");
            do {
                ConsoleKeyInfo a = Console.ReadKey(false);
                if (a.KeyChar == 42) {
                    loop = false;
                } else {
                    str += a.KeyChar.ToString();
                }
                
            } while (loop == true);

            Console.WriteLine("\n");
            Console.WriteLine($"La clave es: \"{str}\"");*/
            
            int[] numbers = new int[5];
            String[] cardinals =  new []{"primer", "segundo", "tercer", "cuarto", "quinto"};

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Introduzca el {cardinals[i]} número");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
            Console.Write("\n Al revés: {");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]}");
                if (i != 0)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("}");
        }
    }
}
