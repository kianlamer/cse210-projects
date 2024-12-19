using System;

public class Swimming : Activity
{
    private int laps; // number of laps

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * 50 / 1000.0; // Distance in km

    public override double GetSpeed() => (GetDistance() / Duration) * 60; // Speed in kph

    public override double GetPace() => Duration / GetDistance(); // Pace in min per km

    public override string GetSummary()
    {
        return $"{base.GetSummary()} (Laps: {laps})";
    }
}