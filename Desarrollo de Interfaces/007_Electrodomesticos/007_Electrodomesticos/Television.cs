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
    }
}