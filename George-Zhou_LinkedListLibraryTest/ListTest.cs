
// Fig. 19.5: ListTest.cs 
// Testing class List.
using System;
using System.Linq;
using George_Zhou_LinkedListLibrary_Framework;

// class to test List class functionality
class ListTest
{
    static void Main()
    {
        List<int> list = new List<int>(); // create List container

        List<double> listDouble = new List<double>(); // create List container
        List<string> listString = new List<string>(); // create List container
        List<char> listChar = new List<char>(); // create List container
        List<bool> listBool = new List<bool>(); // create List container


         
        int[] intArray = GenerateIntArray(5);
        double[] dblArray = GenerateDblArray(5, 100, 2);

        // Insert generated values into list
        foreach (int e in intArray)
        {
            list.InsertAtBack(e);
        }

        foreach (double e in dblArray)
        {
            listDouble.InsertAtBack(e);
        }
        // end insertion

        list.Display();
        Console.WriteLine("The minimum value of the list is "+ list.Minimum());
        Console.WriteLine("The value of last node is " +list.GetLastNode());
        Console.WriteLine();
        listDouble.Display();
        Console.WriteLine("The minimum value of the list is " + listDouble.Minimum());
        Console.WriteLine("The value of last node is " + listDouble.GetLastNode());




        /*
        // create data to store in List
        bool aBoolean = true;
        char aCharacter = '$';
        int anInteger = 34567;
        string aString = "hello";

        // use List insert methods       
        listBool.InsertAtFront(aBoolean);
        list.Display();
        list.InsertAtFront(aCharacter);
        list.Display();
        list.InsertAtBack(anInteger);
        list.Display();
        listString.InsertAtBack(aString);
        list.Display();

        // remove data from list and display after each removal
        try
        {
            object removedObject = list.RemoveFromFront();
            Console.WriteLine($"{removedObject} removed");
            list.Display();

            removedObject = list.RemoveFromFront();
            Console.WriteLine($"{removedObject} removed");
            list.Display();

            removedObject = list.RemoveFromBack();
            Console.WriteLine($"{removedObject} removed");
            list.Display();

            removedObject = list.RemoveFromBack();
            Console.WriteLine($"{removedObject} removed");
            list.Display();
        }
        catch (EmptyListException emptyListException)
        {
            Console.Error.WriteLine($"\n{emptyListException}");
        }
        */
    }

    ///Generate Random Integer Array
    private static int[] GenerateIntArray(int length)
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
            rndArray[i] = Math.Round(rnd.NextDouble() * magnitude, dec); // Round the value
        }
        return rndArray;
    }
}

