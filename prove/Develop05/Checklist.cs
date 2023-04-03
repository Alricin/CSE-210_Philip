using System;

class Checklist:Goal
{
    int _TimesCompleted;
    int _TimesToComplete;

    public Checklist(string GoalText, string GoalDescription, int GoalPoints, int TimesCompleted, int TimesToComplete):base(GoalText, GoalDescription, GoalPoints)
    {
        _TimesCompleted = TimesCompleted;
        _TimesToComplete = TimesToComplete;
    }
    public override int CalculatePoints()
    {
        return _GoalPoints;
    }
    public void DisplayProgess()
    {
        Console.WriteLine($"{_TimesCompleted}/{_TimesToComplete}");
    }
}