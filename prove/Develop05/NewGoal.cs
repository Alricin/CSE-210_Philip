using System;

class NewGoal
{
    private string _NewGoalName;
    private string _GoalType;
    private int _PointSetting;
    private int _TimesNeeded;

    public NewGoal()
    {

    }
    public void UserInquiry()
    {
        Console.WriteLine("What is your new goal?");
        _NewGoalName = Console.ReadLine();
        Console.WriteLine("How many points will you assign this goal");
        _PointSetting = int.Parse(Console.ReadLine());
        Console.WriteLine("What type of goal is this goal?");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        int UserAnswer = int.Parse(Console.ReadLine());
        if (UserAnswer == 1)
        {
            _GoalType = "Simple";
        }
        else if (UserAnswer == 2)
        {
            _GoalType = "Eternal";
        }
        else
        {
            _GoalType = "Checklist";
            Console.WriteLine("How many times will you have to perform this goal?");
            _TimesNeeded = int.Parse(Console.ReadLine());
        }
    }

    public string GetNewGoalName()
    {
        return _NewGoalName;
    }

    public int GetGoalPoints()
    {
        return _PointSetting;
    }

    public string GetGoalType()
    {
        return _GoalType;
    }

    public int GetTimesNeeded()
    {
        return _TimesNeeded;
    }
}