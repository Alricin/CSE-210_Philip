using System;

class WriteGoals
{
    private string _filename;
    public List<string> Goals = new List<string>();
    public List<int> GoalsPoints = new List<int>();
    public List<string> GoalsTypes = new List<string>();
    public List<int> TimesDone = new List<int>();
    public List<int> TimesToDo = new List<int>();

    public WriteGoals(string FileName)
    {
        _filename = FileName;
    }

    public void RetreiveGoals()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Goals.Add(parts[0]);

        }
        Goals.RemoveAt(0);
    }

    public void RetreivePoints()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            GoalsPoints.Add(int.Parse(parts[1]));

        }
        Goals.RemoveAt(0);

    }

    public void RetrieveGoalType()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            GoalsTypes.Add(parts[2]);

        }
        Goals.RemoveAt(0);
    }

    public void RetrieveChecklistData()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            TimesDone.Add(int.Parse(parts[3]));
            TimesToDo.Add(int.Parse(parts[4]));

        }
        TimesDone.RemoveAt(0);
        TimesToDo.RemoveAt(0);
    }

    public int RetreivePointsTotal()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);
        return int.Parse(lines[0]);
    }


}