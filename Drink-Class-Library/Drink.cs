namespace Drink_Class_Library
{
    public class Drink
    {
        public string name { get; set; }

        public double price;
        public double initial_price;
        public int sales_count { get; private set; }

        public int price_level { get; private set; }
        public bool varies;


        public Drink(string drink_name, double price)
        {
            this.name = drink_name;
            this.price = price;
            this.initial_price = price;
            this.sales_count = 0;
            this.price_level = 0;
            this.varies = true;

        }

        
        public void set_initial_price(double new_price)
        {
            this.initial_price = new_price;
        }

        public string getNameAndPrice()
        {
            return this.name + ", $" + this.initial_price.ToString("F2");
        }

        public string getMenuOptions(int levels)
        {
            if (varies)
            {
                double half_levels = (levels - 1) / 2;
                double max_price = this.initial_price + (half_levels * .25);
                double min_price = this.initial_price - (half_levels * .25);
                return this.name + "; Max Price: $" + max_price.ToString("F2") + ", Min Price: $" + min_price.ToString("F2");
            }
            else
            {
                return this.name + "; Permanent Price: $" + this.initial_price.ToString("F2");
            }
        }

        public void changeVariation()
        {
            if (varies)
            {
                this.varies = false;
            }
            else
            {
                this.varies = true;
            }
            return;
        }

        public void record_drink_sale(int total_sales)
        {
            sales_count++;
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
