using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Ether 12:27");
        Scripture scripture = new Scripture("And if men come unto me I will show unto them their weakness. I giveunto men weakness that they may be hunble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");

        string scriptureText = "";

        while (true)
        {
            // Clearing the screen so it looks like words disappear.
            Console.Clear();

            // Show the current scripture with any underscores.
            Console.WriteLine(Scripture.GetDisplayText());

            Console.WriteLine();

            // Checks if words are hidden before prompting the user.
            (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Great job!  The scripture is completely hidden now."); break;
            }
            Console.WriteLine("Press Enter to hide more words or type 'quit' to end: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            // Hides 3 words at random if they press Enter.
            Scripture.HideRandomWords(3);
        }
    }
}