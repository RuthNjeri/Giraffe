using System;

namespace comparisons_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(10, 20, 80));
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            // Comparison operators, > greater than, < less than, == equal to, >= greater than or equal to, <=, != not equal to
            // You can compare characters as well... 's' != 's'
            //Comparing 3 numbers
            if ( num1 >= num2 && num1 >= num3)
            {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            } else
            {
                result = num3;
            }

            // Comparing 2 numbers
            //if (num1 > num2)
            //{
               // result = num1;
            //}
            //else
            //{
                //result = num2;
            //}

            return result;
        }
    }
}
