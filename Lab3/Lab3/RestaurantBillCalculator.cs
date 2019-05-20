using System;
using System.IO;

namespace Lab3
{
    public static class RestaurantBillCalculator
    {
        public static double CalculateTotalCost(StreamReader input)
        {
            const int NUMBER_OF_FOOD = 5;
            double[] prices = new double[NUMBER_OF_FOOD];

            for (int i = 0; i < NUMBER_OF_FOOD; ++i)
            {
                prices[i] = double.Parse(input.ReadLine());
            }

            int tipRate = int.Parse(input.ReadLine());

            double totalPrice = 0;

            for (int i = 0; i < NUMBER_OF_FOOD; ++i)
            {
                totalPrice += prices[i];
            }

            double totalCost = Math.Round(totalPrice * 1.05 * (1 + tipRate / 100.0), 2);

            return totalCost;
        }

        public static double CalculateIndividualCost(StreamReader input, double totalCost)
        {
            int numberOfPayer = int.Parse(input.ReadLine());
            double indivisualCost = Math.Round(totalCost / numberOfPayer, 2);
            return indivisualCost;
        }

        public static uint CalculatePayerCount(StreamReader input, double totalCost)
        {
            double indivisualCost = double.Parse(input.ReadLine());
            uint numberOfPayer = (uint)Math.Ceiling(totalCost / indivisualCost);
            return numberOfPayer;
        }
    }
}