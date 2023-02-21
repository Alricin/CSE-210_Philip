using System;

public class Load
{
    string JournalName;
    string JournalText;

    public Load()
    {
        ChooseTextFile();
    }

    public void ChooseTextFile()
    {
        Console.WriteLine("What is your journal's name?");
        JournalName = Console.ReadLine();
    }
    public void WriteJournalIntoString()
    {
        string FileName = JournalName;
        string[] JournalText = System.IO.File.ReadAllLines(FileName);  
    }
}