using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var tracker = new GoalTracker();
        tracker.AddGoal(new SimpleGoal("Run a Marathon", 1000));
        tracker.AddGoal(new EternalGoal("Read Scriptures", 100));
        tracker.AddGoal(new ChecklistGoal("Attend Temple", 10, 50));

        tracker.RecordEvent("Run a Marathon");
        tracker.RecordEvent("Read Scriptures");
        tracker.RecordEvent("Attend Temple");
        tracker.RecordEvent("Attend Temple");

        Console.WriteLine("\nCurrent Goals:");
        tracker.DisplayGoals();
        Console.WriteLine("\nCurrent Score: " + tracker.GetScore());

        // Save goals to a file
        tracker.SaveGoals("goals.json");

        // Load goals from a file
        var newTracker = new GoalTracker();
        newTracker.LoadGoals("goals.json");
        Console.WriteLine("\nLoaded Goals:");
        newTracker.DisplayGoals();
        Console.WriteLine("\nLoaded Score: " + newTracker.GetScore());
    }
}