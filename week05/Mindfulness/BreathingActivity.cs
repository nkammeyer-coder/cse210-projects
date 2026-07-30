public class BreathingActivity : Activity
{
  public BreathingActivity()
    : base("Breathing Activity",
    "This activity will help you relax by walking you through breathing in and out slowly at your specified pace. Clear your mind and focus on your breathing.")
{
}
public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in...");
            ShowCountDown(4);

            Console.WriteLine();

            Console.Write("Breath out...");
            ShowCountDown(6);

            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndMessage();

    }
}