using System;

class Program
{
    static void Main(string[] args)
    {
        string Name = "Jeffery";
        string Topic1 = "Multiplication";
        Assignment Test1 = new Assignment(Name, Topic1);
        string Test1Summary = Test1.GetSummary();
        Console.WriteLine(Test1Summary);

    }
}