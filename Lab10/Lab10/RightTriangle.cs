using System;

namespace Lab10
{
    public class RightTriangle
    {
        public uint Width { get; }
        public uint Height { get; }

        public RightTriangle(uint width, uint height)
        {
            Width = width;
            Height = height;
        }

        public double GetPerimeter()
        {
            double perimeter = Math.Round(Width + Height + Math.Sqrt(Width * Width + Height * Height), 3);
            return perimeter;
        }

        public double GetArea()
        {
            double area = Width * Height / 2.0;
            return area;
        }
    }
}
