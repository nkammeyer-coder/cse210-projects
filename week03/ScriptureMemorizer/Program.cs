using System;

class Program
{
    static void Main(string[] args)

    // Added Console.Clear() to refresh the screen each time so there is a new and fresh copy every iteration.
    // Added a completion message with Console.WriteLine("Great job! The scripture is completely hidden now.");
    // The random words to hide intentionally counts by 3 with HideRandomWords(3); to increase the pace slightly.
    {
        Reference reference = new Reference("Ether", 12, 27);
        Scripture scripture = new Scripture(reference,"And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");

        while (true)
        {
            // Clearing the screen so it looks like words disappear.
            Console.Clear();

            // Show the current scripture with any underscores.
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();

            // Checks if words are hidden before prompting the user.
            if (scripture.IsCompletelyHidden())
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
            scripture.HideRandomWords(3);
        }
    }
}