using System.Collections.Generic;

namespace Assignment3
{
    public static class TowerOfHanoi
    {
        public static int GetNumberOfSteps(int numDiscs)
        {
            if (numDiscs >= 0)
            {
                return GetPowerBaseTwo(numDiscs) - 1;
            }
            return -1;
        }

        public static List<List<int>[]> SolveTowerOfHanoi(int numDiscs)
        {
            if (numDiscs < 1)
            {
                return new List<List<int>[]>();
            }

            List<List<int>[]> snapshots = new List<List<int>[]>();

            int totalDiscs = numDiscs;

            List<int>[] towersOfHanoi = new List<int>[] { new List<int>(), new List<int>(), new List<int>() };

            for (int i = 0; i < numDiscs; ++i)
            {
                towersOfHanoi[0].Add(numDiscs - i);
            }

            UpdateSnapshots(snapshots, towersOfHanoi);

            if (numDiscs == 1)
            {
                towersOfHanoi[0].Remove(1);
                towersOfHanoi[2].Add(1);

                UpdateSnapshots(snapshots, towersOfHanoi);
            }

            MoveDiscsHanoi(snapshots, towersOfHanoi, numDiscs, totalDiscs);

            return snapshots;
        }

        public static void MoveDiscsHanoi(List<List<int>[]> snapshots, List<int>[] towersOfHanoi, int numDiscs, int totalDiscs)
        {
            if (numDiscs == 2)
            {
                MoveTwoDiscs(snapshots, towersOfHanoi, totalDiscs);
            }

            if (numDiscs > 2)
            {
                MoveDiscsHanoi(snapshots, towersOfHanoi, numDiscs - 1, totalDiscs);
                MoveSingleDisc(snapshots, towersOfHanoi, numDiscs, totalDiscs);
                MoveDiscsHanoi(snapshots, towersOfHanoi, numDiscs - 1, totalDiscs);
            }
        }

        public static void MoveTwoDiscs(List<List<int>[]> snapshots, List<int>[] towersOfHanoi, int totalDiscs)
        {
            int indexNumOne, indexNumTwo;

            if (towersOfHanoi[0].IndexOf(1) != -1)
            {
                indexNumOne = 0;
                indexNumTwo = 0;
            }
            else if (towersOfHanoi[1].IndexOf(1) != -1)
            {
                indexNumOne = 1;
                indexNumTwo = 1;
            }
            else
            {
                indexNumOne = 2;
                indexNumTwo = 2;
            }

            if (totalDiscs % 2 == 0)
            {
                towersOfHanoi[indexNumOne].Remove(1);
                indexNumOne = (indexNumOne + 1) % 3;
                towersOfHanoi[indexNumOne].Add(1);

                UpdateSnapshots(snapshots, towersOfHanoi);

                towersOfHanoi[indexNumTwo].Remove(2);
                indexNumTwo = (indexNumTwo + 2) % 3;
                towersOfHanoi[indexNumTwo].Add(2);


                UpdateSnapshots(snapshots, towersOfHanoi);

                towersOfHanoi[indexNumOne].Remove(1);
                indexNumOne = (indexNumOne + 1) % 3;
                towersOfHanoi[indexNumOne].Add(1);

                UpdateSnapshots(snapshots, towersOfHanoi);
            }
            else
            {
                towersOfHanoi[indexNumOne].Remove(1);
                indexNumOne = (indexNumOne + 2) % 3;
                towersOfHanoi[indexNumOne].Add(1);

                UpdateSnapshots(snapshots, towersOfHanoi);

                towersOfHanoi[indexNumTwo].Remove(2);
                indexNumTwo = (indexNumTwo + 1) % 3;
                towersOfHanoi[indexNumTwo].Add(2);


                UpdateSnapshots(snapshots, towersOfHanoi);

                towersOfHanoi[indexNumOne].Remove(1);
                indexNumOne = (indexNumOne + 2) % 3;
                towersOfHanoi[indexNumOne].Add(1);

                UpdateSnapshots(snapshots, towersOfHanoi);
            }
        }

        public static void MoveSingleDisc(List<List<int>[]> snapshots, List<int>[] towersOfHanoi, int numDiscs, int totalDiscs)
        {
            int indexCurrentDiscNumber;

            if (towersOfHanoi[0].IndexOf(numDiscs) != -1)
            {
                indexCurrentDiscNumber = 0;
            }
            else if (towersOfHanoi[1].IndexOf(numDiscs) != -1)
            {
                indexCurrentDiscNumber = 1;
            }
            else
            {
                indexCurrentDiscNumber = 2;
            }

            towersOfHanoi[indexCurrentDiscNumber].Remove(numDiscs);

            if (totalDiscs % 2 == 0)
            {
                if (numDiscs % 2 == 0)
                {
                    indexCurrentDiscNumber = (indexCurrentDiscNumber + 2) % 3;
                    towersOfHanoi[indexCurrentDiscNumber].Add(numDiscs);

                    UpdateSnapshots(snapshots, towersOfHanoi);
                }
                else
                {
                    indexCurrentDiscNumber = (indexCurrentDiscNumber + 1) % 3;
                    towersOfHanoi[indexCurrentDiscNumber].Add(numDiscs);

                    UpdateSnapshots(snapshots, towersOfHanoi);
                }
            }
            else
            {
                if (numDiscs % 2 == 0)
                {
                    indexCurrentDiscNumber = (indexCurrentDiscNumber + 1) % 3;
                    towersOfHanoi[indexCurrentDiscNumber].Add(numDiscs);

                    UpdateSnapshots(snapshots, towersOfHanoi);
                }
                else
                {
                    indexCurrentDiscNumber = (indexCurrentDiscNumber + 2) % 3;
                    towersOfHanoi[indexCurrentDiscNumber].Add(numDiscs);

                    UpdateSnapshots(snapshots, towersOfHanoi);
                }
            }
        }

        public static void UpdateSnapshots(List<List<int>[]> snapshots, List<int>[] towersOfHanoi)
        {
            List<int>[] newSnapshotTowerOfHanoi = new List<int>[] { new List<int>(), new List<int>(), new List<int>() };

            towersOfHanoi[0].ForEach(e => newSnapshotTowerOfHanoi[0].Add(e));
            towersOfHanoi[1].ForEach(e => newSnapshotTowerOfHanoi[1].Add(e));
            towersOfHanoi[2].ForEach(e => newSnapshotTowerOfHanoi[2].Add(e));

            snapshots.Add(newSnapshotTowerOfHanoi);
        }

        public static int GetPowerBaseTwo(int power)
        {
            int value = 1;
            for (int i = 0; i < power; ++i)
            {
                value *= 2;
            }
            return value;
        }
    }
}