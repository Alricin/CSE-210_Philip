using System;

class Checklist:Goal
{
    int _TimesDone;
    int _GoalTimes;
    Checklist(string GoalName, int Points, int TimesDone, int GoalTimes):base(GoalName, Points)
    {
        _TimesDone = TimesDone;
        _GoalTimes = GoalTimes;
    }

    public override void CalculatePointsEarned()
    {
        if (_TimesDone == _GoalTimes)
        {
            _Points = 10*_Points;
        }
    }
}