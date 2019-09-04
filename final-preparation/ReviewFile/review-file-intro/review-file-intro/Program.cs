using System;
using System.IO;

namespace review_file_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Henry", "Alex" };
            File.WriteAllLines(@".\students.txt", names);

            string message = "C# is good!";
            File.WriteAllText(@".\students.txt", message);
            File.AppendAllLines(@".\students.txt", names);

            string[] lines = File.ReadAllLines(@".\students.txt");

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            string text = File.ReadAllText(@".\students.txt");

            Console.WriteLine(text);
        }
    }
}
