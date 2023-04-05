using System;

class TownJobs
{
    List<string> Occupations = new List<string>();
    Random rnd = new Random();
    public TownJobs()
    {

    }
    public void AddJobs()
    {
        Occupations.Add("Actor");
        Occupations.Add("Arborist");
        Occupations.Add("Banker");
        Occupations.Add("Bowyer");
        Occupations.Add("Blacksmith");
        Occupations.Add("Carpenter");
        Occupations.Add("Cartwright");
        Occupations.Add("Chef");
        Occupations.Add("Dancer");
        Occupations.Add("Farmer");
        Occupations.Add("Fisher");
        Occupations.Add("Forester");
        Occupations.Add("Guildmaster");
        Occupations.Add("Hunter");
        Occupations.Add("Innkeeper");
        Occupations.Add("Merchant");
        Occupations.Add("Messenger");
        Occupations.Add("Miller");
        Occupations.Add("Musician");
        Occupations.Add("Painter");
        Occupations.Add("Shepherd");
        Occupations.Add("Stonemason");
        Occupations.Add("Writer");
    }
    public string ChooseJob()
    {
        return Occupations[rnd.Next(0,Occupations.Count)];
    }
}