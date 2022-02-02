using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfDotNet.com.training.DataTypes.NumericType
{
    class LiteralExamples
    {
        /*
         * What is a Literal?
         * What is the use?
         * Pros and Cons
         */

        public void LiteralMethod()
        {
            Console.WriteLine(42);
            Console.WriteLine(1.618034);
            // Literal Double
            Console.WriteLine(1.618033988749895125);
            // Literal Decimal
            Console.WriteLine(1.618033988749895125m);

            // Exponential Notation
            Console.WriteLine(6.023E23f);
        }
    }
}
