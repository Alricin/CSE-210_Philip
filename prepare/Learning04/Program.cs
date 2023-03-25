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
        
        string Topic2 = "Fractions";
        string Topic2Section = "7-2";
        string Topic2Problems = "1,3,5,9,15";
        MathAssignment Test2 = new MathAssignment(Name, Topic2, Topic2Section, Topic2Problems);
        string Test2Summary = Test2.GetSummary();
        string Test2Homework = Test2.GetHomeworkList();
        Console.WriteLine(Test2Summary);
        Console.WriteLine(Test2Homework);

    }
}