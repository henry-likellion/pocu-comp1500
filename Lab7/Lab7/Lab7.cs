using System;

namespace Lab7
{
    public static class Lab7
    {
        public static bool PlayGame(uint[] array)
        {
            int lengthArray = array.Length;
            bool[] hasVisited = new bool[lengthArray];

            for (int i = 0; i < lengthArray; ++i)
            {
                hasVisited[i] = false;
            }

            if (lengthArray < 2)
            {
                return false;
            }

            if (array[0] == 0)
            {
                return false;
            }

            if (array[0] > array.Length - 1)
            {
                return false;
            }

            return Move(array, hasVisited, array[0]);
        }

        public static bool Move(uint[] array, bool[] hasVisited, uint currentPosition)
        {
            if (array[currentPosition] == 0)
            {
                return true;
            }

            if (hasVisited[currentPosition])
            {
                return false;
            }
            else
            {
                hasVisited[currentPosition] = true;
            }


            uint newPositionRight = currentPosition + array[currentPosition];

            if (newPositionRight <= array.Length - 1)
            {
                if (Move(array, hasVisited, newPositionRight))
                {
                    return true;
                }
            }
            
            if (currentPosition > array[currentPosition])
            {
                uint newPositionLeft = currentPosition - array[currentPosition];
                if (Move(array, hasVisited, newPositionLeft))
                {
                    return true;
                }
            }

            return false;
        }
    }
}