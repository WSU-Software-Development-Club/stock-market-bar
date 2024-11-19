using Drink_Class_Library;

namespace Drink_Tests
{
    public class Tests
    {
        public DrinkController drinkController { get; set; }
        Drink test_drink1 = new Drink("Vodka", 5.00);
        Drink test_drink2 = new Drink("Rum", 3.00);
        Drink empty_drink = new Drink("", 0.00);
        [SetUp]
        public void Setup()
        {
            drinkController = new DrinkController(9);
        }

        [Test]
        public void TestCreatingDrinks()
        {
            List<(string, string)> drinks = new List<(string, string)>();

            drinkController.drink_list.Clear();
            drinkController.drink_list.Add(test_drink1);

            drinks = drinkController.returnDrinkList();
            Assert.AreEqual(drinks[0], ("Vodka", "5.00"));
        }

        [Test]
        public void TestRemovingDrinks()
        {
            List<(string, string)> drinks = new List<(string, string)>();

            drinkController.drink_list.Clear();
            drinkController.drink_list.Add(test_drink1);
            drinkController.drink_list.Remove(test_drink1);

            drinks = drinkController.returnDrinkList();
            Assert.AreEqual(drinks.Count(), 0);
        }

        [Test]
        public void TestIncreasingPrice()
        {
            List<(string, string)> drinks = new List<(string, string)>();

            drinkController.drink_list.Clear();
            drinkController.drink_list.Add(test_drink1);
            drinkController.drink_list[0].increase_price();

            drinks = drinkController.returnDrinkList();
            Assert.AreEqual(drinks[0], ("Vodka", "5.25"));
            drinkController.drink_list[0].decrease_price();
        }

        [Test]
        public void TestDecreasingPrice()
        {
            List<(string, string)> drinks = new List<(string, string)>();

            drinkController.drink_list.Clear();
            drinkController.drink_list.Add(test_drink1);
            drinkController.drink_list[0].decrease_price();

            drinks = drinkController.returnDrinkList();
            Assert.AreEqual(drinks[0], ("Vodka", "4.75"));
            drinkController.drink_list[0].increase_price();
        }

        // Check that drinks cannot go negative in price
        [Test]
        public void TestNegativePrice()
        {
            List<(string, string)> drinks = new List<(string, string)>();

            drinkController.drink_list.Clear();
            drinkController.drink_list.Add(empty_drink);
            drinkController.drink_list[0].decrease_price();

            drinks = drinkController.returnDrinkList();
            Assert.AreEqual(drinks[0], ("", "0.00"));
            drinkController.drink_list[0].increase_price();
        }

        [Test]
        public void TestIncreasePrice()
        {
            List<(string, string)> drinks = new List<(string, string)>();

            drinkController.drink_list.Clear();
            drinkController.drink_list.Add(test_drink2);
            for (int i = 0; i < 100; i++)
            {
                if (drinkController.drink_list[0].price_level < 4)
                {
                    drinkController.drink_list[0].increase_price();
                }
               
            }

            drinks = drinkController.returnDrinkList();
            Assert.AreEqual(drinks[0], ("Rum", "4.00"));
            for (int i = 0; i < 4; i++)
            {
                if (drinkController.drink_list[0].price_level < 4)
                {
                    drinkController.drink_list[0].decrease_price();
                }

            }
        }
    }
}