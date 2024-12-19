using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var tracker = new GoalTracker();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(tracker);
                    break;
                case "2":
                    RecordEvent(tracker);
                    break;
                case "3":
                    ShowGoals(tracker);
                    break;
                case "4":
                    SaveGoals(tracker);
                    break;
                case "5":
                    LoadGoals(tracker);
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal(GoalTracker tracker)
    {
        Console.WriteLine("\nCreate a New Goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose a goal type: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                tracker.AddGoal(new SimpleGoal(name, points));
                break;
            case "2":
                tracker.AddGoal(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter the target count for the checklist goal: ");
                int targetCount = int.Parse(Console.ReadLine());
                tracker.AddGoal(new ChecklistGoal(name, points, targetCount));
                break;
            default:
                Console.WriteLine("Invalid goal type. Please try again.");
                break;
        }
    }

    static void RecordEvent(GoalTracker tracker)
    {
        Console.Write("Enter the name of the goal to record an event: ");
        string goalName = Console.ReadLine();
        tracker.RecordEvent(goalName);
    }

    static void ShowGoals(GoalTracker tracker)
    {
        Console.WriteLine("\nCurrent Goals:");
        tracker.DisplayGoals();
        Console.WriteLine("\nCurrent Score: " + tracker.GetScore());
    }

    static void SaveGoals(GoalTracker tracker)
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();
        tracker.SaveGoals(filename);
    }

    static void LoadGoals(GoalTracker tracker)
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();
        tracker.LoadGoals(filename);
        Console.WriteLine("\nLoaded Goals:");
        tracker.DisplayGoals();
        Console.WriteLine("\nLoaded Score: " + tracker.GetScore());
    }
}