using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy" + " is cool";
            // delimeter and new line character
            Console.WriteLine("Hello \n \"World!");
            Console.WriteLine(phrase);

            // Methods
            // Characters inside the string
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("Giraffes")); // false
            Console.WriteLine(phrase[3]); //Prints out 4th character of a string..index starts at 0
            Console.WriteLine(phrase.IndexOf("Academy")); // Where Academy starts..at index 8
            Console.WriteLine(phrase.IndexOf('f')); // Index of the first f..4, if not available, ouput is -1
            Console.WriteLine(phrase.Substring(8));// Index of where we want to start grabbing the string at..like [8..n]
            Console.WriteLine(phrase.Substring(8, 3));// You can pass in a length of how many characters you want to grab
            Console.ReadLine();

        }
    }
}
