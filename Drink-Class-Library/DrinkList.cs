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

        private double[] level_probabilities;
        // Maps iterator to price level
        private int[] levels;

        

        // Constructor
        public DrinkList(int num_of_levels)
        {
            total_sales = 0;
            drinks = new List<Drink>();
            levels = create_levels(num_of_levels);
            level_probabilities = create_usable_percentages(num_of_levels);
            
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

        // This function will calcaute a popularity score by comparing it to total sales and seeing if it should move up or down
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


    }
}
