using System;

public class Assignment
{
    protected string _StudentName;
    private string _Topic;

    public Assignment(string StudentName, string Topic)
    {
        _StudentName = StudentName;
        _Topic = Topic;
    }
    public string GetSummary()
    {
        return $"{_StudentName} - {_Topic}";
    }

}