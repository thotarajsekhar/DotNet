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
         * If the datatype is not used correctly then what will happen? - 
         * --- never ending process, need to be very careful on what are we using on the loop
         */

        public void BooleanMethod()
        {
            if(true)
            {
                Console.WriteLine("This condition will always print.");
            }

            if(!true)
            {
                // Warning from VS that this is an unreachable code. 
                Console.WriteLine("This will never be printed");
            }

            Console.Write(@"This for loop will be executed forever.
                                  Avoid this kind of checks.");

            for (int i = 0; i <= 5; i++)
            {
                Console.Write("i = {0}, \v", i);
                //changed the loop to i++ with 1 <=0 and it became a never ending process
            }
        }
    }
}
