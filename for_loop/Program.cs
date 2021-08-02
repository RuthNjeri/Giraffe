using System;
using System.Collections;
using System.Collections.Generic;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 90, 22, 33, 44 };
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            Console.ReadLine();

            // foreach
            // Detour: Array vs List<T>, resizing arrays is expensive, List is better to use.
            // If you knw the data is of a fixed length then you can use an array.
            // List<T> offers a lot more functionality than an array.
            var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int element in fibNumbers)
            {
                Console.Write($"{element} test");
            }

        }

    }
}
