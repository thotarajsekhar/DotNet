using System;

namespace BasicsOfDotNet.com.training.DataTypes
{
    class ImplicitlyTyped
    {
        /*
         * var is a keyword used in C# for declaring an implicitly typed local variable.
         */

        public void VarTypeExample()
        {
            // Declaring a string literal without initializing is alowed
            string valueType;
            // This is not allowed.
            //var someType;
            Console.Write("Enter text: ");
            valueType = Console.ReadLine();
            // Return a new string in uppercase
            var uppercase = valueType.ToUpper();
            Console.WriteLine(uppercase);
        }

        public void AnonymousType()
        {
            var patent1 = new
            {
                Title = "Bifocals",
                YearOfPublication = "1784"
            };
            var patent2 = new
            {
                Title = "Phonograph",
                YearOfPublication = "1877"
            };
            Console.WriteLine("{0} ({1})",
            patent1.Title, patent1.YearOfPublication);
            Console.WriteLine("{0} ({1})",
            patent2.Title, patent1.YearOfPublication);
        }
    }
}
