using System;
using System.Collections.Generic;

namespace Lab9
{
    public static class Lab9
    {
        public static List<int> MergeLists(List<int> sortedList1, List<int> sortedList2)
        {
            for (int i = 0; i < sortedList2.Count; ++i)
            {
                for (int j = sortedList1.Count - 1; j < sortedList1.Count; --j)
                {
                    if (sortedList1[j] <= sortedList2[i])
                    {
                        sortedList1.Insert(j + 1, sortedList2[i]);
                        break;
                    }
                }
            }
            return sortedList1;
        }

        public static Dictionary<string, int> CombineListsToDictionary(List<string> keys, List<int> values)
        {
            List<string> noDuplicatedKeys = new List<string>();

            for (int i = 0; i < keys.Count; ++i)
            {
                if (!noDuplicatedKeys.Contains(keys[i]))
                {
                    noDuplicatedKeys.Add(keys[i]);
                }
            }

            int dictLength = (noDuplicatedKeys.Count >= values.Count) ? values.Count : noDuplicatedKeys.Count;
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < dictLength; ++i)
            {
                dict[noDuplicatedKeys[i]] = values[i];
            }

            return dict;
        }

        public static Dictionary<string, decimal> MergeDictionaries(Dictionary<string, int> numerators, Dictionary<string, int> denominators)
        {
            Dictionary<string, decimal> fractions = new Dictionary<string, decimal>();
            foreach (var numerator in numerators)
            {
                if (denominators.ContainsKey(numerator.Key))
                {
                    int denominator = denominators[numerator.Key];
                    if (denominator != 0)
                    {
                        fractions[numerator.Key] = Math.Abs((decimal)numerator.Value / denominator);
                    }
                }
            }
            return fractions;
        }
    }
}