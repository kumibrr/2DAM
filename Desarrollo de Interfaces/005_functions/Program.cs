using System;

namespace _005_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int n1 = 45;
            int n2 = 56;
            Console.WriteLine($"n1 = {n1}, n2 = {n2}");
            swapNumbers(ref n1, ref n2);
            Console.WriteLine($"n1 = {n1}, n2 = {n2}");
            */
            diceProb(500000);
        }

        private static ulong factorial(int n1) {
            ulong ac = Convert.ToUInt64(n1);
            for (ulong i = Convert.ToUInt64(n1) - 1; i > 0; i--) {
                ac = ac * i;
            }
            return ac;
        }

        public static void IOFactorial()
        {
            int[] numbers = new int[3];
            
            Console.WriteLine("Introduzca el primer número:");
            numbers[0] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el siguiente número:");
            numbers[1] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el último número:");
            numbers[2] = Int32.Parse(Console.ReadLine());

            foreach (var number in numbers) {
                Console.WriteLine($"El factorial de {number} es: {factorial(number)}");
            }
        }

        public static void swapNumbers(ref int n1, ref int n2) {
            Console.WriteLine("LLAMADA!");
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }

        public static void diceProb(int times) {
            int[] dice = new int[6];
            Random rng = new Random();
            for (int i = 0; i < dice.Length; i++) {
                for (int j = 0; j < times / dice.Length; j++) {
                    dice[rng.Next(6)]++;
                }
            }

            for (int i = 0; i < dice.Length; i++)
            {
                int perc = dice[i] * 100 / times;
                Console.WriteLine($"La cara {i + 1} ha salido {dice[i]} veces. Una probabilidad del {perc}%");
            }
        }
    }
}
