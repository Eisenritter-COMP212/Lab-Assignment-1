using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class StringBuilderExtensionsTest
    {
        static void Main(string[] args)
        {
            StringBuilder strBud = new StringBuilder();
            StringBuilder strObj1 = new StringBuilder("This is to test whether the extension method count can return a right answer or not");
            StringBuilder strObj2 = new StringBuilder("You can define extension methods for user defined types as well as predefined types");

            Console.WriteLine(strObj1);
            Console.WriteLine(strObj2);
            Console.WriteLine();

            Console.WriteLine("The first string has " + strBud.WordCount(strObj1) + " words");
            Console.WriteLine("The second string has " + strBud.WordCount(strObj2) + " words");
        }
    }
}
