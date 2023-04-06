using System;

class Town
{
    string _TownName;
    string _TownType;
    int _population;
    Random rnd = new Random();
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

}