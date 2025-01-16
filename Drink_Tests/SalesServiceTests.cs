using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drink_Class_Library;
using NUnit.Framework;

namespace Drink_Tests
{
    [TestFixture]
    public class SalesServiceTests
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

        // Test Cases for drink_bought
        [Test]
        public void Test_drink_bought_NormalCase()
        {
            // Act
            _salesService.drink_bought("Margarita", 1);

            // Assert
            Assert.AreEqual(1, _drinkRepository.GetDrinkByName("Margarita").sales_count);  // Drink sales count increased
            Assert.AreEqual(9.25, _salesService.GetTotalSalesAmount);  // Total sales updated
        }

        [Test]
        public void Test_drink_bought_EmptyDrinkName()
        {
            // Act & Assert
            Assert.Throws<Exception>(() => _salesService.drink_bought("", 1), "Drink not found.");
        }

        [Test]
        public void Test_drink_bought_NonExistentDrink()
        {
            // Act & Assert
            Assert.Throws<Exception>(() => _salesService.drink_bought("NonExistentDrink", 1), "Drink not found.");
        }

        [Test]
        public void Test_drink_bought_EmptyDrinkList()
        {
            // Arrange
            var emptyRepo = new DrinkRepository();  // No drinks added
            var salesService = new SalesService(emptyRepo);

            // Act & Assert
            Assert.Throws<Exception>(() => salesService.drink_bought("Margarita", 1), "Drink not found.");
        }

        // Test Cases for RecordSale (indirectly tested in drink_bought)
        [Test]
        public void Test_RecordSale_NormalPriceDifference()
        {
            _salesService.drink_bought("Margarita", 1);

            // Assert average sale differentiation is 0 since the drink was sold at its original price
            Assert.AreEqual(0, _salesService.GetAverageSaleDifferentitation);
        }

        [Test]
        public void Test_RecordSale_PriceDifference()
        {
            _drinkRepository.UpdateDrinkPrice("Margarita", 10.25);  // Increase price
            _salesService.drink_bought("Margarita", 1);

            // Assert
            Assert.AreEqual(-1.00, _salesService.GetAverageSaleDifferentitation);  // Difference: 10.25 - 9.25
            Assert.AreEqual(9.25, _salesService.GetTotalSalesAmount);  // Total sales updated
        }

        // Test Cases for Queues
        [Test]
        public void Test_ShortTermQueue_Population()
        {
            // Assert
            Assert.AreEqual(6, _salesService.GetShortTermQueue().Count);  // 3 drinks * short-term count of 2
        }

        [Test]
        public void Test_LongTermQueue_Population()
        {
            // Assert
            Assert.AreEqual(60, _salesService.GetLongTermQueue().Count);  // 3 drinks * long-term count of 20
        }

        [Test]
        public void Test_Queue_AfterDrinkBought()
        {
            // Act
            _salesService.drink_bought("Margarita", 1);

            // Assert
            Assert.AreEqual(6, _salesService.GetShortTermQueue().Count);  // Short-term queue size after adding 1 drink
            Assert.AreEqual(60, _salesService.GetLongTermQueue().Count);  // Long-term queue size after adding 1 drink
        }

        // Edge Case: Remove from full queues
        [Test]
        public void Test_Queue_DequeueWhenFull()
        {
            // Fill queues to max capacity
            for (int i = 0; i < 100; i++)
            {
                _salesService.drink_bought("Margarita", i + 1);
            }

            // Assert short-term queue has max capacity after dequeuing and enqueuing
            Assert.AreEqual(6, _salesService.GetShortTermQueue().Count);  // Remains consistent at short-term max size
            Assert.AreEqual(60, _salesService.GetLongTermQueue().Count);  // Remains consistent at long-term max size
        }

        // Test Cases for populateDrinkQueues
        [Test]
        public void Test_populateDrinkQueues_EmptyDrinkList()
        {
            var emptyRepo = new DrinkRepository();  // No drinks added
            var emptySalesService = new SalesService(emptyRepo);

            // Assert
            Assert.AreEqual(0, emptySalesService.GetShortTermQueue().Count);  // No drinks to populate queues
            Assert.AreEqual(0, emptySalesService.GetLongTermQueue().Count);
        }
    }
}
