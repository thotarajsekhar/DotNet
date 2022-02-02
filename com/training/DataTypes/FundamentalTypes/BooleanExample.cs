using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfDotNet.com.training.DataTypes.FundamentalTypes
{
    class BooleanExample
    {
        /*
         * Boolean is a very important Data Type for a QA Engineer.
         * It is used to exit from a condition. 
         * If the datatype is not used correctly then what will happen?
         */

        public void BooleanMethod()
        {
            if(true)
            {
                Console.WriteLine("This if condition will always print.");
            }

            if(!true)
            {
                // Warning from VS that this is an unreachable code. 
                Console.WriteLine("This will never be printed");
            }

            Console.Write(@"This for loop will be executed forever.
                                  Avoid this kind of checks.");

            for (int i = 0; i >= 0; i--)
            {
                Console.Write("i = {0}, \t", i);
            }
        }
    }
}
