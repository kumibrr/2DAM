namespace _007_Electrodomesticos
{
    public class Appliance
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
            this.powerEfficiency = comprobarConsumoEnergetico(powerEfficiency);
            this.color = color;
            precioFinal();
        }

        public double getPrice() 
        {
            return basePrice;
        }

        public char getPowerEfficiency()
        {
            return powerEfficiency;
        }

        public double getWeight() 
        {
            return weight;
        }

        public Color getColor() 
        {
            return color;
        }

        private char comprobarConsumoEnergetico(char letra)
        {
            char r = letra < 'F' ? letra : 'F';
            return r;
        }
        
        // El método "ComprobarColor no es necesario al haber hecho uso de un enum para identificar el color."
        public double precioFinal()
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