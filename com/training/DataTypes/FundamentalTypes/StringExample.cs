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

        readonly string stringVariable = "    This is a sample string. We will play with this variable:    ";
        string palindrome;

        public void StringMethod()
        {
            Console.WriteLine("Sample string is: {0}", stringVariable);
            Console.WriteLine(stringVariable);
        }

        public void StringConcat()
        {
            // One way for string concat
            Console.Write("\n Enter a string to concat: ");
            var userInputString = Console.ReadLine();
            var newValue = stringVariable + userInputString;
            Console.WriteLine("The new value is:\t{0}", newValue);

            // StringBuffer - need more understanding on this one
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(stringVariable);
            Console.WriteLine("Enter a string to concat: \t");
            stringBuilder.Append(Console.ReadLine());

            // String Format is used.
            Console.WriteLine("The appended string value is: {0}", stringBuilder);
        }

        // String instance method
        public void TrimMethod()
        {
            Console.WriteLine("Trimming Start: {0}", stringVariable.TrimStart());
            Console.WriteLine("Trimming End: {0}", stringVariable.TrimEnd());
            Console.WriteLine("Trimming: {0}", stringVariable.Trim());
            //Console.WriteLine("Trimming: {0}", stringVariable.Trim(1));
            //I tried to trim the string first letter but it didnt work
        }

        public void LengthMethod()
        {

            System.Console.Write("Enter a palindrome: ");
            palindrome = System.Console.ReadLine();

            System.Console.WriteLine("The palindrome, \"{0}\" is {1} characters.", palindrome, palindrome.Length);
            
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
            //returns lower case as the new variable is not assigned
            uppercase = text.ToUpper();
            Console.WriteLine("Printing the converted value ToUpper(): {0}", uppercase);
            //returns upper case as new variable is assigned
            
        }

        public void ShowFullName()
        {
            string Name, FN, LN;
            Console.Write("Enter First Name: ");
            FN = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            LN = Console.ReadLine();
            Console.WriteLine(FN +" "+ LN);


        }


        public void DuplicateString()
        {
            string textString = "Google";
            char[] charArray = textString.ToCharArray();
            for (int i = 0; i<(textString.Length); i++)
            {
                if(charArray[i] == charArray[i+1])
                {
                    Console.WriteLine("duplicate character is: {0}", charArray[i] );
                    break;
                }
            }
        }


        public void ReverseString()
        {
            string nameString = "Google";

            char[] nameChar = nameString.ToCharArray();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = (nameString.Length-1); i >= 0; i--)
            {

                stringBuilder.Append(nameChar[i]);

            }
            Console.WriteLine("Reverse string is: {0}", stringBuilder.ToString());
       
        }

        public void SplitMethod()
        {
            string sNameString = "I am Gopa";
            string[] sList = sNameString.Split(" ");
            for(int i = (sList.Length-1); i>=0; i--)
                Console.Write(sList[i]+" ");

        }


        public void ReplaceLetterMethod()
        {
            string sPresident = "I am Donald Trump";
            string[] sArray = sPresident.Split(" ");
            char[] sChar = sPresident.ToCharArray();

            for(int i = 0; i< sChar.Length; i++)
            {
                if(sChar[i] == 'a')
                {
                    sChar[i] = 'z';
                }
            }
            Console.WriteLine("Print the name: {0}:", new string(sChar));
            //string.replace is a method replaces sring or character
            string sText = "This is just a simple text to replace the s with a";
            Console.WriteLine(sText.Replace('s', 'a'));


        }

        

    }
}
