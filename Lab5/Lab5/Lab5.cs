using System;

namespace Lab5
{
    public static class Lab5
    {
        public static bool TryFixData(uint[] usersPerDay, double[] revenuePerDay)
        {
            bool isDataFixed = false;

            for (int i = 0; i < usersPerDay.Length; ++i)
            {
                double correctDailyRevenue;
                uint dailyUsers = usersPerDay[i];

                if (dailyUsers > 1000)
                {
                    correctDailyRevenue = 245743 + dailyUsers / 4.0;
                }
                else if (dailyUsers > 100)
                {
                    correctDailyRevenue = dailyUsers * dailyUsers / 4.0 - 2 * dailyUsers - 2007; 
                }
                else if (dailyUsers > 10)
                {
                    correctDailyRevenue = 16 * dailyUsers / 5.0 - 27;
                }
                else
                {
                    correctDailyRevenue = dailyUsers / 2.0;
                }

                correctDailyRevenue = Math.Round(correctDailyRevenue, 2);

                if (revenuePerDay[i] != correctDailyRevenue)
                {
                    revenuePerDay[i] = correctDailyRevenue;
                    isDataFixed = true;
                }
            }
            return isDataFixed;
        }

        public static int GetInvalidEntryCount(uint[] usersPerDay, double[] revenuePerDay)
        {
            if (usersPerDay.Length != revenuePerDay.Length)
            {
                return -1;
            }

            int NUM_REVENUE_ENTRIES = revenuePerDay.Length;
            int numInvalidEntries = 0;

            double[] revenuePerDayCopyOne = new double[NUM_REVENUE_ENTRIES];
            double[] revenuePerDayCopyTwo = new double[NUM_REVENUE_ENTRIES];

            for (int i = 0; i < NUM_REVENUE_ENTRIES; ++i)
            {
                revenuePerDayCopyOne[i] = revenuePerDay[i];
                revenuePerDayCopyTwo[i] = revenuePerDay[i];
            }

            bool isDataFixed = TryFixData(usersPerDay, revenuePerDayCopyOne);

            if (isDataFixed)
            {
                numInvalidEntries = 0;
                for (int i = 0; i < NUM_REVENUE_ENTRIES; ++i)
                {
                    if (revenuePerDayCopyOne[i] != revenuePerDayCopyTwo[i])
                    {
                        numInvalidEntries++;
                    }
                }
            }

            return numInvalidEntries;
        }

        public static double CalculateTotalRevenue(double[] revenuePerDay, uint start, uint end)
        {
            uint numDays = end - start + 1;
            double totalRevenue = 0.0;

            for (int i = 0; i < numDays; ++i)
            {
                totalRevenue += revenuePerDay[start + i];
            }

            return totalRevenue;
        }
    }
}