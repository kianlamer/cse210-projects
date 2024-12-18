using System.Diagnostics.Contracts;

public class MathAssignment : Assignment
{
    private string _section;

    public MathAssignment(string studentName, string topic, string section)
        : base(studentName, topic)
    {
        _section = section;
    }

    public string GetHomeworkList()
    {
        return $"Section {_section}";
    }
}