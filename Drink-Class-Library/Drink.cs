namespace Drink_Class_Library
{
    public class Drink
    {
        public string name { get; set; }
        public double price;
        private double initial_price;
        public int sales_count { get; private set; }

        private int price_level = 0;
        private int max_level = 4;
        private int min_level = -4;


        public Drink(string drink_name, double price)
        {
            this.name = drink_name;
            this.price = price;
            this.initial_price = price;
            this.sales_count = 0;


        }

        public void record_drink_sale(int total_sales)
        {
            sales_count++;
            adjust_price(total_sales);
        }

        private void adjust_price(int total_sales)
        {

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
