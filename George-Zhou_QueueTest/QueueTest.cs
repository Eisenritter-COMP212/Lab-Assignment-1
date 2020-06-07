using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using George_Zhou_QueueInheritanceLibrary;
using George_Zhou_LinkedListLibrary_Framework;

namespace George_Zhou_QueueTest
{
    class QueueTest
    {
        static void Main()
        {
            QueueInheritance queue = new QueueInheritance();
            QueueInheritance queueDbl = new QueueInheritance();

            int[] intArray = GenerateIntArray(5);
            double[] dblArray = GenerateDblArray(5, 100, 2);

            // Insert generated values into list
            foreach (int e in intArray)
            {
                queue.Enqueue(e);
                queue.Display();
                Console.WriteLine("The last element is " + queue.GetLast()+"\n");

            }

            foreach (double e in dblArray)
            {
                queueDbl.Enqueue(e);
                queueDbl.Display();
                Console.WriteLine("The last element is " + queueDbl.GetLast()+"\n");
            }



            // use method Dequeue to remove items from queue
            object removedObject = null;

            /*
            // remove items from queue
            try
            {
                while (true)
                {
                    removedObject = queue.Dequeue();
                    Console.WriteLine($"{removedObject} dequeued");
                    queue.Display();
                }
            }
            catch (EmptyListException emptyListException)
            {
                // if exception occurs, write stack trace
                Console.Error.WriteLine(emptyListException.StackTrace);
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
}
