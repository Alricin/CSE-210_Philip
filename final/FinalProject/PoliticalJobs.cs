using System;

class PoliticalJobs:TownJobs
{

    public PoliticalJobs()
    {

    }
    public override void AddJobs()
    {
        Occupations.Add("Mayor");
        Occupations.Add("Judge");
        Occupations.Add("Officer");
    }
}