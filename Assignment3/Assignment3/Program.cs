using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // int steps = TowerOfHanoi.GetNumberOfSteps(4);

            var snapshots = TowerOfHanoi.SolveTowerOfHanoi(6);

            printSnapshots(snapshots);
        }

        private static void printSnapshots(List<List<int>[]> snapshots)
        {
            for (int i = 0; i < snapshots.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"Initial State --------------------------------------");
                }
                else
                {
                    Console.WriteLine($"Step {i}. --------------------------------------");
                }

                Console.WriteLine($"Start: [ {string.Join(", ", snapshots[i][0])} ]");
                Console.WriteLine($"Aux: [ {string.Join(", ", snapshots[i][1])} ]");
                Console.WriteLine($"End: [ {string.Join(", ", snapshots[i][2])} ]");
            }
        }
    }
}
