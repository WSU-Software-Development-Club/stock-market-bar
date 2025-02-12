﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink_Class_Library
{
    public class SalesService
    {
        private DrinkRepository _drinkRepository;
        private DrinkAlgorithm _algorithm;
        private Queue<Drink> _shortTermDrinkQueue;
        private Queue<Drink> _longTermDrinkQueue;
        private int _numOfDrinks;

        public Queue<Drink> GetShortTermQueue() => _shortTermDrinkQueue;
        // Subject to change
        private int _shortTermCount = 2;
        public int GetShortTermCount() => _shortTermCount;
        public Queue<Drink> GetLongTermQueue() => _longTermDrinkQueue;
        // Subject to change
        private int _longTermCount = 20;
        public int GetLongTermCount() => _longTermCount;

        // Keeps track of how much sales deviate from normal sale amount
        private double averageSaleDifferentiation;
        public double GetAverageSaleDifferentitation => averageSaleDifferentiation;
        // Keeps track of total sales
        private double total_sales_amount;
        public double GetTotalSalesAmount => total_sales_amount;

        public SalesService(DrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
            _numOfDrinks = drinkRepository.GetAllDrinks().Count;
            _shortTermDrinkQueue = new Queue<Drink>(_numOfDrinks * _shortTermCount);
            _longTermDrinkQueue = new Queue<Drink>(_numOfDrinks * _longTermCount);
            populateDrinkQueues();
        }

        // This code will run everytime the drink is bought
        public void drink_bought(string drink_name, int total_sales)
        {

            var drink = _drinkRepository.GetDrinkByName(drink_name);
            if (drink == null) throw new Exception("Drink not found.");

            drink.sales_count++;
            this.RecordSale(drink.price, drink.initial_price);

            if (_shortTermDrinkQueue.Count >= _numOfDrinks * _shortTermCount)
            {
                _shortTermDrinkQueue.Dequeue();
            }
            if (_longTermDrinkQueue.Count >= _numOfDrinks * _longTermCount)
            {
                _longTermDrinkQueue.Dequeue();
            }

            _shortTermDrinkQueue.Enqueue(drink);
            _longTermDrinkQueue.Enqueue(drink);

            if (total_sales % 10 == 0)
            {
                // Run drink algorithm (runs automatically in constructor)
                DrinkAlgorithm drinkAlgorithm = new DrinkAlgorithm(this._drinkRepository, this);
            }

            return;

        }

        // Function to help keep track of sales in salesService
        private void RecordSale(double drink_price, double original_price)
        {
            double price_difference = drink_price - original_price;
            averageSaleDifferentiation += price_difference;
            total_sales_amount += drink_price;
        }

        private void populateDrinkQueues()
        {
            // Add # counted for short term
            for (int i = 0; i < this._shortTermCount; i++)
            {
                // Add each drink
                for (int j = 0; j < this._numOfDrinks; j++)
                {
                    _shortTermDrinkQueue.Enqueue(_drinkRepository.GetDrinkByIndex(j));
                }
            }
            // Add # counted for long term
            for (int i = 0; i < this._longTermCount; i++)
            {
                // Add each drink
                for (int j = 0; j < this._numOfDrinks; j++)
                {
                    _longTermDrinkQueue.Enqueue(_drinkRepository.GetDrinkByIndex(j));
                }
            }

            // Now each drink queue is populated with even number of drinks spread out evenly

        }

        
    }
}
