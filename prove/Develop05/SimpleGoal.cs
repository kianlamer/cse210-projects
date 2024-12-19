public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        Progress = Points;
    }

    public override bool IsComplete()
    {
        return Progress >= Points;
    }
}