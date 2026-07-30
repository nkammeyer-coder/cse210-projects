public class ListingActivity : Activity
{
    private List<string> _prompts;
    private Random _random = new Random();

    public ListingActivity() : base ("Listing Activity",
    "This activity helps you reflect on certain areas in your life and list them out. This will help you recognize the blessings in your life.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        
    }
    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();

        Console.Write("You can begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");

        DisplayEndMessage();
    }
    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}