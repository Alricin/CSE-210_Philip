using System;

class Activity
{
    protected int _Duration;
    private string Duration;
    protected string _ActivityType;

    public Activity(int _Duration)
    {

    }

    public string GetActivityType()
    {
        return _ActivityType;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_ActivityType} activity.");

    }

    public void DisplayConcludingMessage()
    {
        Console.WriteLine("Thank you for your time today.");
        Console.WriteLine("We hope you enjoy until next time.");
    }
}