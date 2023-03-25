using System;

class Assignment
{
    private string _StudentName;
    private string _Topic;
    public string GetSummary()
    {
        return $"{_StudentName} - {_Topic}";
    }

}