using System.Diagnostics;

namespace _007_Electrodomesticos
{
    public class WashingMachine: Appliance
    {
        private double load = 5;

        public WashingMachine() : base() {
            
        }
        
        public WashingMachine(double price, double weight) : base(price, weight) {
            
        }
        
        public WashingMachine(double price, double weight, char powerEfficiency, Color color, double load) : base(price, weight, powerEfficiency, color)
        {
            this.load = load;
        }

        public double GetLoad()
        {
            return load;
        }

        public new double PrecioFinal()
        {
            double r = base.PrecioFinal();

            if (load > 30)
            {
                r += 50;
            }

            return r;
        }
    }
}