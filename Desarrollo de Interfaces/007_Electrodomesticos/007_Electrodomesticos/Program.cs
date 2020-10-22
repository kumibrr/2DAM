using System;
using System.Collections.Generic;

namespace _007_Electrodomesticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Appliance[] appliances = new Appliance[10];
            
            appliances[0] = new Television();
            appliances[1] = new Television(1799.89, 28.76);
            appliances[2] = new Television(1729,09,'A',Color.White,87,true);
            appliances[3] = new Television(200,50.49,'A',Color.Black,29,false);
            appliances[4] = new Television(790.90,12.9);
            appliances[5] = new WashingMachine(459.60, 36.54);
            appliances[6] = new WashingMachine(690.43, 60.3, 'B', Color.Black,15);
            appliances[7] = new WashingMachine();
            appliances[8] = new WashingMachine(345.43, 20.3, 'F', Color.White,6);
            appliances[9] = new WashingMachine();

            Dictionary<string, List<Appliance>> items = new Dictionary<string, List<Appliance>>();
            items.Add("Television", new List<Appliance>());
            items.Add("Washing Machine", new List<Appliance>());
            
            foreach (var appliance in appliances)
            {
                if (appliance is Television)
                {
                    items["Television"].Add(appliance);
                }
                else if (appliance is WashingMachine)
                {
                    items["Washing Machine"].Add(appliance);
                }
            }

            double totalPrice = 0;
            foreach (var item in items)
            {
                double applianceCategoryPrice = 0;
                Console.WriteLine($"**** {item.Key} ****");
                foreach (var arr in item.Value)
                {
                    double p = arr.GetPrice();
                    Console.WriteLine(p);
                    applianceCategoryPrice += p;
                    totalPrice += p;
                }
                Console.WriteLine($"Total {item.Key}: {applianceCategoryPrice}");
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Total de todo: {totalPrice}");
            
            
        }
    }
}
