using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        Town NewTown = new Town();
        NewTown.GetTownName();
        NewTown.GetTownType();
        NewTown.GetPopulationNumbers();
        string File = $"{NewTown.ReturnTownName()}.txt";
        int PoliticalJobsLeft = 5;
        int AgriculturalJobsLeft = NewTown.ReturnPopulationNumbers()/2;
        int ArtisanJobsLeft = NewTown.ReturnPopulationNumbers()/3;
        for (int i = 0; i < NewTown.ReturnPopulationNumbers(); i = i+1)
        {
            if (PoliticalJobsLeft > 0)
            {
                Worker Citizen = new Worker();
                Citizen.ChooseName();
                Citizen.ChoosePoliticalOccupation();
                PoliticalJobsLeft = PoliticalJobsLeft - 1;
                using (StreamWriter OutputFile = new StreamWriter(File))
                {
                    OutputFile.WriteLine(Citizen.CompileInformation());
                }
            }
            else if (ArtisanJobsLeft > 0)
            {
                Worker Citizen = new Worker();
                Citizen.ChooseName();
                Citizen.ChooseArtisanJob();
                ArtisanJobsLeft = ArtisanJobsLeft - 1;
                using (StreamWriter OutputFile = new StreamWriter(File))
                {
                    OutputFile.WriteLine(Citizen.CompileInformation());
                }
            }
            else if (AgriculturalJobsLeft > 0)
            {
                Worker Citizen = new Worker();
                Citizen.ChooseName();
                Citizen.ChooseAgriculturalJob();
                AgriculturalJobsLeft = AgriculturalJobsLeft - 1;
                using (StreamWriter OutputFile = new StreamWriter(File))
                {
                    OutputFile.WriteLine(Citizen.CompileInformation());
                }
            }
            else
            {
                Adventurer Citizen = new Adventurer();
                using (StreamWriter OutputFile = new StreamWriter(File))
                {
                    OutputFile.WriteLine(Citizen.CompileInformation());
                }
            }
        }
    }
}