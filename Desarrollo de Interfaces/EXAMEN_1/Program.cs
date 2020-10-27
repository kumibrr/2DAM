using System;
using System.Collections.Generic;

namespace EXAMEN_1
{
    struct LosChuches
    {
        public string name;
        public double price;

        public LosChuches(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            bool run = true;
            do
            {
                Menu();
                char opt = Console.ReadKey().KeyChar;

                if (opt == 'A' || opt == 'a')
                {
                    Console.Clear();
                    Ejercicio1();
                }
                else if (opt == 'B' || opt == 'b')
                {
                    Console.Clear();
                    Ejercicio2();
                }
                else if (opt == 'C' || opt == 'c')
                {
                    Console.Clear();
                    Ejercicio3();
                }
                else if (opt == 'D' || opt == 'd')
                {
                    Console.Clear();
                    Ejercicio4();
                }
                else if (opt == 'E' || opt == 'e')
                {
                    Console.Clear();
                    Ejercicio5();
                }
                else if (opt == 'S' || opt == 's')
                {
                    run = false;
                }
            } while (run);
        }

        public static void Ejercicio1()
        {
            bool running = true;
            do
            {
                Console.WriteLine("Introduzca número decimal a convertir (0 para salir):");
                int g = Int32.Parse(Console.ReadLine());

                if (g == 0)
                {
                    running = false;
                }
                else
                {
                    List<int> arrBin = new List<int>();
                    List<int> arrOct = new List<int>();
                    String hexaNum;
                    int b = g;
                    do
                    {
                        arrBin.Add(b % 2);
                        b = b / 2;
                    } while (b > 0);

                    int o = g;
                    do
                    {
                        arrOct.Add(o % 8);
                        o = o / 8;
                    } while (o > 0);

                    int h = g;
                    hexaNum = h.ToString("X");

                    Console.WriteLine("El binario es:");
                    for (int i = arrBin.Count - 1; i >= 0; i--)
                    {
                        Console.Write($"{arrBin[i]}");
                    }
                    
                    Console.WriteLine("\nEl octal es:");

                    for (int i = arrOct.Count - 1; i >= 0; i--)
                    {
                        Console.Write($"{arrOct[i]}");
                    }
                    Console.WriteLine($"\nEl hexadecimal es:");
                    Console.WriteLine($"{hexaNum}\n***********\n");
                }
            } while (running);
            Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
            Console.Read();
        }

        public static void Ejercicio2()
        {
            Console.WriteLine("Introduzca frase: ");
            String s = Console.ReadLine();
            
            List<string> strList = new List<string>();

            String ac = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    strList.Add(ac);
                    ac = "";
                }
                else
                {
                    ac += s[i];
                }

                if (i == s.Length - 1)
                {
                    strList.Add(ac);
                    ac = "";
                }
            }
            
            Console.WriteLine("----------------------------------------------------------------");
            
            foreach (var str in strList)
            {
                Console.Write($"{str} ");
            }
            Console.Write("*** ");
            for (int i = strList.Count - 1; i >= 0; i--)
            {
                Console.Write($"{strList[i]} ");
            }
            
