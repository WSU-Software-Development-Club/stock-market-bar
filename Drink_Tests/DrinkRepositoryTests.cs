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
    public class DrinkRepositoryTests
    {
        private DrinkRepository _repository;

        [SetUp]
        public void Setup()
        {
            _repository = new DrinkRepository();
        }

        [Test]
        public void Test_GetDrinkByName_NormalCase()
        {
            _repository.AddDrink(new Drink("Margarita", 9.25));
            var result = _repository.GetDrinkByName("Margarita");
            Assert.IsNotNull(result);
            Assert.AreEqual("Margarita", result.name);
        }

        [Test]
        public void Test_GetDrinkByName_EmptyList()
        {
            var result = _repository.GetDrinkByName("Margarita");
            Assert.IsNull(result);
        }

        [Test]
        public void Test_GetDrinkByName_EmptyInput()
        {
            _repository.AddDrink(new Drink("Margarita", 9.25));
            var result = _repository.GetDrinkByName("");
            Assert.IsNull(result);
        }

        [Test]
        public void Test_GetDrinkByName_ErrorInput()
        {
            _repository.AddDrink(new Drink("Margarita", 9.25));
            var result = _repository.GetDrinkByName("Unknown Drink");
            Assert.IsNull(result);
        }

        [Test]
        public void Test_GetDrinkByInput_Normal()
        {
            _repository.AddDrink(new Drink("Margarita", 9.25));
            var result = _repository.GetDrinkByIndex(0);
            Assert.IsNotNull(result);
            Assert.AreEqual("Margarita", result.name);
        }

        [Test]
        public void Test_GetDrinkByIndex_EmptyList()
        {
            var result = _repository.GetDrinkByIndex(0);
            Assert.IsNull(result);
        }

        [Test]
        public void Test_GetDrinkByIndex_OutOfBounds()
        {
            var result = _repository.GetDrinkByIndex(5);
            Assert.IsNull(result);
        }

        [Test]
        public void Test_GetDrinkByIndex_OutOfBoundsNegative()
        {
            var result = _repository.GetDrinkByIndex(-5);
            Assert.IsNull(result);
        }

        [Test]
        public void Test_RemoveDrinkAtIndex_Normal()
        {
            // Arrange
            _repository.AddDrink(new Drink("Vodka Soda", 9.00));
            _repository.AddDrink(new Drink("Margarita", 9.25));

            // Act
            _repository.RemoveDrinkAtIndex(0);  // Remove the first drink ("Vodka Soda")

            // Assert
            Assert.AreEqual(1, _repository.GetAllDrinks().Count);  // Ensure one drink remains
            Assert.AreEqual("Margarita", _repository.GetDrinkByIndex(0)?.name);  // Check the remaining drink is "Margarita"
        }

        [Test]
        public void Test_RemoveDrinkAtIndex_EmptyList()
        {
            _repository.RemoveDrinkAtIndex(0);
            Assert.AreEqual(0, _repository.GetAllDrinks().Count);  // List should remain empty
        }

        [Test]
        public void Test_RemoveDrinkAtIndex_OutOfBounds()
        {
            _repository.RemoveDrinkAtIndex(5);
            Assert.AreEqual(0, _repository.GetAllDrinks().Count);  // List should remain empty
        }

        // Test Cases for UpdateDrinkPrice
        [Test]
        public void Test_UpdateDrinkPrice_NormalCase()
        {
            _repository.AddDrink(new Drink("Margarita", 9.25));
            _repository.UpdateDrinkPrice("Margarita", 12.00);
            Assert.AreEqual(12.00, _repository.GetDrinkByName("Margarita").initial_price);
        }

        [Test]
        public void Test_UpdateDrinkPrice_EmptyString()
        {
            _repository.AddDrink(new Drink("Margarita", 9.25));
            _repository.UpdateDrinkPrice("", 15.00);
            Assert.AreEqual(9.25, _repository.GetDrinkByName("Margarita").price);  // No change
        }

        [Test]
        public void Test_UpdateDrinkPrice_NonExistentDrink()
        {
            _repository.UpdateDrinkPrice("NonExistent", 10.00);
            Assert.IsNull(_repository.GetDrinkByName("NonExistent"));
        }

        // Test Cases for AddDrink
        [Test]
        public void Test_AddDrink_NormalCase()
        {
            var newDrink = new Drink("Mocktail", 5.00);
            _repository.AddDrink(newDrink);
            Assert.AreEqual(1, _repository.GetAllDrinks().Count);
            Assert.AreEqual("Mocktail", _repository.GetDrinkByName("Mocktail").name);
        }

        [Test]
        public void Test_AddDrink_NullDrink_ThrowsException()
        {
            _repository.AddDrink(null);
            // Assert that an ArgumentNullException is thrown when trying to add a null drink
            Assert.AreEqual(0, _repository.GetAllDrinks().Count);
        }

        [Test]
        public void Test_AddDrink_DuplicateDrink()
        {
            var drink = new Drink("Margarita", 9.25);
            _repository.AddDrink(drink);
            _repository.AddDrink(drink);  // Add same drink again
            Assert.AreEqual(2, _repository.GetAllDrinks().Count);  // List count increased by 2
        }

        // Test Cases for returnDrinkListText
        [Test]
        public void Test_returnDrinkListText_NormalCase()
        {
            _repository.AddDrink(new Drink("Margarita", 9.25));
            _repository.AddDrink(new Drink("Old Fashioned", 11.00));
            var result = _repository.returnDrinkListText();
            Assert.AreEqual(2, result.Count);
            Assert.Contains(("Margarita", "9.25"), result);
            Assert.Contains(("Old Fashioned", "11.00"), result);
        }

        [Test]
        public void Test_returnDrinkListText_EmptyList()
        {
            var result = _repository.returnDrinkListText();
            Assert.AreEqual(0, result.Count);
        }
    }
}
