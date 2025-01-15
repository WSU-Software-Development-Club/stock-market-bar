using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink_Class_Library
{
    public class DrinkController
    {
        public int total_sales;
        private SalesService _salesService;
        public DrinkRepository drinkRepository;

        // List of 50 random names and associated price
        private List<(string, double)> drinksWithPrices = new List<(string, double)>
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

        // Basic constructor - needs adjusted
        public DrinkController() 
        {
            Console.WriteLine("Project Linked");

            total_sales = 250;

            drinkRepository = new DrinkRepository();
            // For Development Purposes only
            InitializeNewDrinkList(10);
            // Remove for deliverable
            _salesService = new SalesService(drinkRepository);
        }

        public void drink_bought(string drink_name)
        {
            total_sales++;
            _salesService.drink_bought(drink_name, total_sales);
        }

        public void InitializeNewDrinkList(int count)
        {
            drinkRepository.GenerateDrinkList(count);
        }


        public void AddDrink(string name, double price)
        {
            var drink = new Drink(name, price);
            drinkRepository.AddDrink(drink);
        }

        public void RemoveDrink(string name)
        {
            var drink = drinkRepository.GetDrinkByName(name);
            if (drink != null)
            {
                drinkRepository.RemoveDrink(drink);
            }
        }

        public void UpdateDrinkPrice(string name, double newPrice)
        {
            drinkRepository.UpdateDrinkPrice(name, newPrice);
        }

        public List<Drink> GetAllDrinks()
        {
            return drinkRepository.GetAllDrinks();
        }    

        public List<(string, string)> returnDrinkNamesAndPrices()
        {
            return drinkRepository.returnDrinkListText();
        }

    }
}
