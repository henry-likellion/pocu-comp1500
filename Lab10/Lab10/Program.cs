using System;
using System.Diagnostics;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            RightTriangle triangle1 = new RightTriangle(3, 7);

            Debug.Assert(triangle1.GetArea() == 10.500);

            RightTriangle triangle2 = new RightTriangle(7, 2);

            Debug.Assert(triangle2.Width == 7);
            Debug.Assert(triangle2.Height == 2);

            Debug.Assert(triangle2.GetPerimeter() == 16.280);
            Debug.Assert(triangle2.GetArea() == 7.000);
        }
    }
}
