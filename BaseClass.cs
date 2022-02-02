using BasicsOfDotNet.com.training.DataTypes;
using BasicsOfDotNet.com.training.DataTypes.FundamentalTypes;
using BasicsOfDotNet.com.training.DataTypes.NullAndVoid;
using BasicsOfDotNet.com.training.DataTypes.NumericType;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfDotNet
{
    class BaseClass
    {
        BaseClass()
        {
            Console.WriteLine("I am in the Base Class Constructor");
        }
        static void Main(string[] args)
        {
            // All the other methods are called from this main method. 
            // Call the methods individually.
            //DecimalExamples de = new DecimalExamples();
            //de.DecimalMethod();

            #region Creating an object of StringExampleClass and invoking methods
            // String Example Class
            StringExample stringExample = new StringExample();
            stringExample.FormatMethod();
            stringExample.ToUpper();
            #endregion

            //// IntergerExample class object
            IntExamples intExamples = new IntExamples();
            //int someValue = intExamples.GetHashCode();
            //Console.WriteLine(someValue);
            //intExamples.IntegerMethod();
            Console.WriteLine(intExamples.simpleSbyte);

            #region Null and Void
            NaV nav = new NaV();
            nav.SecondMethod();
            
            #endregion

            #region var type 
            var ImplicitType = new ImplicitlyTyped();
            ImplicitType.AnonymousType();
            ImplicitType.VarTypeExample();
            #endregion
        }
    }
}
