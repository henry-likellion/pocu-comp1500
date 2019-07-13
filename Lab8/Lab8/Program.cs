using System;
using System.Diagnostics;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string minifiedList = null;
            string prettifiedList = null;
            string list = Lab8.PrettifyList(minifiedList);
            Console.WriteLine(list);
            Debug.Assert(prettifiedList == list);

            Console.WriteLine("---------------------------------");
        }
    }
}