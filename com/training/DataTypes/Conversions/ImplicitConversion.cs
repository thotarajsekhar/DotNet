using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.com.training.DataTypes.Conversions
{
    class ImplicitConversion
    {
        public void NoCastingRequired()
        {
            // Implecit Type Conversion 
            // char --> int --> long --> float --> double

            // Automatic Type Conversion
            char x = 'a';
            int y = x;
            long l = y;
            float f = l;
            double d = f;
            Console.WriteLine("char: {0}, int: {1}, long: {2}, float: {3}, double: {4}", x, y, l, f, d);
        }
    }
}
