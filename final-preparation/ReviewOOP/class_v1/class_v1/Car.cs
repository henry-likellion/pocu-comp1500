using System;
using System.Collections.Generic;
using System.Text;

namespace class_v1
{
    public class Car
    {
        public string Owner;
        public float Gas;
        public int Price;

        public int GetPrice()
        {
            return Price;
        }

        public float GetGas()
        {
            return Gas;
        }

        public string GetOwner()
        {
            return Owner;
        }

        public void UpdateOwner(string owner)
        {
            Owner = owner;
        }
    }
}
