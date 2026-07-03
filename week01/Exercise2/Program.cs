using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string number = Console.ReadLine();
        int percentage = int.Parse(number);

        string grade = "";

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is an \"{grade}\"");

        if (percentage >= 70)
        {
            Console.WriteLine("Yay! You passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately you didn't pass. Better luck next time.");
        }
    }
}