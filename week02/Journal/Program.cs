using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please choose an option from the choices below:");
            Console.WriteLine("1. Write a Message in Your Journal");
            Console.WriteLine("2. Display Your Journal Records");
            Console.WriteLine("3. Load a Record");
            Console.WriteLine("4. Save Your Progress");
            Console.WriteLine("5. Quit Journal Program");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();
        }
    }
}