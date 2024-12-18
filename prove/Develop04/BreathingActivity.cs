using System;
using System.Threading;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Execute()
    {
        StartActivity();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("Breate in. . .");
            Pause(4);
            Console.WriteLine("Breathe out. . .");
            Pause(4);
            elapsed += 8;
        }

        EndActivity();
    }
}