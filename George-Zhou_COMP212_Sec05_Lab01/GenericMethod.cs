using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace George_Zhou_COMP212_Sec05_Lab01
{
    class GenericMethod
    {
        static void Main(string[] args)
        {
            // Initialize Arrays
            int[] intArray = GenerateIntArray(10);
            double[] dblArray = GenerateDblArray(10, 100,2);
            char[] chrArray = GenerateChrArray(10);

            Console.WriteLine("The integer array is:");
            DisplayArray(intArray);
            Console.WriteLine();

            Console.WriteLine("The double array is:");
            DisplayArray(dblArray);
            Console.WriteLine();

            Console.WriteLine("The char array is:");
            DisplayArray(chrArray);
            Console.WriteLine();
        }

        /// Generic Method to display array
        private static void DisplayArray<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

        ///Generate Random Integer Array
        private static int[] GenerateIntArray (int length)
        {
            Random rnd = new Random();
            int[] rndArray = new int[length];
            for (int i = 0; i < rndArray.Length; ++i)
            {
                rndArray[i] = rnd.Next(10);
            }
            return rndArray;
        }

        ///Generate Random Double Array
                private static double[] GenerateDblArray(int length, int magnitude, int dec)
        {
            Random rnd = new Random();
            double[] rndArray = new double[length];
            for (int i = 0; i < rndArray.Length; ++i)
            {
                rndArray[i] = Math.Round(rnd.NextDouble()*magnitude,dec); // Round the value
            }
            return rndArray;
        }

        ///Generate Random Char Array
        private static char[] GenerateChrArray(int length)
        {
            Random rnd = new Random();
            char[] rndArray = new char[length];
            for (int i = 0; i < rndArray.Length; ++i)
            {
                char rndNumA = (char)rnd.Next(64, 90); // Capitalized
                char rndNumB = (char)rnd.Next(97, 122); // Non-Capitalized
                rndArray[i] = (rnd.Next(0, 2) == 1)?rndNumA :rndNumB; // Select capitaolized or non capitalized
            }
            return rndArray;
        }


        /* Legacy Method, did not work
         * Question: How to use a generic method to randomly generate an array of any type based on its parameters?
         *
        // Method to generate integer array
        private static T[] GenerateArray<T> (int length, Type type)
        {
           
            // Call random number generater
            Random rnd = new Random();
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Int32:
                    int[] rndArray = new int[length];
                    for (int i = 0; i < rndArray.Length; ++i)
                    {
                        rndArray[i] = rnd.Next(10);
                    }
                    return (T[])Convert.ChangeType(rndArray, type);
                default:
                    return default(T[]);

            }
            

        }
        */
    }
}
