using System;
using System.Collections.Generic;
using System.Text;

namespace q1_c
{
    public class Foo
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public string StringValue { get; set; }

        public Foo(int x, int y)
        {
            X = x;
            Y = y;
        }

        private void DoSomething()
        {
            X = 10;
            Y = 3;
        }
    }
}
