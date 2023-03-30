using System;

class Reflection: Activity
{
    string _prompt;
    string questions;
    int Duration;
    
    public Reflection(int Duration) : base(Duration)
    {

    }

    public void DisplayPrompt()
    {
        Random rnd = new Random();
        int PromptNumber = rnd.Next(1,5);
        if (PromptNumber == 1)
        {
            Console.WriteLine("Think of a time when you stood up for someone else");
        }
        else if (PromptNumber == 2)
        {
            Console.WriteLine("Think of a time when you did something difficult");
        }
        else if (PromptNumber == 3)
        {
            Console.WriteLine("Think of a time when you helped someone in need");
        }
        else
        {
            Console.WriteLine("Think of a time when you did something truly selfless");
        }
    }

    public void DisplayQuestion(int Duration)
    {
        List<string> Questions = new List<string>();
        Questions.Add("Why was this experience meaningful to you?");
        Questions.Add("Have you ever done anything like this before?");
        Questions.Add("How did you get started?");
        Questions.Add("How did you feel when it was complete?");
        Questions.Add("What made this time different than other times when you were not as successful?");
        Questions.Add("What is your favorite thing about this experience?");
        Questions.Add("What could you learn from this experience that applies to other situations?");
        Questions.Add("What did you learn about yourself through this experience?");
        Questions.Add("How can you keep this experience in mind in the future?");

        while (Duration > 0)
        {
            
            Random rnd = new Random();
            int QuestionNumber = rnd.Next(1,10);
            Console.WriteLine(Questions[QuestionNumber]);
            for (int i = 0; i < 6; i = i + 1)
            {
                Console.Write(". ");
                Thread.Sleep(1000);
            }
            Duration = Duration - 6;
            
        }
    }
}