using System;

namespace Methods
{
    class Program
    {   
        // Methods can also be called functions
        static void Main(string[] args) // Method that gets executed when you run the program
        {
            SayHi("Ruth", 66);
            SayHi("TTYL", 77);
         
        }

        static void SayHi(string name, int age)// Start with static then specify a return type...void does not return any info, then give a method name
        {
            // Any code inside the two braces {} is considered part of the method
            // To run this method, call it in the Main method
            Console.WriteLine("Hello " + name + " You are " + age);

        }
        
    }
}
