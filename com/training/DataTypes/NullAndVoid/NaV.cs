using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfDotNet.com.training.DataTypes.NullAndVoid
{
    class NaV
    {
        // Void 
        public void MethodName()
        {
            /* 
             In C#, void is not considered a data type, it is used to identify that a
             method does not return a value.
            */
        }

        // null
        public string SecondMethod()
        {
            string test = null;
            test ??= "replace";
            Console.WriteLine("Value of Test: {0}",test);
            test = "";
            test ??= "replace";
            Console.WriteLine("Value of Test: {0}", test);

            string testing = "";
            string nullString = null;
            Console.WriteLine("Hashbode for Testing: {0}", testing.GetHashCode());
            Console.WriteLine("Length of Testing: {0}", testing.Length);
            Console.WriteLine(nullString.GetHashCode());
            Console.WriteLine(nullString.Length); 
            nullString = "I want to check the value";
            Console.WriteLine(nullString.Length);
            return null;
        }
    }
}
