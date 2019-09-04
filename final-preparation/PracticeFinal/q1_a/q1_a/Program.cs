using System;

namespace q1_a
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World!";
            Console.WriteLine(DoMagic(s, s.Length - 1));
        }

        public static string DoMagic(string s, int i)
        {
            if (i == 0)
            {
                return $"{s[0]}";
            }

            return s[i] + DoMagic(s, i - 1);
        }
    }
}
