using System;

public class MathAssignment : Assignment
{
    private string _TextbookSection;
    private string _Problems;

    public MathAssignment(string StudentName, string Topic, string TextbookSection, string Problems) : base(StudentName, Topic)
    {
        _TextbookSection = TextbookSection;
        _Problems = Problems;
    }
    public string GetHomeworkList()
    {
        return $"{_TextbookSection} # {_Problems}";
    }

}