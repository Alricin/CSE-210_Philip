using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your number?");
        string chosen_number = Console.ReadLine();
        int goal_number = int.Parse(chosen_number);
        bool guess_status = false;
        while (guess_status == false)
        {
            Console.WriteLine("What is your guess?");
            string guess_number = Console.ReadLine();
            int comparative_number = int.Parse(guess_number); 
            if (comparative_number == goal_number)
            {
                guess_status = true;
                Console.WriteLine("That's correct");
            }
            else if (comparative_number > goal_number)
            {
                guess_status = false;
                Console.WriteLine("Guess Lower");
            }
            else if (comparative_number < goal_number)
            {
                guess_status = false;
                Console.WriteLine("Guess Higher");
            }
        }
        
        
    }
}