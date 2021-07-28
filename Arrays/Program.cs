using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data type that the array can hold, all the information in an array needs to be 
            // Of the same type.
            // [] signifies that we are creating an array
            // You can asssign values in different ways
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42};

            // Array of strings
            string[] friends = new string[5]; // Tell c# how many elements the array can hold
            friends[0] = "Nyakio";
            friends[1] = "Jimmy";
            friends[2] = "Juma";
            Console.WriteLine(friends[2]);

            // Update elements
            luckyNumbers[1] = 900;

            // Array Access 
            Console.WriteLine(luckyNumbers[0]); // first element, 4
            Console.WriteLine(luckyNumbers[1]); // second number, 900...was updated in line 15


        }
    }
}
