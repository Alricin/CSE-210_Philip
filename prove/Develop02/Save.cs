using System; 
using System.IO;

public class Save
{
    string JournalName;
    DateTime DateAndTime;
    string UsersEntry;

    public Save()
    {
        FindDateAndTime();
        FindJournalName();
    }

    public void FindDateAndTime()
    {
        DateTime CurrentTime = DateTime.Now;
        DateAndTime = CurrentTime;
        
    }

    public void FindJournalName()
    {
        Console.WriteLine("What is the name of your journal?");
        JournalName = Console.ReadLine();
    }

    public void SaveEntryInJournal()
    {
        string fileName = $"{JournalName}.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(DateAndTime);
            outputFile.WriteLine(UsersEntry);
        }
    }
}