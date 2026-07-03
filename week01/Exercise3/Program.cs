using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do
        {
            Random randomNumberGenerator = new Random();
            int magicNumber = randomNumberGenerator.Next(1, 101);

            int guess = -1;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Guess Higher");
                
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Guess Lower");
                }
                else
                {
                    Console.WriteLine("You guessed is correct!");
                }
            }

            Console.Write("Do you want to play again? (yes / no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

    Console.WriteLine("Thanks for playing. That was fun!");
    }
}