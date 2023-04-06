using System;

class Program
{
    static void Main(string[] args)
    {
        Town NewTown = new Town();
        NewTown.GetTownName();
        NewTown.GetTownType();
        NewTown.GetPopulationNumbers();
        for (int i = 0; i < NewTown.ReturnPopulationNumbers(); i = i+1)
        {
            
        }
    }
}