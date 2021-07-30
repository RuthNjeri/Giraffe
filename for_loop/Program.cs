using System;

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

        }

    }
}
