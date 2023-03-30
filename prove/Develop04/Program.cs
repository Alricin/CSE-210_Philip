using System;

class Program
{
    static void Main(string[] args)
    {
        bool Quit = false;
        while (Quit == false)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Breathing Activity");
            Console.WriteLine("   2. Reflection Activity");
            Console.WriteLine("   3. Lisitng Activity");
            Console.WriteLine("   4. Quit");
            Console.WriteLine("Select a choice form the Menu");
            int Choice = int.Parse(Console.ReadLine());
            Console.WriteLine("How Long would you like to spend on this?");
            int TimeSpent = int.Parse(Console.ReadLine());

            if (Choice == 1)
            {
                Breathing Breaths = new Breathing(TimeSpent);
                Breaths.DisplayStartingMessage();
                Breaths.DisplayBreathing(TimeSpent);
                Breaths.DisplayConcludingMessage();
            }
            else if (Choice == 2)
            {
                Reflection reflect = new Reflection(TimeSpent);
                reflect.DisplayStartingMessage();
                reflect.DisplayPrompt();
                reflect.DisplayQuestion(TimeSpent);
                reflect.DisplayConcludingMessage();
            }
            else if (Choice == 3)
            {
                Listing inspire = new Listing(TimeSpent);
                inspire.DisplayStartingMessage();
                inspire.DisplayPrompt();
                inspire.EncourageUser(TimeSpent);
                inspire.DisplayConcludingMessage();
            }
        }
    }
}