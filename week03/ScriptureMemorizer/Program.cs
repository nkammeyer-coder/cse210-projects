using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("");

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