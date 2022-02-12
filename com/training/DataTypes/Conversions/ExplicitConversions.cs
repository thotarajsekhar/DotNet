using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.com.training.DataTypes.Conversions
{
    class ExplicitConversions
    {
        public void CheckedAndUncheckedBlocks()
        {
            int i = int.MaxValue;
            Console.WriteLine("Integer Max Value: {0}", i);
            i += 1;
            Console.WriteLine("Integer Max value + 1: {0}", i);

            checked
            {
                i = int.MaxValue;
                i += 1;
                Console.WriteLine("Integer Max value in checked block + 1: {0}", i);
            }

            unchecked
            {
                i = int.MaxValue;
                i += 1;
                Console.WriteLine("Integer Max value in unchecked block + 1: {0}", i);
            }
        }

        public void ExplicitConversion()
        {
            double d = 5457554845126447858;
            float f = (float)d;
            long l = (long)f;
            int y = (int)l;
            char x = (char)y;
            Console.WriteLine("char: {0}, int: {1}, long: {2}, float: {3}, double: {4}", x, y, l, f, d);
        }
    }
}
