using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfDotNet.com.training.DataTypes.FundamentalTypes
{
    class StringExample
    {
        /*
         * The most important data type, which automation team will use regularly. 
         * In fact on a daily basis. 
         * This example consists many methods with which we will practise. 
         */

        readonly string stringVariable = "    This is a sample string. We will play with this variable.    ";
        string palindrome, palindrome1;

        public void StringMethod()
        {
            Console.WriteLine("Sample string is: {0}", stringVariable);
            Console.WriteLine(stringVariable);
        }

        public void StringConcat()
        {
            // One way for string concat
            Console.Write("\n Eneter a string to concat: ");
            var userInputString = Console.ReadLine();
            var newValue = stringVariable + userInputString;
            Console.WriteLine("The new value is:\t{0}", newValue);

            // StringBuffer - need more understanding on this one
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(stringVariable);
            Console.WriteLine("Enter a string to concat: \t");
            stringBuilder.Append(Console.ReadLine());

            // String Format is used.
            Console.WriteLine("The appedned string value is: {0}", stringBuilder);
        }

        // String instance method
        public void TrimMethod()
        {
            Console.WriteLine("Trimming Start: {0}", stringVariable.TrimStart());
            Console.WriteLine("Trimming End: {0}", stringVariable.TrimEnd());
            Console.WriteLine("Trimming: {0}", stringVariable.Trim(1));
            //I tried to trim the string first letter but it didnt work
        }

        public void LengthMethod()
        {

            //string palindrome = "test";
            palindrome = System.Console.Write("Enter a palindrome: ");
            palindrome1 = System.Console.ReadLine(palindrome);
            System.Console.WriteLine("The palindrome, \"{0}\" is {1} characters.", palindrome1, palindrome1.Length);
            //this doesn't return anything. Need more help understanding this. I didnt find anything wrong in the code.
        }

        internal void MyMethod()
        {
            throw new NotImplementedException();
            //thought this is an error but exception thwon as requested "Exception thrown: 'System.NotImplementedException' in DotNet.dll"
            //Exception is of type: The method or operation is not implemented.
        }

        public void FormatMethod()
        {
            Console.WriteLine(DateTime.Now.ToString("MMM-dd-yyyy"));
            Console.WriteLine(DateTime.DaysInMonth(2000, 12));
            Console.WriteLine(DateTime.IsLeapYear(2001));

            // We will work with String.Format method in more detail during our test creation.
        }

        // String static methods vs instance methods

        public void ToUpper()
        {
            string text, uppercase;
            Console.Write("Enter text to convert it to Upper Case: ");
            text = System.Console.ReadLine();
            // Return a new string in uppercase
            text.ToUpper();
            Console.WriteLine("Printing the original value ToUpper(): {0}", text);
            uppercase = text.ToUpper();
            Console.WriteLine("Printing the converted value ToUpper(): {0}", uppercase);
            //this doesn't return any values
        }
    }
}
