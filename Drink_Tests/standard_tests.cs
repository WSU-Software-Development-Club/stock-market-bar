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
            drinkController = new DrinkController();
            drinkController.InitializeNewDrinkList(10);
        }

        [Test]
        public void TestCreatingDrinks()
        {
            
        }

        [Test]
        public void TestRemovingDrinks()
        {
            
        }

        [Test]
        public void TestIncreasingPrice()
        {
            
        }

        [Test]
        public void TestDecreasingPrice()
        {
            
        }

        // Check that drinks cannot go negative in price
        [Test]
        public void TestNegativePrice()
        {
            
        }

        [Test]
        public void TestIncreasePrice()
        {
        }
    }
}