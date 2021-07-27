using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {   // Variables
            int num = 6;
            num++;// method to increment num
            num--;// Decrement num
            Console.WriteLine(num); // Prints 6, incremented to 7 in line 10, then decremented in line 11
            // Two types of numbers, decimal and whole numbers(integer)
            Console.WriteLine( 40 );
            Console.WriteLine(8 / 4); // returns 2
            Console.WriteLine(5 % 2 ); // 1
            Console.WriteLine(4 + 2 * 3); // 10
            Console.WriteLine((4 + 2) * 3);// To change the order.. 18
            Console.WriteLine( 5.0 + 8.1 );// You can work with decimals, a decimal is returned back
            Console.WriteLine( 5.0 + 8 ); // You get a decimal back
            Console.WriteLine( 10 / 2); // returns integer
            // Math methods
            Console.WriteLine(Math.Abs(-40)); // Converts to + num..40
            Console.WriteLine(Math.Pow(3, 2)); // Gives 3 to power 2.. 9
            Console.WriteLine(Math.Sqrt(81)); // Gives the sqrt of 81.. 9
            Console.WriteLine(Math.Max(4, 90)); // Prints out the bigger number, 90, .Min will print out 4
            Console.WriteLine(Math.Min(4, 90)); // Prints out 4
            Console.WriteLine(Math.Round(4.6)); // Rounds up to the nearest number...prints out 5
            Console.ReadLine();
        }
    }
}
