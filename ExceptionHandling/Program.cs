using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try // Code that would potentially break the program
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
               
            }
            // You can have one catch or multiple catch exception
            // For one you capture all exceptions
            // For many, it is recommended, to perform an action based on an exception
            catch(DivideByZeroException e) // Can sometimes be called without the Exception as catch
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally // Any code here will always be executed
            {

            }

            Console.ReadLine();

        }
    }
}
