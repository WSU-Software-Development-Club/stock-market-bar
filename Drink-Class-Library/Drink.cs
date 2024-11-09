namespace Drink_Class_Library
{
    public class Drink
    {
        public string name { get; set; }
        public double price { get; private set; }
        private double initial_price;
        public int sales_count { get; private set; }

        public int price_level { get; private set; }
        private int max_level = 4;
        private int min_level = -4;

        public double PriceIncreaseAmount{get; private set;} = 0.25;


        public Drink(string drink_name, double price)
        {
            this.name = drink_name;
            this.price = price;
            this.initial_price = price;
            this.sales_count = 0;
            this.price_level = 0;

        }

        public void record_drink_sale(int total_sales)
        {
            sales_count++;
        }

        public void increase_price()
        {
            if(price_level < max_level){
                this.price_level++;
                this.price += PriceIncreaseAmount;
            }

        }

        public void decrease_price()
        {
            if(price_level > min_level){
                this.price_level--;
                this.price -= PriceIncreaseAmount;
            }
        }

        // Adjust price by specific amount without going below initial price
        public void adjust_price(double adjustmentAmount){
            price = Math.Max(initial_price, price + adjustmentAmount);
        }

         // Display drink details for debugging
        public override string ToString()
        {
            return $"{Name} - Price: {CurrentPrice:C2}, Sales: {SalesCount}, Level: {PriceLevel}";
        }
    }
}
