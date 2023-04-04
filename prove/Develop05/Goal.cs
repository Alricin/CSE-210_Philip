using System;

class Goal
{
    string _GoalName;
    int _Points;

    public Goal(string GoalName, int Points)
    {
        _GoalName = GoalName;
        _Points = Points;
    }

    public int GetPoints()
    {
        return _Points;
    }

    public virtual void CalculatePointsEarned()
    {
    }
}