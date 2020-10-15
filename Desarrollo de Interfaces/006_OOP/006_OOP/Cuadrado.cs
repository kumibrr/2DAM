using System;

namespace _006_OOP
{
    public class Cuadrado_01
    {
        private int l;

        public void addSideValue(int l)
        {
            this.l = l;
        }

        public void showData()
        {
            Console.WriteLine($"Perimeter: {l * 4} units \nArea: {Math.Pow((double) l, 2)} units^2");
        }
    }
}