using System;

namespace returnStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubedNumber = CubeNumber(3);
            Console.WriteLine(CubeNumber(5)); // Returns an integer
            Console.WriteLine(cubedNumber); // Returns an integer


        }

        static double CubeNumber(double num) // Returns an integer
        {
            double result = Math.Pow(num, 3);
            return result; // Tells c# that we want to return.. info to the caller
        }
    }
}
