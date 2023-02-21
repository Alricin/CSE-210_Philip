using System;

public class Load
{
    string JournalName;
    string JournalText;

    public Load()
    {

    }

    public void ChooseTextFile()
    {
        Console.WriteLine("What is your journal's name?");
        JournalName = Console.ReadLine();
    }
    public void WriteJournalIntoString()
    {
        string FileName = JournalName;
        string[] lines = System.IO.File.ReadAllLines(FileName);

        foreach (string line in lines)
        {
            
        }
    }
}