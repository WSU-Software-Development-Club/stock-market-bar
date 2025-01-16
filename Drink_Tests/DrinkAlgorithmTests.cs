using Drink_Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink_Tests
{
    [TestFixture]
    public class DrinkAlgorithmTests
    {
        private DrinkRepository _drinkRepository;
        private SalesService _salesService;

        [SetUp]
        public void Setup()
        {
            _drinkRepository = new DrinkRepository();
            _drinkRepository.AddDrink(new Drink("Margarita", 9.25));
            _drinkRepository.AddDrink(new Drink("Old Fashioned", 11.00));
            _drinkRepository.AddDrink(new Drink("Vodka Soda", 8.00));
            _salesService = new SalesService(_drinkRepository);
        }

        [Test]
        public void Test_BalancedSalesDistribution()
        {
            for (int i = 0; i < 5; i++)
            {
                _salesService.drink_bought("Margarita", i + 1);
                _salesService.drink_bought("Old Fashioned", i + 1);
                _salesService.drink_bought("Vodka Soda", i + 1);
            }

            var algorithm = new DrinkAlgorithm(_drinkRepository, _salesService);

            Assert.That(_drinkRepository.GetDrinkByName("Margarita").price, Is.GreaterThanOrEqualTo(9.00));
            Assert.That(_drinkRepository.GetDrinkByName("Old Fashioned").price, Is.LessThanOrEqualTo(12.00));
        }

        [Test]
        public void Test_NoSalesInQueues()
        {
            var algorithm = new DrinkAlgorithm(_drinkRepository, _salesService);

            Assert.That(_drinkRepository.GetDrinkByName("Margarita").price, Is.EqualTo(9.25));
            Assert.That(_drinkRepository.GetDrinkByName("Old Fashioned").price, Is.EqualTo(11.00));
        }

        [Test]
        public void Test_HighSalesForSingleDrink()
        {
            for (int i = 0; i < 50; i++)
            {
                _salesService.drink_bought("Margarita", i + 1);
            }

            var algorithm = new DrinkAlgorithm(_drinkRepository, _salesService);

            Assert.That(_drinkRepository.GetDrinkByName("Margarita").price, Is.GreaterThan(9.25));
            Assert.That(_drinkRepository.GetDrinkByName("Old Fashioned").price, Is.LessThan(11.00));
            Assert.That(_drinkRepository.GetDrinkByName("Vodka Soda").price, Is.LessThan(8.00));
        }

        [Test]
        public void Test_RandomizedSalesAcrossDrinks()
        {
            _salesService.drink_bought("Margarita", 1);
            _salesService.drink_bought("Old Fashioned", 2);
            _salesService.drink_bought("Margarita", 3);
            _salesService.drink_bought("Vodka Soda", 4);

            var algorithm = new DrinkAlgorithm(_drinkRepository, _salesService);

            Assert.That(_drinkRepository.GetDrinkByName("Margarita").price, Is.Not.EqualTo(_drinkRepository.GetDrinkByName("Old Fashioned").price));
        }

        [Test]
        public void Test_DrinksWithIdenticalNamesDifferentPrices()
        {
            _drinkRepository.AddDrink(new Drink("Margarita", 10.00));  // Duplicate name, different price

            _salesService.drink_bought("Margarita", 1);

            var algorithm = new DrinkAlgorithm(_drinkRepository, _salesService);

            var drinks = _drinkRepository.GetAllDrinks().Where(d => d.name == "Margarita").ToList();
            Assert.AreEqual(2, drinks.Count);
            Assert.AreNotEqual(drinks[0].price, drinks[1].price);
        }

        [Test]
        public void Test_OneDrinkInRepository()
        {
            var singleDrinkRepo = new DrinkRepository();
            singleDrinkRepo.AddDrink(new Drink("SingleDrink", 8.00));

            var singleDrinkService = new SalesService(singleDrinkRepo);
            singleDrinkService.drink_bought("SingleDrink", 1);

            var algorithm = new DrinkAlgorithm(singleDrinkRepo, singleDrinkService);

            Assert.That(singleDrinkRepo.GetDrinkByName("SingleDrink").price, Is.GreaterThanOrEqualTo(8.00));
        }

        [Test]
        public void Test_AllDrinksSameInitialPrice()
        {
            _drinkRepository = new DrinkRepository();
            _drinkRepository.AddDrink(new Drink("Margarita", 10.00));
            _drinkRepository.AddDrink(new Drink("Old Fashioned", 10.00));
            _drinkRepository.AddDrink(new Drink("Vodka Soda", 10.00));
            _salesService = new SalesService(_drinkRepository);

            var algorithm = new DrinkAlgorithm(_drinkRepository, _salesService);

            Assert.That(_drinkRepository.GetDrinkByName("Margarita").price, Is.EqualTo(_drinkRepository.GetDrinkByName("Old Fashioned").price));
        }

        [Test]
        public void Test_ShortTermQueueFullLongTermQueueEmpty()
        {
            _salesService = new SalesService(_drinkRepository);

            for (int i = 0; i < 6; i++)
            {
                _salesService.drink_bought("Margarita", i + 1);
            }

            var algorithm = new DrinkAlgorithm(_drinkRepository, _salesService);

            Assert.That(_drinkRepository.GetDrinkByName("Margarita").price, Is.GreaterThan(9.25));
        }
    }
}
