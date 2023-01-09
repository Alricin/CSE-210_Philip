using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage");
        string Score = Console.ReadLine();

        int Grade = int.Parse(Score);
        string Verdict = "N/A";

        if (Grade >= 90)
        {
            Verdict = "A";
        }
        else if (Grade >= 80)
        {
            Verdict = "B";
        }
        else if (Grade >= 70)
        {
            Verdict = "C";
        }
        else if (Grade >= 60)
        {
            Verdict = "D";
        }
        else 
        {
            Verdict = "F";
        }
        Console.WriteLine($"Your grade is {Verdict}");
        
        if (Grade >= 70)
        {
            Console.WriteLine("Congratulations!! You passed");
        }
        else 
        {
            Console.WriteLine("You failed. Good luck next time!");
        }

    }
}