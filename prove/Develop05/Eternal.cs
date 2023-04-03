using System;

class Eternal:Goal
{
    int _DaysSinceDone;
    int _DaysBetweenGoals;
    DateTime _DateLastDone = new DateTime();
    DateTime _CurrentTime = DateTime.Now;

    public Eternal(string GoalText, string GoalDescription, int GoalPoints, DateTime DateLastDone, int DaysBetweenGoals):base(GoalText, GoalDescription, GoalPoints)
    {
        _DateLastDone = DateLastDone;
        _DaysBetweenGoals = DaysBetweenGoals;
        TimeSpan TimeElapsed =_CurrentTime - _DateLastDone;
        _DaysSinceDone = TimeElapsed.Days;
    }

    public void ResetDaysSinceDone()
    {
        _DateLastDone = DateTime.Now;
    }

    public override int CalculatePoints()
    {
        int ElapsedDays = _DaysBetweenGoals - _DaysSinceDone;
        if (ElapsedDays >= 0)
        {
            return _GoalPoints;
        }
        else
        {
            return _GoalPoints - (_DaysSinceDone-_DaysBetweenGoals);
        }
    }
}