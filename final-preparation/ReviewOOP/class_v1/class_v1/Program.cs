using System;

namespace class_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Price = 50000;
            car.Owner = "Henry";
            car.Gas = 100.0f;
            Console.WriteLine(car.GetOwner());
            car.UpdateOwner("Alex");
            Console.WriteLine(car.GetOwner());

            // Problems
            // 1) If the member value is not assigned, it may cause unexpected outcomes. => solution) Initialisation & Constructor
            // 2) Member properties can be changed in any scope.
        }
    }
}
