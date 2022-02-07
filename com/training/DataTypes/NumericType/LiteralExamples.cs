using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfDotNet.com.training.DataTypes.NumericType
{
    class LiteralExamples
    {
        /*
         * What is a Literal? - Declaring a constant value and cant be changed during execution
         * What is the use? Best use of static variable
         * Pros- Value can be int, decimal, float or string, It can be used where the values of the variables dont change.
         * Cons - It cant be used in dynamic values
         */

        int variable1 = 42;
        double variable2 = 1.618034;
        float x = 1.61803398874989512F;

        double variable3;
        public LiteralExamples()
        {
            variable3 = x;
        }

        public void LiteralMethod()
        {
            //Console.WriteLine(42);
            Console.WriteLine(variable1);

            //Console.WriteLine(1.618034);
            Console.WriteLine(variable2);

            // Literal Double
            //Console.WriteLine(1.618033988749895125F);
            Console.WriteLine(x);

            // Literal Decimal
            Console.WriteLine(1.618033988749895125m);
            //Console.WriteLine((decimal (variable3)));

            // Exponential Notation
            Console.WriteLine(6.023E23f);
        }
    }
}
