using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringBuilderExtensions
    {
        public static int WordCount (this StringBuilder strBud, StringBuilder strobj)
        {
            string[] stringArray = strobj.ToString().Split(' '); // Split string by space
            return stringArray.Length;
        }
    }
}
