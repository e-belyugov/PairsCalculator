using System;
using System.Collections;

namespace PairsCalculator
{
    class Program
    {
        // Printing pair with sum x
        static void PrintPairs(int[] values, int x)
        {
            // Hashtable for storing flags
            Hashtable hashtable = new Hashtable();

            // Cycle to process collection
            int count = values.Length;
            for (int i = 0; i <= count - 1; i++)
            {
                // Adding to x
                int addToX = x - values[i];

                // Searching for a pair (starting from second item)
                if ((i > 0) && hashtable.ContainsKey(addToX))
                {
                    // Printing a pair if not printed already
                    if (!Convert.ToBoolean(hashtable[addToX]))
                    {
                        hashtable[addToX] = true; // Setting flag to remember printing
                        Console.WriteLine("Pair found: " + addToX + ", " + values[i]);
                    }
                }

                // Adding value as a key if not exists
                if (!hashtable.ContainsKey(values[i]))
                {
                    hashtable.Add(values[i], false);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] values = new[] {3, 5, 2, 2, 78, 5, 4, 1, 3, 8};
            //int x = 4;
            //int x = 7;
            int x = 9;

            PrintPairs(values, x);

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}
