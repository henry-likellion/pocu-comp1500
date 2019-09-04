using System;

namespace class_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Henry", 50000);
            car.Move();
            Console.WriteLine(car.Gas);
        }
    }
}
