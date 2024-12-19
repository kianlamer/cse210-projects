public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        Progress += Points;
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }
}