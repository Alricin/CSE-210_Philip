using System;

class Town
{
    private string _TownName;
    private string _TownType;
    private int _population;
    private Random rnd = new Random();
    public Town()
    {

    }
    public void GetTownName()
    {
        Console.WriteLine("What is your town's name?");
        _TownName = Console.ReadLine();
    }
    public void GetTownType()
    {
        Console.WriteLine("Is your town a settlement, village, town, or city?");
        _TownType = Console.ReadLine();
    }

    public void GetPopulationNumbers()
    {
        GetTownType();
        if (_TownType == "settlement")
        {
            _population = rnd.Next(0, 200);
        }
        else if (_TownType == "village")
        {
            _population = rnd.Next(200,1000);
        }
        else if (_TownType == "town")
        {
            _population = rnd.Next(1000,6000);
        }
        else
        {
            _population = rnd.Next(6000,25000);
        }
    }
    public int ReturnPopulationNumbers()
    {
        return _population;
    }
    public string ReturnTownName()
    {
        return _TownName;
    }

}