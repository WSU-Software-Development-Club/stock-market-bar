using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink_Class_Library
{
    internal class DrinkList
    {

        private List<Drink> drinks;
        public int total_sales = 0;

        public DrinkList()
        {
            drinks = new List<Drink>();
        }

        public void AddDrink(Drink drink)
        {
            drinks.Add(drink);
        }

        private Drink FindDrinkByName(string name)
        {
            return drinks.Find(d => d.name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void DisplayDrinks()
        {
            foreach (var drink in drinks)
            {
                Console.WriteLine(drink);
            }
        }
    }
}
