using System;

class Worker: Person
{
    string _Occupation;
    public Worker()
    {

    }

    public void ChooseOccupation()
    {
        TownJobs Job = new TownJobs();
        _Occupation = Job.ChooseJob();

    }
    public override string CompileInformation()
    {
        return $"{_Name}, {_Sex}, {_Occupation}";
    }
}