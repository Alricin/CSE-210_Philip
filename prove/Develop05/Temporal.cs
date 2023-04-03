using System;

class Temporal:Goal
{
    int _DaysSinceSet;
    DateTime _DaySet;

    public Temporal(string GoalText, string GoalDescription, int GoalPoints, DateTime _DaySet):base(GoalText, GoalDescription, GoalPoints)
    {

    }

    public void CalculateDaysSinceSet()
    {
        DateTime CurrentTime = new DateTime();
        TimeSpan TimeElapsed = CurrentTime - _DaySet;
        _DaysSinceSet = TimeElapsed.Days;
        
    }

    public override int CalculatePoints()
    {
        CalculateDaysSinceSet();
        int _PointsReduced = 5*_DaysSinceSet;
        return GetGoalPoints()-_PointsReduced;
    }
}