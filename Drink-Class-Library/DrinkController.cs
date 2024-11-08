using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Drink_Class_Library
{
    public class DrinkController
    {
        public int total_sales;
        public List<Drink> drink_list;
        private double[] level_probabilities;
        // Maps iterator to price level
        private int[] levels;

        // Timer
        private Timer marketCrashTimer;

        // Basic constructor - needs adjusted
        public DrinkController(int num_of_levels) 
        { 
            Console.WriteLine("Project Linked");
            total_sales = 0;

            // Initialize drink_list with number of levels that the drink can move between
            drink_list = new List<Drink>();
            drink_list = InitializeDrinkList();
            levels = create_levels(num_of_levels);
            level_probabilities = create_usable_percentages(num_of_levels);

            InitializeMarketCrashTimer();
        }

        private void InitializeMarketCrashTimer(){
            marketCrashTimer = new Timer(60*60*1000); // 1 hour (ms)
            marketCrashTimer.Elapsed += onMarketCrash;
            marketCrashTimer.AutoReset = true;
            marketCrashTimer.Enabled = true;
        }

        // Market crash event: reduces all prices by a random amount
        private void OnMarketCrash(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Market crash event triggered.");
            ApplyMarketCrash(-0.25, -1.00); // Drop prices by amount between -0.25 and -1.00
        }

        private void ApplyMarketCrash(double minDrop, double maxDrop)
        {
            Random rand = new Random();
            foreach (var drink in drink_list)
            {
                double priceReduction = minDrop + (rand.NextDouble() * (maxDrop - minDrop));
                drink.adjust_price(priceReduction);
            }
            Console.WriteLine("Market crash applied. All prices reduced.");
        }

        // Early version of initialize drink list
        public List<Drink> InitializeDrinkList()
        {
            List<Drink> newDrinkList = new List<Drink>();
            newDrinkList.Add(new Drink("Mojito", 5.00));
            newDrinkList.Add(new Drink("Martini", 7.50));
            newDrinkList.Add(new Drink("Old Fashioned", 8.00));
            newDrinkList.Add(new Drink("Vodka Soda", 6.00));
            newDrinkList.Add(new Drink("Moscow Mule", 6.00));

            return newDrinkList;
        }

        // Precondition: num_of_levels must be odd and positive
        private int[] create_levels(int num_of_levels)
        {
            int[] levels = new int[num_of_levels];
            int mid_point = num_of_levels / 2;

            for (int i = -mid_point; i <= mid_point; i++)
            {
                levels[i + mid_point] = i;
            }

            return levels;
        }

        // This function will make it easier for the admin to control what percentage of drinks occupy each level
        private double[] create_usable_percentages(int num_of_levels)
        {

            double[] level_probs = new double[num_of_levels];
            double level_percentage = (100 / (double)levels.Length) / 100;
            double total = 0;
            for (int i = 0; i < levels.Count(); i++)
            {
                Console.WriteLine(i + ": " + total);
                level_probs[i] = total;
                total += level_percentage;
            }
            return level_probs;
        }

        // Change drink price
        public void ChangeDrinkPrice(string drink_name, double price)
        {
            for (int i = 0; i < drink_list.Count; i++)
            {
                if (drink_list[i].name == drink_name)
                {
                    drink_list[i].price = price;
                }
            }
        }

        // Finds drink by name
        public Drink? find_drink_by_name(string name)
        {
            return drink_list.FirstOrDefault(d => d.name == name);
        }

        // This code will run everytime the drink is bought
        public void drink_bought(Drink drink)
        {
            // Increase total drink sales
            total_sales++;
            // Record the sale within Drink class
            drink.record_drink_sale(total_sales);

            // Check if the drink level needs to be updated
            for (int i = 0; i < drink_list.Count(); i++)
            {
                check_for_level_change(drink_list[i]);
            }


            return;

        }

        // Adjust drink's price level based on popularity
        private void AdjustPriceLevel(Drink drink)
        {
            double target_sales = (double)total_sales / drink_list.Count;
            double popularity_score = (double)drink.sales_count / target_sales;
            double probability_score = Math.Clamp(popularity_score / 2, 0.0, 0.9);

            for (int i = level_probabilities.Length - 1; i >= 0; i--)
            {
                if (level_probabilities[i] <= probability_score)
                {
                    if (levels[i] > drink.price_level)
                    {
                        drink.increase_price();
                    }
                    else if (levels[i] < drink.price_level)
                    {
                        drink.decrease_price();
                    }
                    return;
                }
            }
        }

    }
}
