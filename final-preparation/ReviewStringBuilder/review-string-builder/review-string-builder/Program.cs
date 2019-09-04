
using System;
using System.Text;

namespace review_string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder(8);
            builder.AppendLine("Hello!");
            builder.Insert(10, "World!");
        }
    }
}
