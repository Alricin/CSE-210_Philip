using System;
using System.IO;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("From which file will you load your goals?");
        string File = Console.ReadLine();
        WriteGoals Processor = new WriteGoals(File);
        int PointsTotal = 0;
        bool Quit = false;
        while (Quit == false)
        {
            Console.WriteLine("Welcome to the Goal Game Menu");
            Console.WriteLine("Choose one");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            int UserChoice = int.Parse(Console.ReadLine());
            if (UserChoice == 1)
            {
                NewGoal UserGoalType = new NewGoal();
                if (UserGoalType.GetGoalType() == "Simple")
                {
                    Simple UserGoal = new Simple(UserGoalType.GetNewGoalName(), UserGoalType.GetGoalPoints());
                }
                else if (UserGoalType.GetGoalType() == "Eternal")
                {
                    Eternal UserGoal = new Eternal(UserGoalType.GetNewGoalName(), UserGoalType.GetGoalPoints());
                }
                else
                {
                    Checklist UserGoal = new Checklist(UserGoalType.GetNewGoalName(), UserGoalType.GetGoalPoints(), 0, UserGoalType.GetTimesNeeded());
                }
            }
            else if (UserChoice == 2)
            {
                foreach (string entry in Processor.Goals)
                {
                    Console.WriteLine(entry);
                }
            }
            else if (UserChoice == 3)
            {
                using (StreamWriter SaveFile = new StreamWriter(File))
                {
                    SaveFile.WriteLine(PointsTotal);
                    for (int i = 0; i < Processor.Goals.Count; i = i +1)
                    {
                        SaveFile.WriteLine($"{Processor.Goals[i]}, {Processor.GoalsPoints[i]}, {Processor.GoalsTypes[i]}");
                    }
                }
            }
            else if (UserChoice == 4)
            {
                Processor.RetreiveGoals();
                Processor.RetreivePoints();
                Processor.RetrieveGoalType();
                Processor.RetrieveChecklistData();
                PointsTotal = Processor.RetreivePointsTotal();
            }
            else if (UserChoice == 5)
            {

            }
            else
            {
                Quit = true;
            }
        }
        
        
    }
        
}