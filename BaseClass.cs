using BasicsOfDotNet.com.training.DataTypes;
using BasicsOfDotNet.com.training.DataTypes.FundamentalTypes;
using BasicsOfDotNet.com.training.DataTypes.NullAndVoid;
using BasicsOfDotNet.com.training.DataTypes.NumericType;
using BasicsOfDotNet.com.training.DataTypes.ValueAndReference;
using DotNet.com.training.DataTypes.Conversions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfDotNet
{
    class BaseClass
    {
        static void Main(string[] args)
        {
            StartHere:
            Console.Write("Enter a valid number from 1 to 11: ");
            int userValue = int.Parse(Console.ReadLine());
            try
            { 
            switch (userValue)
            {
                case 1:
                    DecimalExamples de = new DecimalExamples();
                    de.DecimalMethod();
                    break;
                case 2:
                    FloatingPointExamples fpe = new FloatingPointExamples();
                    fpe.FloatMethod();
                    break;
                case 3:
                    IntExamples ie = new IntExamples();
                    ie.IntegerMethod();
                    break;
                case 4:
                    LiteralExamples le = new LiteralExamples();
                    le.LiteralMethod();
                    break;
                case 5:
                    BooleanExample be = new BooleanExample();
                    be.BooleanMethod();
                    break;
                case 6:
                    CharExample ce = new CharExample();
                    ce.CharMethod();
                    break;
                case 7:
                    StringExample se = new StringExample();
                    se.LengthMethod();
                    se.ToUpper();
                    se.StringConcat();
                    se.TrimMethod();
                    se.StringMethod();
                    se.FormatMethod();
                    se.MyMethod();
                    
                    
                    
                    break;
                    case 8:
                    NaV na = new NaV();
                    na.SecondMethod();
                    break;
                case 9:
                    ImplicitlyTyped it = new ImplicitlyTyped();
                    it.VarTypeExample();
                    it.AnonymousType();
                    break;
                case 10:
                    VaR vr = new VaR();
                    vr.ByValueMethod();
                    vr.ByRefMethod();
                    break;
                case 11:
                    ImplicitConversion ic = new ImplicitConversion();
                    ic.NoCastingRequired();
                    break;
                default:
                    goto StartHere;
            }
            } catch(Exception e)
            {
                Console.WriteLine("Exception is of type: {0}", e.Message);
                goto StartHere;
            }
            
            // All the other methods are called from this main method. 
            // Call the methods individually.
            //DecimalExamples de = new DecimalExamples();
            //de.DecimalMethod();

            //#region Creating an object of StringExampleClass and invoking methods
            //// String Example Class
            //StringExample stringExample = new StringExample();
            //stringExample.FormatMethod();
            //stringExample.ToUpper();
            //#endregion

            ////// IntergerExample class object
            //IntExamples intExamples = new IntExamples();
            ////int someValue = intExamples.GetHashCode();
            ////Console.WriteLine(someValue);
            ////intExamples.IntegerMethod();
            //Console.WriteLine(intExamples.simpleSbyte);

            //#region Null and Void
            //NaV nav = new NaV();
            //nav.SecondMethod();
            //#endregion

            //#region var type 
            //var ImplicitType = new ImplicitlyTyped();
            //ImplicitType.ValueType();
            //#endregion
        }
    }
}
