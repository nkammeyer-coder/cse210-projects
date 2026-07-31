using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice !="4")
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