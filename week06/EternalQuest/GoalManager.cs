using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string choice = "";

        while (choice != "6")
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Please enter a number from 1 to 6.");
            }

            Console.WriteLine();
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            string checkbox;

            if (_goals[i].IsComplete())
            {
                checkbox = "[X]";
            }
            else
            {
                checkbox = "[ ]";
            }

            Console.WriteLine(
                $"{i + 1}. {checkbox} {_goals[i].GetDetailsString()}"
            );
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            SimpleGoal goal = new SimpleGoal(
                shortName,
                description,
                points
            );

            _goals.Add(goal);
        }
        else if (goalType == "2")
        {
            EternalGoal goal = new EternalGoal(
                shortName,
                description,
                points
            );

            _goals.Add(goal);
        }
        else if (goalType == "3")
        {
            Console.Write(
                "How many times does this goal need to be accomplished? "
            );

            int target = int.Parse(Console.ReadLine());

            Console.Write(
                "What is the bonus for accomplishing it that many times? "
            );

            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(
                shortName,
                description,
                points,
                target,
                bonus
            );

            _goals.Add(goal);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine());

        int index = goalNumber - 1;

        if (_goals[index].IsComplete())
        {
            Console.WriteLine("That goal has already been completed.");
            return;
        }

        int pointsEarned = _goals[index].RecordEvent();

        _score += pointsEarned;

        Console.WriteLine(
            $"Congratulations! You have earned {pointsEarned} points!"
        );

        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(
                    goal.GetStringRepresentation()
                );
            }
        }

        Console.WriteLine("Your goals have been saved.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] typeParts = lines[i].Split(":");

            string goalType = typeParts[0];
            string[] details = typeParts[1].Split("|");

            string shortName = details[0];
            string description = details[1];
            int points = int.Parse(details[2]);

            if (goalType == "SimpleGoal")
            {
                bool isComplete = bool.Parse(details[3]);
                string completionDate = details [4];

                SimpleGoal goal = new SimpleGoal(
                    shortName,
                    description,
                    points,
                    isComplete,
                    completionDate
                );

                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(
                    shortName,
                    description,
                    points
                );

                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                int bonus = int.Parse(details[3]);
                int target = int.Parse(details[4]);
                int amountCompleted = int.Parse(details[5]);
                string completionDate = details [6];

                ChecklistGoal goal = new ChecklistGoal(
                    shortName,
                    description,
                    points,
                    target,
                    bonus,
                    amountCompleted,
                    completionDate
                );

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Your goals have been loaded.");
    }
}