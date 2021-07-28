using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Decimal values can't be converted to int
            int num = Convert.ToInt32("45"); // Convert string to num
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2); // 13
        }
    }
}
