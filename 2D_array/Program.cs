using System;

namespace _2D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid = // Put more commas to increase dimensions [,,,] 3D
            {
                {1, 2},
                {3, 4}
            };

            int[,] myArray = new int[2, 3]; // If you don't know how many elements you want to put in, 2 elements that have 3 elem in them

            Console.WriteLine(numberGrid[0, 9]);

            Console.ReadLine();
        }
    }
}
