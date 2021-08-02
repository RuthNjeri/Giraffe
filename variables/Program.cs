using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Jumba";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was "+ characterAge +" years old");

            characterName = "Juma";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            // Another way to print
            Console.WriteLine("{0} is moving out", characterName);

            Console.ReadLine();
        }
    }
}
