using System;

class Goal
{
    protected string _GoalName;
    protected int _Points;

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