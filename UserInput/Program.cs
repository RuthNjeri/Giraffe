using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");// WriteLine prints then creates a new line, Write does not, like print and puts
            string name = Console.ReadLine();
            Console.Write(" Enter Your Age: ");
            string age = Console.ReadLine();
            
            Console.WriteLine("Hello " + name + " you are " + age + " years old.");
        }
    }
}
