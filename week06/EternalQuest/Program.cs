using System;

class Program

// Added date and time stamp to Simple Goals and Checklist Goals.
// This is displayed when the goal is completed and are saved.  Then restored when loading the file.
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}