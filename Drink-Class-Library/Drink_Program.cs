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
            DrinkController drinkList = new DrinkController(9);

            drinkList.InitializeDrinkList();

            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                
                int randomNumber = rand.Next(1, 10);
                if (randomNumber == 1)
                {
                    Drink drink = drinkList.drink_list[0];
                    drinkList.drink_bought(drink);
                }
                else if (randomNumber == 2 || randomNumber == 3)
                {
                    Drink drink = drinkList.drink_list[1];
                    drinkList.drink_bought(drink);
                }
                else if (randomNumber <= 6)
                {
                    Drink drink = drinkList.drink_list[2];
                    drinkList.drink_bought(drink);
                }
                else if (randomNumber <= 10)
                {
                    Drink drink = drinkList.drink_list[3];
                    drinkList.drink_bought(drink);
                }

                Console.WriteLine(drinkList.drink_list[0].name + " total sales: " + drinkList.drink_list[0].sales_count + " price level: " + drinkList.drink_list[0].price_level);
                Console.WriteLine(drinkList.drink_list[1].name + " total sales: " + drinkList.drink_list[1].sales_count + " price level: " + drinkList.drink_list[1].price_level);
                Console.WriteLine(drinkList.drink_list[2].name + " total sales: " + drinkList.drink_list[2].sales_count + " price level: " + drinkList.drink_list[2].price_level);
                Console.WriteLine(drinkList.drink_list[3].name + " total sales: " + drinkList.drink_list[3].sales_count + " price level: " + drinkList.drink_list[3].price_level);
                Console.WriteLine();
            }


        }
    }
}
