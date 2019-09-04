using System;
using System.Collections.Generic;

namespace ReviewDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> students = new Dictionary<string, string>(10);

            students.Add("A1000", "Henry");
            students.Add("A1001", "Alex");
            // students.Add("A1001", "Jason");  Exception error
            students.TryAdd("A1001", "Jason"); // returns false
            students.TryAdd("A1002", "Jason");

            Console.WriteLine(students.ContainsKey("A1003"));
            Console.WriteLine(students.ContainsValue("Alex"));

            Console.WriteLine(students["A1000"]);
            // Console.WriteLine(students["S1005"]);    Exception error

            string value;
            bool bFound = students.TryGetValue("A1000", out value);
            Console.WriteLine($"{bFound} : {value}");

            students.Remove("A1000");
            // students.Clear();
        }
    }
}
