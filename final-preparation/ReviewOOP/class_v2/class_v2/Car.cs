using System;
using System.Collections.Generic;
using System.Text;

namespace class_v2
{
    class Car
    {
        public string Name;
        public int Price;
        public float Gas = 50.0f;

        public Car(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void Move()
        {
            Gas -= 0.5f;
        }
    }
}
