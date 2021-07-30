using System;

namespace Build_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool OutOfGuesses = false;

            while(guess != secretWord && !OutOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter a guess: ");
                    guess = Console.ReadLine();
                    guessCount++;

                }
                else
                {
                    OutOfGuesses = true;
                }

            }


            if (OutOfGuesses)
            {
                Console.WriteLine("You Lose!");

            }
            else
            {
                Console.Write("You Win!");

            }

            // With do while
            //do
            //{
            //Console.Write("Enter a guess: ");
            //guess = Console.ReadLine();
            //} while (guess != secretWord);



            Console.ReadLine();
        }
    }
}
