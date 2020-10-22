namespace _007_Electrodomesticos
{
    public abstract class Appliance
    {
        protected double basePrice = 100.00;
        protected char powerEfficiency = 'F';
        protected double weight = 5.00;
        protected Color color = Color.White;

        public Appliance() {
            
        }
        public Appliance(double price, double weight) 
        {
            this.basePrice = price;
            this.weight = weight;
        }
        
        public Appliance(double price, double weight, char powerEfficiency, Color color)
        {
            this.basePrice = price;
            this.weight = weight;
            this.powerEfficiency = ComprobarConsumoEnergetico(powerEfficiency);
            this.color = color;
            PrecioFinal();
        }

        public double GetPrice() 
        {
            return basePrice;
        }

        public char GetPowerEfficiency()
        {
            return powerEfficiency;
        }

        public double GetWeight() 
        {
            return weight;
        }

        public Color GetColor() 
        {
            return color;
        }

        private char ComprobarConsumoEnergetico(char letra)
        {
            char r = letra < 'F' ? letra : 'F';
            return r;
        }
        
        // El método "ComprobarColor no es necesario al haber hecho uso de un enum para identificar el color."
        public double PrecioFinal()
        {
            double r = basePrice;
            switch (powerEfficiency)
            {
                case 'A':
                    r += 100;
                    break;
                case 'B':
                    r += 80;
                    break;
                case 'C':
                    r += 60;
                    break;
                case 'D':
                    r += 50;
                    break;
                case 'E':
                    r += 30;
                    break;
                default:
                    r += 10;
                    break;
            }

            if (weight < 19)
            {
                r += 10;
            } else if (weight < 49)
            {
                r += 50;
            } else if (weight < 79)
            {
                r += 80;
            } else
            {
                r += 100;
            }

            return r;
        }
    }
}