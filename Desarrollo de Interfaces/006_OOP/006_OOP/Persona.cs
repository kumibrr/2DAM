using System;

namespace _006_OOP
{
    public class Persona
    {
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public void setNombre(string nombre)
        {
            if (nombre is string)
            {
                this.nombre = nombre;
            }
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {nombre}");
        }
    }
}