using System;

class Program
{
    // Created rules to not duplicate the reflection questions in the same session.
    // Removed the questions after they were asked.
    // Added a duration between 10-90 seconds.
    // Added a prompt requesting a valid number if anything besides 1-4.
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Begin Breathing Activity");
            Console.WriteLine("  2. Begin Reflection Activity");
            Console.WriteLine("  3. Begin Listing Activity");
            Console.WriteLine("  4. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (choice != "4")
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a number from 1 - 4 to continue.");
                Console.ReadLine();
            }
        }
    }
}