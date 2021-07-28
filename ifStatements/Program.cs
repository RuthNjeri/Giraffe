using System;

namespace ifStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFemale = true;
            bool isTall = true;

            if (isFemale && isTall)  // Conditions , and &&, or ||
            {
                Console.WriteLine("You are Female and Tall");
            } else if (isFemale && !isTall) 
            {
                Console.WriteLine("You are a short female");
            } else if(!isFemale && isTall )
            {
                Console.WriteLine("You are not female but you are tall");
            }else
            {
                Console.WriteLine("You are not female and not tall");
            }


        }
    }
}
