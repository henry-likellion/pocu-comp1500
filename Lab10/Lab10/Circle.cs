using System;

namespace Lab10
{
    public class Circle
    {
        public uint Radius { get; }
        public uint Diameter { get; }

        public Circle(uint radius)
        {
            Radius = radius;
            Diameter = radius * 2;
        }

        public double GetCircumference()
        {
            double circumference = Math.Round(Diameter * Math.PI, 3);
            return circumference;
        }

        public double GetArea()
        {
            double area = Math.Round(Radius * Radius * Math.PI, 3);
            return area;
        }
    }
}
