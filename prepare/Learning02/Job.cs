using System;

public class Job
{
    public string _Company = "";
    public string _JobTitle = "";
    public string _StartYear = "";
    public string _EndYear = "";
    public Job()
    {

    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_JobTitle} ({_Company}) {_StartYear}-{_EndYear}");
    }
}