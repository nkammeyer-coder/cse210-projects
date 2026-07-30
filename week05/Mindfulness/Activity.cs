public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.WriteLine();

        int userDuration = 0;

        while (userDuration <10 || userDuration > 90)
        {
            Console.Write("Enter the duration of your session (10-90 seconds): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out userDuration))
            {
                Console.WriteLine("Please enter a valid number (10-90 seconds).");
            }
            else if (userDuration < 10 || userDuration > 90)
            {
                Console.WriteLine("Please enter a number between 10 and 90.");
            }
            }
        _duration = userDuration;

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(5); // Showing spinner while the user "gets ready"
        }
    public void ShowCountDown(int seconds)
{
    for (int i = seconds; i > 0; i--)
    {
        Console.Write(i);
        Thread.Sleep(1000);

        Console.Write("\b \b");
    }
}
    public int GetDuration()
    {
        return _duration;
    }    
    protected void ShowSpinner(int seconds)
{
    string[] spinner = { "|", "/", "-", "\\" };

    DateTime endTime = DateTime.Now.AddSeconds(seconds);

    int i = 0;

    while (DateTime.Now < endTime)
    {
        Console.Write(spinner[i % 4]);
        Thread.Sleep(150);
        Console.Write("\b \b");
    }
}
    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine();

        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");

        Console.WriteLine();
        Console.WriteLine("Press Enter to return to the menu...");
        Console.WriteLine();
    }
}