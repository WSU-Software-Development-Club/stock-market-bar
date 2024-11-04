namespace Drink_Class_Library
{
    public class Drink
    {
        public int ID { get; set; }
        public string name { get; set; }
        public double price;
        private double initial_price;
        private double percentage_threshold;
        private double initial_threshold;

        private int price_level;

        public Drink(int ID, string drink_name, double price)
        {
            this.ID = ID;
            this.name = drink_name;
            this.price = price;
            this.initial_price = price;
            this.percentage_threshold = -1.0;
            this.initial_threshold = -1.0;
            this.price_level = 0;

        }

        public double increase_price()
        {
            this.price_level++;
            this.price += .25;

            return this.price;

        }

        public double decrease_price()
        {
            this.price_level--;
            this.price -= .25;

            return this.price;
        }
    }
}
