using System;

class Program
{
    static void Main(string[] args)

    // Creativity - I exceeded the core requirements by recording the time
    // in each journal entry was written in addition to the date.
    // Furthermore, it was converted to 12-hour format with AM/PM.
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

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("Press Enter when Done >>> ");

                string response = Console.ReadLine();

                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._time = DateTime.Now.ToString("h:mm tt");
                entry._promptText = prompt;
                entry._userText = response;

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the name of the file? ");
                string fileName = Console.ReadLine();

                journal.LoadFromFile(fileName);
            }
            else if (choice == "4")
            {
                Console.Write("What is the name of the file you are saving? ");
                string fileName = Console.ReadLine();

                journal.SaveToFile(fileName);
            }

        }
    }
}