            Console.WriteLine("\n----------------------------------------------------------------");
            Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
            Console.Read();
        }

        public static void Ejercicio3()
        {
            Console.WriteLine("Introduzca un número: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro número: ");
            int b = Int32.Parse(Console.ReadLine());

            int r = 0 - a - b;
            r = Math.Abs(r);
            
            Console.WriteLine(r);
            Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
            Console.Read();
        }
        
        //ESTO DE ABAJO ES EL EJERCICIO 4

        public static void Ejercicio4()
        {
            LosChuches[] chuches = new[]
            {
                new LosChuches("masibom", 2.45),
                new LosChuches("esniquer", 1.00),
                new LosChuches("caramelo raro", 0.30),
                new LosChuches("pesi cola", 1.45),
                new LosChuches("neh ti", 1.45)
            };
            
            Console.WriteLine("Elije la chuche miiño");
            for (int i = 0; i < chuches.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {chuches[i].name} || {chuches[i].price}€");
            }
            int opt = Int32.Parse(Console.ReadLine()) - 1;
            
            Console.WriteLine($"Has elejido {chuches[opt].name}.");
            Console.WriteLine("Introduce las monedas. Escribe 0.01, 0.02, 0.05, 0.1, 0.2, 0.5, 1 y 2");

            double moneyGiven = 0;
            do
            {
                Console.WriteLine($"Has metido {moneyGiven}€ de {chuches[opt].price}€ ");
                double coin = Double.Parse(Console.ReadLine());
                moneyGiven += coin;
            } while (moneyGiven < chuches[opt].price);
            
            Change(moneyGiven - chuches[opt].price);
            
            Console.WriteLine($"*Expulsa {chuches[opt].name}*");
            Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
            Console.Read();
        }

        public static void Change(double moneyToChange)
        {
            while (moneyToChange > 0)
            {
                if (moneyToChange > 2)
                {
                    moneyToChange -= 2;
                    Console.WriteLine("*Devuelve moneda de 2€*");
                } else if (moneyToChange > 1)
                {
                    moneyToChange -= 1;
                    Console.WriteLine("*Devuelve moneda de 1€*");
                } else if (moneyToChange > 0.5)
                {
                    moneyToChange -= 0.5;
                    Console.WriteLine("*Devuelve moneda de 0.5€*");
                } else if (moneyToChange > 0.2)
                {
                    moneyToChange -= 0.2;
                    Console.WriteLine("*Devuelve moneda de 0.2€*");
                }
                else if (moneyToChange > 0.1)
                {
                    moneyToChange -= 0.1;
                    Console.WriteLine("*Devuelve moneda de 0.1€*");
                }
                else if (moneyToChange > 0.05)
                {
                    moneyToChange -= 0.05;
                    Console.WriteLine("*Devuelve moneda de 0.05€*");
                }
                else if (moneyToChange > 0.02)
                {
                    moneyToChange -= 0.02;
                    Console.WriteLine("*Devuelve moneda de 0.02€*");
                } else
                {
                    moneyToChange -= 0.01;
                    Console.WriteLine("*Devuelve moneda de 0.01€*");
                }
            };
        }

        public static void Ejercicio5()
        {
            int[,] mat = new int[3,6];
            int[] ventasTotales = new int[6];
            string[] titulos = new[]
            {
                "Las Luces de Septiembre",
                "El Príncipe de la Niebla",
                "El Palacio de Medianoche",
                "Marina",
                "La Sombra del Viento",
                "El Juego del Ángel"
            };
            // Apartado A y B
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.WriteLine($"Introduzca las ventas de {titulos[j]} (título {j + 1}) en la Caseta no {i + 1}:");
                    mat[i, j] = Int32.Parse(Console.ReadLine());
                    ventasTotales[j] += mat[i, j];
                    Console.WriteLine($"Ventas totales: {ventasTotales[j]}");
                }
            }
            //Apartado C
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                int ventasCaseta = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    ventasCaseta += mat[i, j];
                }
                Console.WriteLine($"La caseta {i + 1} ha vendido {ventasCaseta} ejemplares.");
            }
            
            //Apartado D
            Console.WriteLine($"Ventas de \"{titulos[titulos.Length - 1]}\"");
            
            // Primer número: caseta, segundo: ventas.
            int[] min = {0,0};
            int[] max = {0,0};
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                int v = mat[i, mat.GetLength(1) - 1];
                Console.WriteLine($"La caseta {i} ha vendido {v}");
                if (min[1] < v)
                {
                    min[0] = i;
                    min[1] = v;
                }
                if (max[1] < v)
                {
                    min[0] = i;
                    min[1] = v;
                }
            }
            Console.WriteLine($"La caseta {min[0]} es la que menos ha vendido: {min[1]} ejemplares");
            Console.WriteLine($"La caseta {max[0]} es la que más ha vendido: {max[1]} ejemplares");
            
            Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
            Console.Read();
        }

        public static void Menu()
        {
            Console.Clear();
            string topBot = "***************************************************";
            Console.WriteLine(topBot);
            Console.WriteLine(fillSpaces("EXAMEN C# 22/10/2020"));
            Console.WriteLine(fillSpaces(""));
            Console.WriteLine(fillSpaces("Elija opción:"));
            Console.WriteLine(fillSpaces("A/ Conversión Binario"));
            Console.WriteLine(fillSpaces("B/ Frase loca"));
            Console.WriteLine(fillSpaces("C/ Sumar sin sumar"));
            Console.WriteLine(fillSpaces("D/ Compra con cambios"));
            Console.WriteLine(fillSpaces("E/ Feria del libro de Jerez"));
            Console.WriteLine(fillSpaces("S/ Salir."));
            Console.WriteLine(topBot);
        }

        public static string fillSpaces(string str)
        {
            string r = "* " + str;
            do
            {
                r += " ";
            } while (r.Length < 50);

            r += "*";
            
            return r;
        }
    }
}