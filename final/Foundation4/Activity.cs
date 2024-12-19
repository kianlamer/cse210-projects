using System;

public abstract class Activity
{
    private DateTime date;
    private int duration; // in minutes

    protected Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public DateTime Date => date;
    public int Duration => duration;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} {GetType().Name} ({duration} min) - Distance: {GetDistance():F1} " +
               $"{(GetType() == typeof(Swimming) ? "meters" : "miles")}, " +
               $"Speed: {GetSpeed():F1} {(GetType() == typeof(Swimming) ? "m/s" : "mph")}, " +
               $"Pace: {GetPace():F1} min per {(GetType() == typeof(Swimming) ? "meter" : "mile")}";
    }
}