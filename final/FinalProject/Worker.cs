using System;

class Worker: Person
{
    string _Occupation;
    public Worker()
    {

    }

    public void ChoosePoliticalOccupation()
    {
        PoliticalJobs Job = new PoliticalJobs();
        _Occupation = Job.ChooseJob();

    }
    public void ChooseArtisanJob()
    {
        ArtisanJobs Job = new ArtisanJobs();
        _Occupation = Job.ChooseJob();
    }
    public void ChooseAgriculturalJob()
    {
        AgriculturalJobs Job = new AgriculturalJobs();
        _Occupation = Job.ChooseJob();
    }
    public override string CompileInformation()
    {
        return $"{_Name}, {_Sex}, {_Occupation}";
    }
}