namespace _007_Electrodomesticos
{
    public class Television : Appliance
    {
        private double inches = 20;
        private bool tdt = false;

        public Television() : base()
        {
            
        }

        public Television(double price, double weight) : base(price, weight)
        {
            
        }
        
        public Television(double price, double weight, char powerEfficiency, Color color, double inches, bool tdt) : base(price, weight, powerEfficiency, color)
        {
            this.inches = inches;
            this.tdt = tdt;
        }

        public double GetInches()
        {
            return this.inches;
        }

        public bool GetTdt()
        {
            return tdt;
        }

        public new double PrecioFinal()
        {
            double r = base.PrecioFinal();
            if (inches > 40)
            {
                r += (r * 30 / 100);
            }

            if (tdt)
            {
                r += 50;
            }

            return r;
        }
        
    }
}