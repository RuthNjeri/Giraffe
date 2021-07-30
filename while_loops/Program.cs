using System;

namespace while_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;

            while (index <= 5) // Condition
            {
                Console.WriteLine(index);
                index++;
            }

            // Do while loop, you execute the code inside the loop first, then check the condition.
            int index2 = 6;
            do
            {
                Console.WriteLine(index2);
            } while (index2 <= 5);


            Console.ReadLine();
        }
    }
}
