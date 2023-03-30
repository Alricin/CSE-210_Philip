using System;

class Listing : Activity
{
    int Duration;
    string ListingPrompt;
    List<string> ListingPromptList = new List<string>();
    List<string> UserList = new List<string>();
    
    public Listing(int Duration):base(Duration)
    {

    }

    public void DisplayPrompt()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life");
        ListingPromptList.Add("Who are people that you appreciate?");
        ListingPromptList.Add("What are personal strengths of yours?");
        ListingPromptList.Add("Who are people that you have helped this week?");
        ListingPromptList.Add("When have you felt the Holy Ghost this month?");
        ListingPromptList.Add("Who are some of your personal heroes?");
        Random Prompt = new Random();
        ListingPrompt = ListingPromptList[Prompt.Next(1,6)];
        Console.WriteLine(ListingPrompt);
    }

    public void EncourageUser(int Duration)
    {
        DateTime Start = DateTime.Now;
        DateTime End = Start.AddSeconds(Duration);
        DateTime Current = DateTime.Now;
        DateTime Reminder = Start.AddSeconds(20);
        while (Current < End)
        {
            UserList.Add(Console.ReadLine());
            if (Current > Reminder)
            {
                Console.WriteLine("You're doing a good job, keep going");
            }
        }
        Console.WriteLine("Good job on your list. Here is what you wrote:");
        for (int i = 0; i < UserList.Count; i = i+1)
        {
            Console.WriteLine(UserList[i]);
        }

    }
}