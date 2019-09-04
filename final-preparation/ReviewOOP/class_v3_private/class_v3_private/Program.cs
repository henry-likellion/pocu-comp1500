using System;

namespace class_v3_private
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Henry", 50000);

            car.Move();

            Console.WriteLine(car.GetGas());
            Console.WriteLine(car.GetDistanceTravelled());
        }
    }
}
