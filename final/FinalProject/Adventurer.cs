using System;

class Adventurer: Person
{
    List<int> _StatList = new List<int>();
    Random rnd = new Random();
    string _Class;
    int Level;
    public Adventurer()
    {

    }
    public void GenerateStats()
    {
        
        for (int i =0; i<5; i = i+1)
        {
            _StatList.Add(rnd.Next(1,7)+rnd.Next(1,7)+rnd.Next(1,7));
        }
    }

    public void ChooseClass()
    {
        List<string> ClassList = new List<string>();
        ClassList.Add("Artificer");
        ClassList.Add("Barbarian");
        ClassList.Add("Bard");
        ClassList.Add("Cleric");
        ClassList.Add("Druid");
        ClassList.Add("Fighter");
        ClassList.Add("Monk");
        ClassList.Add("Paladin");
        ClassList.Add("Ranger");
        ClassList.Add("Rogue");
        ClassList.Add("Sorcerer");
        ClassList.Add("Warlock");
        ClassList.Add("Wizard");
        _Class = ClassList[rnd.Next(0,14)];
    }
    public override string CompileInformation()
    {
        return $"{_Name}, {_Sex}, {_Class}:{Level}, {_StatList[0]}, {_StatList[1]},{_StatList[2]},{_StatList[3]},{_StatList[4]},{_StatList[5]},";
    }
}