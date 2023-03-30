using System;

class Breathing : Activity
{
    private int Duration;
    public Breathing(int Duration) : base(Duration) 
    {

    }
    
    public void DisplayBreathing(int Duration)
    {
        Console.WriteLine("This activity will help you relax by walking through the breathing process with you");
        while (Duration > 0)
        {
            Console.WriteLine("Breath in");
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.WriteLine("Breath out");
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Duration = Duration - 6;
        }
    }
}