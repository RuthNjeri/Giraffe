using System;

namespace build_an_exponent_method
{
    class Program
    {
        static void Main(string[] args)
        {
            // exponent, base number and power number, to give the exponent... 2 base, 3 power, 8 exponent
            Console.WriteLine(GetPow(2, 2));
            Console.ReadLine();

        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i <powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }
    }
}
