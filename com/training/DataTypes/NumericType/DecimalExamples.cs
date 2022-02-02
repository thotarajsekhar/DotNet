using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfDotNet.com.training.DataTypes.NumericType
{
    class DecimalExamples
    {
        /*
         * decimal 128 bits 1.0 × 10—28 to approximately 7.9 × 1028. Supports upto 28–29 digits
         * This datatype we will be using in the banking, travel, education, scientific, payment processing domains. 
         */

        public void DecimalMethod()
        {
            int testValue = 135;
            Console.WriteLine(decimal.Parse(testValue.ToString()));
        }
    }
}
