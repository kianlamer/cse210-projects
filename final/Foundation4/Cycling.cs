using System;

public class Cycling : Activity
{
    private double speed; // in mph

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed / 60) * Duration; // Distance in miles

    public override double GetSpeed() => speed; // Speed in mph

    public override double GetPace() => 60 / speed; // Pace in min per mile
}