using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfDotNet.com.training.DataTypes.NumericType
{
    /*
     * In this integer type example we will see the integer types and the values they can store
     * We will also change the types and see what are the errors
     */
    class IntExamples
    {
        public sbyte simpleSbyte = -128;
        byte simpleIntiger = 28;
        short simpleShort = -32415;
        ushort simpleUShort = 62542;
        internal int simpleInt = 2144383647;
        uint simpleUInt = 3154825648;
        long simpleLong = 9223372036854775806;
        ulong simpleULong = 18446744073709551615;
    
        public void IntegerMethod()
        {
            // Print all the values
            // type "cw" and press TAB key twice. Shortcut for Console.WriteLine
            // Print all the types of the variables???
            Console.WriteLine(simpleInt);
        }
    }
}
