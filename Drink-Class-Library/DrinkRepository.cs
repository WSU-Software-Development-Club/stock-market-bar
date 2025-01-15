using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Drink_Class_Library
{
    public class DrinkRepository
    {

        // List of generated drinks names and prices (demonstration purposes only)
        List<(string, double)> drinksWithPrices = new List<(string, double)>
        {
            ("Mojito", 8.50),
            ("Cosmopolitan", 10.00),
            ("Margarita", 9.25),
            ("Old Fashioned", 11.00),
            ("Pina Colada", 8.75),
            ("Martini", 12.00),
            ("Daiquiri", 9.00),
            ("Mai Tai", 10.50),
            ("Manhattan", 11.50),
            ("Whiskey Sour", 9.75),
            ("Bloody Mary", 8.00),
            ("Negroni", 10.75),
            ("Gin and Tonic", 7.50),
            ("Rum Punch", 9.50),
            ("Tequila Sunrise", 8.25),
            ("Long Island Iced Tea", 11.25),
            ("Moscow Mule", 9.00),
            ("Sangria", 8.50),
            ("Blue Lagoon", 10.00),
            ("Irish Coffee", 8.75),
            ("Amaretto Sour", 9.25),
            ("Caipirinha", 10.00),
            ("Bellini", 8.00),
            ("Aperol Spritz", 9.75),
            ("French 75", 10.50),
            ("Paloma", 8.50),
            ("Tom Collins", 9.25),
            ("White Russian", 10.25),
            ("Black Russian", 9.00),
            ("Sidecar", 10.75),
            ("Hurricane", 11.00),
            ("Mint Julep", 8.75),
            ("Pisco Sour", 9.50),
            ("Zombie", 11.50),
            ("Gin Fizz", 9.25),
            ("Cuba Libre", 8.00),
            ("Sazerac", 12.00),
            ("Espresso Martini", 10.75),
            ("Vesper", 11.25),
            ("Bee's Knees", 9.50),
            ("Bourbon Smash", 10.00),
            ("Clover Club", 8.75),
            ("Dark and Stormy", 9.75),
            ("Gin Rickey", 7.75),
            ("Vodka Collins", 8.25),
            ("Planter's Punch", 9.50),
            ("Bramble", 10.00),
            ("Highball", 8.50),
            ("Rum Swizzle", 9.00),
            ("Southside", 10.25),
            ("Shirley Temple", 6.50)
        };
        private List<Drink> _drinkList;
        private int _numOfDrinks;

        private int _shortTermCount = 2;
        private int _longTermCount = 25;

        public DrinkRepository()
        {
            _drinkList = new List<Drink>();

        }

        public List<Drink> GetAllDrinks() => _drinkList;

        // Returns the name and price of each drink in the list
        public List<(string, string)> returnDrinkListText()
        {
            List<(string, string)> returned_drinks = new List<(string, string)>();
            foreach (Drink drink in this._drinkList)
            {
                returned_drinks.Add((drink.name, drink.price.ToString("F2")));
            }
            return returned_drinks;
        }

        // Returns the name and price of 1 drink in the list
        public string returnDrinkText(Drink drink)
        {
            return drink.name + " " + drink.price.ToString("F2");
        }

        public void AddDrink(Drink drink)
        {
            _drinkList.Add(drink);
        }

        public void RemoveDrink(Drink drink)
        {
            _drinkList.Remove(drink);
        }

        public void RemoveDrinkAtIndex(int index)
        {
            _drinkList.RemoveAt(index);
        }

        public Drink? GetDrinkByName(string name)
        {
            return _drinkList.FirstOrDefault(d => d.name == name);
        }

        public Drink? GetDrinkByIndex(int index)
        {
            if (index >= 0 && index < _drinkList.Count)  // Check if index is within bounds
            {
                return _drinkList[index];  // Return the drink at the specified index
            }
            return null;  // Return null if the index is out of bounds
        }

        public void UpdateDrinkPrice(string drinkName, double newPrice)
        {
            Drink? drink = GetDrinkByName(drinkName);
            if (drink != null)
            {
                drink.set_initial_price(newPrice);
            }
        }

        public void UpdateDrinkName(string oldName, string newName)
        {
            Drink? drink = GetDrinkByName(oldName);
            if (drink != null)
            {
                drink.name = newName;
            }
        }

        public void UpdateDrink(Drink drink)
        {
            var existingDrink = GetDrinkByName(drink.name);
            if (existingDrink != null)
            {
                existingDrink.price = drink.price;
                existingDrink.sales_count = drink.sales_count;
            }
        }

        public void ChangeVariation(Drink drink)
        {
            var existingDrink = GetDrinkByName(drink.name);
            if (existingDrink != null)
            {
                existingDrink.varies = !existingDrink.varies;
            }
        }

        public List<Drink> GenerateDrinkList(int count)
        {
            // Final Drink List
            List<Drink> balancedDrinkList = new List<Drink>();
            Random rand = new Random();

            // Define Hashset to keep uniqueness
            HashSet<int> selectedIndices = new HashSet<int>();

            // Need 10 drinks
            while (balancedDrinkList.Count < count)
            {
                // Get random number
                int randomNumber = rand.Next(0, this.drinksWithPrices.Count);
                // Check for uniqueness
                if (!selectedIndices.Contains(randomNumber))
                {
                    // Add randomnumber to hashset
                    selectedIndices.Add(randomNumber);

                    // Define drink properties
                    string drink_name = this.drinksWithPrices[randomNumber].Item1;
                    double drink_price = this.drinksWithPrices[randomNumber].Item2;
                    // Define new Drink
                    Drink newDrink = new Drink(drink_name, drink_price);

                    // Add to list
                    balancedDrinkList.Add(newDrink);
                }
            }

            _drinkList = balancedDrinkList;
            return balancedDrinkList;
        }

        
    }
}
