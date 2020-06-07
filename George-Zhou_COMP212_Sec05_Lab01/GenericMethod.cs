using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods
{
    class GenericMethod
    {
        static void Main(string[] args)
        {
            // Initialize Arrays
            int[] intArray = GenerateIntArray(10);
            double[] dblArray = GenerateDblArray(10, 100,2);
            char[] chrArray = GenerateChrArray(10);
            string[] strArray = GenerateStrArray(10);

            Console.WriteLine("The integer array is:");
            DisplayArray(intArray);
            Console.WriteLine();

            /*
            Console.WriteLine("The double array is:");
            DisplayArray(dblArray);
            Console.WriteLine();

            Console.WriteLine("The char array is:");
            DisplayArray(chrArray);
            Console.WriteLine();
            */

            Console.WriteLine("The string array is:");
            DisplayArray(strArray);
            Console.WriteLine();

            // Using prompt here due to array is generated easily and this provide ease of testing
            Console.WriteLine("The item you wish to search for in the integer array is?");
            int searchKeyI = Int32.Parse(Console.ReadLine());
            int index = Search(intArray, searchKeyI);
            string msg = index == -1 ? $"{index} Index not Found" : $"{searchKeyI} found on Index {index}";
            Console.WriteLine(msg+"\n");



            Console.WriteLine("The item you wish to search for in the string array is?");
            string searchKeyS = Console.ReadLine();
            index = Search(strArray, searchKeyS);
            msg = index == -1 ? $"{index} Index not Found" : $"{searchKeyS} found on Index {index}";
            Console.WriteLine(msg+ "\n");
            // End Prompts
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

        ///Generate Random String Array
        private static string[] GenerateStrArray(int length)
        {
            string[] strDic = {"AMD", "Alienware", "Apple", "Nvidia", "ASRock", "Asus", "BenQ", "Biostar", "Brother", "Cisco", "Compal", "Cooler Master", "Dell", "Epson", "EVGA", "Gigabyte", "Google", "HP", "HTC", "IBM", "Intel", "Lenovo", "LG", "Microsoft",
            "Nvidia", "Oracle", "Razer", "Samsung", "Sony", "Toshiba", "Vaio", "Zotac"};
            Random rnd = new Random();
            string[] rndArray = new string[length];
            for (int i = 0; i < rndArray.Length; ++i)
            {
                rndArray[i] = strDic[rnd.Next(strDic.Length)];
            }
            return rndArray;
        }

        /// Geneirc Search method
        private static int Search<T>(T[] dataArray, T searchKey) where T:IComparable<T>
        {
            foreach (var element in dataArray)
            {
               if (element.CompareTo(searchKey) == 0)
                {
                    return Array.IndexOf(dataArray, element);
                }
            }
            return -1;
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
