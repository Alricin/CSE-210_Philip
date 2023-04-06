using System;

class AgriculturalJobs: TownJobs
{
    public AgriculturalJobs()
    {

    }
    public override void AddJobs()
    {
        Occupations.Add("Arborist");
        Occupations.Add("Farmer");
        Occupations.Add("Fisher");
        Occupations.Add("Hunter");
        Occupations.Add("Shepherd");
        Occupations.Add("Trapper");

    }
}