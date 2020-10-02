using System;

namespace _002_Ejercicio_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            void wait()
            {
                Console.WriteLine("\nPulse cualquier tecla para continuar...");
                Console.ReadKey(false);
            }
            
            do {
                Console.Clear();
                
                // ⬇ option is an unicode key value ⬇
                int option = showMenu();
                Console.Clear();
                switch (option) {
                    case 49:
                        firstExercise();
                        wait();
                        break;
                    case 50:
                        secondExercise();
                        wait();
                        break;
                    case 51:
                        thirdExercise();
                        wait();
                        break;
                    case 52:
                        fourthExercise();
                        wait();
                        break;
                    case 53:
                        exit = true;
                        break;
                }
                
            } while (exit == false);
            
        }

        static int showMenu()
        {
            Console.WriteLine(" **************  EJERCICIOS DE BUCLES   ************");
            Console.WriteLine("1. Factorial");
            Console.WriteLine("2. Clave");
            Console.WriteLine("3. Números primos");
            Console.WriteLine("4. Mayúsculas descendentes");
            Console.WriteLine("5. Salir");
            Console.WriteLine("\nElija opción");
            
            return Console.ReadKey(false).KeyChar;
        }

        static void firstExercise()
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

        static void secondExercise()
        {
            String str = "";
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
            Console.WriteLine($"La clave es: \"{str}\"");
        }

        static void thirdExercise()
        {
            Console.WriteLine("Introduzca el número:");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Los {n} primeros números primos son: ");

            int primesFound = 0;
            for (int i = 1; primesFound < n; i++) {
                int occurences = 0;
                for (int j = 1; j <= i; j++) {
                    if (i % j == 0) {
                        occurences++;
                    }
                }

                if (occurences <= 2) {
                    primesFound++;
                    Console.WriteLine($"{primesFound} => {i}");
                }
            }
        }

        static void fourthExercise()
        {
            // 90 to 65
            for (int i = 90; i >= 65; i--)
            {
                char c = (char) i;
                Console.Write(c.ToString());
            }
            
        }
        
    }
}
