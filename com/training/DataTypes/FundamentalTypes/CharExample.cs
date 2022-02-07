using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfDotNet.com.training.DataTypes.FundamentalTypes
{
    class CharExample
    {
        /*
         * At times it is required to convert a webelemnt value to char array and then do certain operations on it. 
         * We will learn more about it in Arrays Example.
         */
        public void CharMethod()
        {
            char charVariable = 'b';
            string charVariables = "abc";
            Console.WriteLine(((sbyte)charVariable));
            Console.WriteLine(((short)charVariable));
            Console.WriteLine(charVariables.Length);
            Console.WriteLine(charVariables.TrimStart());
        }
    }
}
