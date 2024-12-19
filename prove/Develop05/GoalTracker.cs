using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class GoalTracker
{
    private List<Goal> _goals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        var goal = _goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{goal.Name} - Progress: {goal.Progress} - Complete: {goal.IsComplete()}");
        }
    }

    public int GetScore()
    {
        int score = 0;
        foreach (var goal in _goals)
        {
            score += goal.Progress;
        }
        return score;
    }

    public void SaveGoals(string filename)
    {
        var options = new JsonSerializerOptions { WriteIndented = true, Converters = { new JsonStringEnumConverter() } };
        var json = JsonSerializer.Serialize(_goals, options);
        File.WriteAllText(filename, json);
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            var options = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
            var json = File.ReadAllText(filename);
            _goals = JsonSerializer.Deserialize<List<Goal>>(json, options);
        }
    }
}