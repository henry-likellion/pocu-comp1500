using System;
using System.Diagnostics;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(8);

            Debug.Assert(circle1.Radius == 8);
            Debug.Assert(circle1.Diameter == 16);

            Debug.Assert(circle1.GetCircumference() == 50.265);
            Debug.Assert(circle1.GetArea() == 201.062);

            Circle circle2 = new Circle(4);

            Debug.Assert(circle2.Radius == 4);
            Debug.Assert(circle2.Diameter == 8);

            Debug.Assert(circle2.GetCircumference() == 25.133);
            Debug.Assert(circle2.GetArea() == 50.265);
        }
    }
}
