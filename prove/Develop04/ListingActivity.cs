using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Execute()
    {
        StartActivity();
        
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Pause(5); // Pause to allow thinking about the prompt

        Console.WriteLine("Start listing items (press Enter after each).");
        List<string> items = new List<string>();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            string item = Console.ReadLine();
            items.Add(item);
            elapsed += 5; // Each item takes 5 seconds for input
        }

        Console.WriteLine($"You listed {items.Count} items.");
        EndActivity();
    }
}