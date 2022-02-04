using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfDotNet.com.training.DataTypes.ValueAndReference
{
    class VaR
    {
        public void ByValueMethod()
        {
            int x = 100;
            Console.WriteLine("Value of X befor the method call: {0}", x);
            UpdateValue(x);
            Console.WriteLine("Value of X after the method call: {0}", x);
        }

        private void UpdateValue(int x)
        {
            x += 5;
            Console.WriteLine("Value of x in the Method: {0}", x);
        }

        public void ByRefMethod()
        {
            int x = 100;
            Console.WriteLine("Ref Value of X befor the method call: {0}", x);
            UpdateRefValue(ref x);
            Console.WriteLine("Ref Value of X after the method call: {0}", x);
        }

        private void UpdateRefValue(ref int x)
        {
            x += 5;
            Console.WriteLine("Ref Value of x in the Method: {0}", x);
        }
    }
}
