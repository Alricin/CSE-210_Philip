using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        bool guess_status = false;
        while (guess_status == false)
        {
            Console.WriteLine("What is your guess?");
            string guess_number = Console.ReadLine();
            int comparative_number = int.Parse(guess_number); 
            if (comparative_number == number)
            {
                guess_status = true;
                Console.WriteLine("That's correct");
            }
            else if (comparative_number > number)
            {
                guess_status = false;
                Console.WriteLine("Guess Lower");
            }
            else if (comparative_number < number)
            {
                guess_status = false;
                Console.WriteLine("Guess Higher");
            }
        }
        
        
    }
}