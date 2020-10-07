using System;

namespace _004_Structs
{
    class Program
    {
        struct empleado
        {
            public string name;
            public string sex;
            public double salary;
        }

        struct datos
        {
            public string name;
            public string country;
        }

        struct athlete
        {
            public string sport;
            public datos person;
            public int medals;
        }
        
        static void Main(string[] args)
        {
            ejercicio1();
        }

        static void ejercicio1() {
            empleado[] empleados = {
                new empleado() {name ="Pedro", sex = "male", salary = 18654.24},
                new empleado() {name ="Alejandra", sex = "female", salary = 27994.24},
                new empleado() {name ="Marcos", sex = "male", salary = 14295.65},
            };

            empleado minSalary = default(empleado);
            empleado maxSalary = default(empleado);
            
            foreach (var empleado in empleados)
            {
                if (minSalary.name == null)
                {
                    minSalary = empleado;
                    maxSalary = empleado;
                }
                else
                {
                    if (minSalary.salary >= empleado.salary) {
                        minSalary = empleado;
                    }
                    if (maxSalary.salary < empleado.salary) {
                        maxSalary = empleado;
                    }
                }
                
            }
            
            Console.WriteLine("Empleado con salario más bajo: " );
            Console.Write($"Empleado [ name: {minSalary.name}, sex: {minSalary.sex}, salary: {minSalary.salary} ]");
            
            Console.WriteLine("\nEmpleado con salario más alto: " );
            Console.Write($"Empleado [ name: {maxSalary.name}, sex: {maxSalary.sex}, salary: {maxSalary.salary} ]");
        }

        static void ejercicio2()
        {
            Console.WriteLine("Introduzca el número de Atletas: ");
            int nAthletes =  Console.Read();
            athlete[] athletes = new athlete[nAthletes];
            getAthletesData(nAthletes);

        }

        static void getAthletesData(int numberOfAthletes)
        {
            String name, country, sport;
            int medals;
            
            Console.WriteLine($"*************** ATLETA {numberOfAthletes} ***************");
            Console.Write("\nIntroduzca el nombre del Atleta: ");
            name = Console.ReadLine();
            Console.Write("\nIntroduzca el país del Atleta: ");
            country = Console.ReadLine();
            Console.Write("\nIntroduzca el deporte del Atleta: ");
            sport = Console.ReadLine();
            Console.Write("\nIntroduzca el número de medallas del Atleta: ");
            medals = Console.Read();

            return new athlete()
                {medals = medals, person = new datos() {country = country, name = name}, sport = sport};
        }
    }
}
