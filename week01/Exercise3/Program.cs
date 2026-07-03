using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
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
    }
}