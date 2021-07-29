using System;

namespace Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Switch statement is a different kind of if statement
            // Program to convert a number to different days of the week
            Console.WriteLine(GetDay(2));
            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break; // Stops c# from checking the other cases 
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName; 
        }
    }
}
