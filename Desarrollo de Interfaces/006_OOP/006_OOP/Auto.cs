using System;

namespace _006_OOP
{
    public class Auto
    {
        private string brand;
        private string model;
        private int kms;
        private string color;
        private string state;

        public void StartUp()
        {
            state = "Fired up";
        }

        public void Accelerate()
        {
            state = "Accelerating";
        }

        public void Brake()
        {
            state = "Braking";
        }

        public void ShowState()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Kms: {kms}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Estado: {state}");
        }
    }
}