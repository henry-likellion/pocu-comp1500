using System;
using System.Collections.Generic;

namespace ReviewList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>(10);

            students.Add("Jason");

            string[] classA = { "Federer", "Nadal", "Jason" };

            students.AddRange(classA);

            Console.WriteLine(students.Capacity);
            Console.WriteLine(students.Count);

            Console.WriteLine(students.Contains("Henry"));

            Console.WriteLine(students.IndexOf("Federer"));
            Console.WriteLine(students.IndexOf("Nendal"));
            Console.WriteLine(students.LastIndexOf("Jason"));

            students.Insert(1, "Djokovic");
            // students.Insert(15, "Brian");    (Exception error - out of range)
            Console.WriteLine(students.Remove("Jason"));
            Console.WriteLine(students.IndexOf("Jason"));

            for (int i = 0; i < students.Count; ++i)
            {
                Console.Write($"{students[i]} ");
            }
            Console.WriteLine("");

            foreach (var student in students)
            {
                Console.Write($"{student} ");
            }
            Console.WriteLine("");

            students.Clear();

            Console.WriteLine(students.Count);
        }
    }
}
