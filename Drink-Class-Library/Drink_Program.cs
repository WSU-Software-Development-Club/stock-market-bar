using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink_Class_Library
{
    class Drink_Program
    {
        static void Main(string[] args)
        {
            // Initialize the drink list with the number of levels as parameter
            DrinkList drinkList = new DrinkList(9);

            // Add some drinks
            drinkList.AddDrink(new Drink("Mojito", 5.00));
            drinkList.AddDrink(new Drink("Martini", 7.50));
            drinkList.AddDrink(new Drink("Old Fashioned", 8.00));
            drinkList.AddDrink(new Drink("Vodka Soda", 6.00));

            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                
                int randomNumber = rand.Next(1, 10);
                if (randomNumber == 1)
                {
                    Drink drink = drinkList.drinks[0];
                    drinkList.drink_bought(drink);
                }
                else if (randomNumber == 2 || randomNumber == 3)
                {
                    Drink drink = drinkList.drinks[1];
                    drinkList.drink_bought(drink);
                }
                else if (randomNumber <= 6)
                {
                    Drink drink = drinkList.drinks[2];
                    drinkList.drink_bought(drink);
                }
                else if (randomNumber <= 10)
                {
                    Drink drink = drinkList.drinks[3];
                    drinkList.drink_bought(drink);
                }

                Console.WriteLine(drinkList.drinks[0].name + " total sales: " + drinkList.drinks[0].sales_count + " price level: " + drinkList.drinks[0].price_level);
                Console.WriteLine(drinkList.drinks[1].name + " total sales: " + drinkList.drinks[1].sales_count + " price level: " + drinkList.drinks[1].price_level);
                Console.WriteLine(drinkList.drinks[2].name + " total sales: " + drinkList.drinks[2].sales_count + " price level: " + drinkList.drinks[2].price_level);
                Console.WriteLine(drinkList.drinks[3].name + " total sales: " + drinkList.drinks[3].sales_count + " price level: " + drinkList.drinks[3].price_level);
                Console.WriteLine();
            }


        }
    }
}
