using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink_Class_Library
{
    internal class DrinkList
    {

        public List<Drink> drinks { get; private set; }
        public int total_sales;
        public double[] level_percentages = [10, 10, 15, 10, 10, 10, 15, 10, 10];
        // Threshold for Level [-4, -3, -2, -1, 0, 1, 2, 3, 4]
        // Equates to [10%, 10%, 10%, 10%, 10%, 10%, 10%, 10%, 10%]
        private double[] level_probabilities = [0.0, 0.1, 0.2, 0.35, 0.45, 0.55, 0.65, 0.8, 0.9];
        // Maps iterator to price level
        private int[] levels = [-4, -3, -2, -1, 0, 1, 2, 3, 4];

        // This function will make it easier for the admin to control what percentage of drinks occupy each level
        private void create_usable_percentages()
        {
            double total = 0;
            double percentage = 0;
            for (int i = 0; i < level_percentages.Count(); i++)
            {
                level_probabilities[i] = total;
                percentage = level_percentages[i] / 100;
                total += percentage;
            }
        }

        // Constructor
        public DrinkList()
        {
            total_sales = 0;
            drinks = new List<Drink>();
        }

        // Add drink
        public void AddDrink(Drink drink)
        {
            drinks.Add(drink);
        }

        // Finds drink by name
        public Drink? find_drink_by_name(string name)
        {
            for (int i = 0; i < drinks.Count; i++)
            {
                if (drinks[i].name == name)
                {
                    return drinks[i];
                }
            }
            return null;
        }

        // This code will run everytime the drink is bought
        public void drink_bought(Drink drink)
        {
            // Increase total drink sales
            total_sales++;
            // Record the sale within Drink class
            drink.record_drink_sale(total_sales);

            // Check if the drink level needs to be updated
            for (int i = 0; i < drinks.Count(); i++)
            {
                check_for_level_change(drinks[i]);
            }
            

            return;

        }

        // This function will caclaute a popularity score by comparing it to total sales and seeing if it should move up or down
        private void check_for_level_change(Drink drink)
        {
            // Calculate popularity score using target scores
            double target_sales = (double)total_sales / this.drinks.Count();
            double popularity_score = (double)drink.sales_count / target_sales;

            // Calculate probability score which is a score from 0 to 1 to show how popular the drink is
            double probability_score = popularity_score / 2;
            
            if (probability_score > 0.9)
            {
                probability_score = .9;
            }
            else if (probability_score < 0.0)
            {
                probability_score = 0.0;
            }
            Console.WriteLine(probability_score);

            // Very important function
            // [0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9]
            // [-4, -3, -2, -1, 0, 1, 2, 3, 4]
            // Compares the previously calculated probability score and compares it to level_probabilities to determine what level it should be at
            for (int i = level_probabilities.Count() - 1; i >= 0; i--)
            {
                // If this is true, we have found the level it should be at
                if (level_probabilities[i] <= probability_score)
                {
                    // If the found level is higher than the current level
                    if (levels[i] > drink.price_level)
                    {
                        drink.increase_price();     // Increase by 1
                    }
                    // If the found level is lower than the current level
                    else if (levels[i] < drink.price_level)
                    {
                        drink.decrease_price();     // Decrease by 1
                    }
                    // Else, no changes
                    return;
                }
            }
            return;
        }

        // Display drinks function (in terminal)
        public void DisplayDrinks()
        {
            foreach (var drink in drinks)
            {
                Console.WriteLine(drink);
            }
        }
    }
}
