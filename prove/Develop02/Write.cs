using System;

public class Write
{
    List<string> JournalPrompt = new List<string>();
    string PromptQuestion;

    public Write()
    {
        AddPrompts();
        ChoosePrompt();
        DisplayPrompt();
    }
    public void AddPrompts()
    {
        JournalPrompt.Add("Who was the most important person you met today?");
        JournalPrompt.Add("What was the best part of my day?");
        JournalPrompt.Add("How did I see the hand of the Lord in my life today?");
        JournalPrompt.Add("What was the strongest emotion I felt today?");
        JournalPrompt.Add("If I had one thing I could do over today, what would it be?");
        JournalPrompt.Add("What was something I accomplished today?");
        JournalPrompt.Add("What have I learned today?");
        JournalPrompt.Add("What did I read in the scriptures today?");
        JournalPrompt.Add("What did you eat today that you enjoyed?");
        JournalPrompt.Add("What was a funny joke you thought of or heard today?");
    }
    public void ChoosePrompt()
    {
        Random randomGenerator = new Random();
        int PromptNumber = randomGenerator.Next(0, 9);
        PromptQuestion = JournalPrompt[PromptNumber];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(PromptQuestion);
    }

    public string WriteEntry()
    {
        string JournalEntry = Console.ReadLine();
        return JournalEntry;
    }
}