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
            string valueType;
            // This is not allowed.
            //var someType;
            Console.Write("Enter text: ");
            var text = Console.ReadLine();
            // Return a new string in uppercase
            var uppercase = text.ToUpper();
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
