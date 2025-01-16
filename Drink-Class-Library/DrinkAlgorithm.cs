using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink_Class_Library
{
    public class DrinkAlgorithm
    {
        private DrinkRepository _drinkRepository;
        private Queue<Drink> _shortTermDrinkQueue;
        private Queue<Drink> _longTermDrinkQueue;
        private int shortTermCount;
        private int longTermCount;

        public DrinkAlgorithm(DrinkRepository drinkRepository, SalesService salesService)
        {
            _shortTermDrinkQueue = salesService.GetShortTermQueue();
            _longTermDrinkQueue = salesService.GetLongTermQueue();
            shortTermCount = salesService.GetShortTermCount();
            longTermCount = salesService.GetLongTermCount();
            _drinkRepository = drinkRepository;
            UpdateDrinkListPrices();
        }

        // This function is going to occur every 10 seconds
        private void UpdateDrinkListPrices()
        {

            foreach (Drink drink in _drinkRepository.GetAllDrinks())
            {
                // This weight will end up (-100, 100)
                // The weight determines whether the price will move up, down or neither
                // Once the weight is caluclated in this function, it will be checked against it's previous weight (10s ago) to determine the change it needs to make as well as the degree of change
                double final_weight = 0;

                // Short term change
                /* Current Values
                 * Weights given = [(0, -10), (1, 0), (2, 10), (3, 20), etc..]
                 * Amount of drink sales tested = Drink_List.Count * 2
                 */

                // Find number of sales in short term
                
                int shortTermSales = _shortTermDrinkQueue.Count(d => d.name == drink.name);
                double shortTermWeight = -10 * shortTermCount;
                for (int i = 0; i < shortTermSales; i++)
                {
                    shortTermWeight += 10;
                }
                

                // Long term change
                /* 
                 * Current values
                 * Amount of drink sales tested = Drink_List.Count * 20
                 * Weight change per drink off of 20 = +/- 5
                 */
                int longTermSales = _longTermDrinkQueue.Count(d => d.name == drink.name);
                double longTermWeight = (100 / longTermCount) * (longTermSales - longTermCount);

                final_weight = longTermWeight + shortTermWeight;

                double movement_factor = final_weight - drink.previousWeight;

                drink.previousWeight = final_weight;

                // Applies the movement
                /* Current values
                 * Min movement = Movement_factor * .005
                 * Max movement = Movement_factor * .01
                 */
                MoveDrinkPrice(drink, movement_factor);
            }

            return;
        }

        // Moves the drink price based on the movement factor
        private void MoveDrinkPrice(Drink drink, double movement_factor)
        {
            Random rand = new Random();
            double percentMoved = 0;
            if (movement_factor == 0)
            {
                return;
            }
            else if (movement_factor > 0)
            {
                // Drink price moving up
                // Subject to change
                double min_movement = movement_factor * .75;
                // Subject to change
                double max_movement = movement_factor * 1.25;
                percentMoved = min_movement + (max_movement - min_movement) * rand.NextDouble();
            }
            else if (movement_factor < 0)
            {
                // Drink price moving down
                // Subject to change
                double min_movement = movement_factor * 1.25;
                // Subject to change
                double max_movement = movement_factor * .75;
                percentMoved = min_movement + (max_movement - min_movement) * rand.NextDouble();
            }


            // Check to make sure drink varies
            if (drink.varies)
            {
                drink.price += (percentMoved / 100);
            }
            // Set max limits to a dollar each way
            if (1.0 < drink.initial_price - drink.price)
            {
                drink.price = drink.initial_price - 1;
            }
            else if (-1.0 > drink.initial_price - drink.price)
            {
                drink.price = drink.initial_price + 1;
            }
            // Price can't go negative
            if (drink.price < 0)
            {
                drink.price = 0;
            }
        }
    }
}
