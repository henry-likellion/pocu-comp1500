using System;
using System.Collections.Generic;
using System.Text;

namespace class_v3_private
{
    class Car
    {
        private string mName;
        private int mPrice;
        private float mGas = 50.0f;
        private int mDisTravelled = 0;

        public Car(string name, int price)
        {
            mName = name;
            mPrice = price;
        }

        public void Move()
        {
            mDisTravelled += 1;
            consumeGas();
        }

        private void consumeGas()
        {
            mGas -= 0.5f;
        }

        public float GetGas()
        {
            return mGas;
        }

        public int GetPrice()
        {
            return mPrice;
        }

        public int GetDistanceTravelled()
        {
            return mDisTravelled;
        }

        public string GetName()
        {
            return mName;
        }

        // If getter & setter functions are as noral as above,
        // can we reduce the code? Yes! properties provided by C#
    }
}
