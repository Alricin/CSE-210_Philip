using System;

class Goal
{
    protected string _GoalText;
    protected string _GoalDescription;
    protected int _GoalPoints;
    public Goal(string GoalText, string GoalDescription, int GoalPoints)
    {
        _GoalText = GoalText;
        _GoalDescription = GoalDescription;
        _GoalPoints = GoalPoints;
    }

    public string GetGoalText()
    {
        return _GoalText;
    }

    public string GetGoalDescription()
    {
        return _GoalDescription;
    }

    public int GetGoalPoints()
    {
        return _GoalPoints;
    }

    public int AddPoints()
    {
        return CalculatePoints();
    }
    public virtual int CalculatePoints()
    {
        return 0;
    }
}