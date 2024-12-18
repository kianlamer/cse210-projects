using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public MindfulnessActivity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"{_activityName}\n{_description}\n");
        Console.Write("Enter the duration (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready. . .");
        Pause(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("Great job! You completed the activity.");
        Console.WriteLine($"Activity: {_activityName} | Duration: {_duration} seconds");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Execute();
}