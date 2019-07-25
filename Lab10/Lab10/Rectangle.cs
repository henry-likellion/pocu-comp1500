namespace Lab10
{
    public class Rectangle
    {
        public uint Width { get; }
        public uint Height { get; }

        public Rectangle(uint width, uint height)
        {
            Width = width;
            Height = height;
        }

        public double GetPerimeter()
        {
            double perimeter = (Width + Height) * 2;
            return perimeter;
        }

        public double GetArea()
        {
            double area = Width * Height;
            return area;
        }
    }
}
