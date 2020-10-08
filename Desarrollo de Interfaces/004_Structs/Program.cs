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
            ejercicio2();
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
            int nAthletes =  Int32.Parse(Console.ReadLine());
            athlete[] athletes = new athlete[nAthletes];
            athlete maxMedals = default(athlete);
            for (int i = 0; i < nAthletes; i++) {
                athletes[i] = getAthletesData(i + 1);
                if (athletes[i].medals > maxMedals.medals) {
                    maxMedals = athletes[i];
                }
            }
            Console.WriteLine($"{maxMedals.person.name}, de {maxMedals.person.country}, es quien tiene más medallas: {maxMedals.medals}");
        }

        static athlete getAthletesData(int index)
        {
            String name, country, sport;
            int medals;
            
            Console.WriteLine($"*************** ATLETA {index} ***************");
            Console.WriteLine("Introduzca el nombre del Atleta: ");
            name = Console.ReadLine();
            Console.WriteLine("Introduzca el país del Atleta: ");
            country = Console.ReadLine();
            Console.WriteLine("Introduzca el deporte del Atleta: ");
            sport = Console.ReadLine();
            Console.WriteLine("Introduzca el número de medallas del Atleta: ");
            medals = Int32.Parse(Console.ReadLine());

            return new athlete()
                {medals = medals, person = new datos() {country = country, name = name}, sport = sport};
        }
    }
}
