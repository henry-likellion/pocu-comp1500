using System.IO;

namespace Assignment1
{
    public static class Assignment1
    {
        public static void PrintIntegers(StreamReader input, StreamWriter output)
        {
            int numberOfIntegers = 5;
            int[] integers = new int[numberOfIntegers];

            for(int i = 0; i < numberOfIntegers; ++i)
            {
                integers[i] = int.Parse(input.ReadLine());
            }

            output.WriteLine($"{"oct",12}{"dec",11}{"hex",9}");
            output.WriteLine($"------------ ---------- --------");

            for(int i = 0; i < numberOfIntegers; ++i)
            {
                // string octValue = integers[i].ToString(8);
                string hexValue = integers[i].ToString("X");

                int decimalToOct = integers[i];
                string octValue = "";

                while (decimalToOct != 0)
                {
                    int remainder = decimalToOct % 8;
                    decimalToOct /= 8;
                    octValue = remainder.ToString() + octValue;
                }
              
                output.WriteLine($"{octValue,12}{integers[i],11}{hexValue,9}");
            }
        }

        public static void PrintStats(StreamReader input, StreamWriter output)
        {
            int numberOfFloats = 5;
            float[] floats = new float[numberOfFloats];

            for (int i = 0; i < numberOfFloats; ++i)
            {
                floats[i] = float.Parse(input.ReadLine());
            }
      
            float min = floats[0];
            float max = floats[0];
            float sum = 0f;

            for (int i = 0; i < numberOfFloats; ++i)
            {
                if (min > floats[i])
                {
                    min = floats[i];
                }

                if (max < floats[i])
                {
                    max = floats[i];
                }

                sum += floats[i];
            }

            float average = sum / numberOfFloats;
            string minToString = min.ToString("0.000");
            string maxToString = max.ToString("0.000");
            string sumToString = sum.ToString("0.000");
            string averageToString = average.ToString("0.000");

            for (int i = 0; i < numberOfFloats; ++i)
            {
                string floatToString = floats[i].ToString("0.000");
                output.WriteLine($"{floatToString,20}");
            }

            output.WriteLine($"Min{minToString,17}");
            output.WriteLine($"Max{maxToString,17}");
            output.WriteLine($"Sum{sumToString,17}");
            output.WriteLine($"Average{averageToString,13}");
        }
    }
}
