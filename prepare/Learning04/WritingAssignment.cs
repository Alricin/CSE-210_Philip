using System;

public class WritingAssignment : Assignment
{
    private string _Title;

    public WritingAssignment(string StudentName, string Topic, string Title) : base(StudentName, Topic)
    {
        _Title = Title;
    }
    
    public string GetWritingInformation()
    {
        return $"{_Title} by {_StudentName}";
    }
}