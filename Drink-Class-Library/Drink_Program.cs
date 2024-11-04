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
            // Initialize the drink list
            DrinkList drinkList = new DrinkList();

            // Add some drinks
            drinkList.AddDrink(new Drink("Mojito", 5.00));
            drinkList.AddDrink(new Drink("Martini", 7.50));
            drinkList.AddDrink(new Drink("Old Fashioned", 8.00));


        }
    }
}
