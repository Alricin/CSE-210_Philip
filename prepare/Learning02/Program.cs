using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._Company = "BYU-I";
        job1._JobTitle = "custodial";
        job1._StartYear = "2022";
        job1._EndYear = "2023";

        Job job2 = new Job();
        job2._Company = "Wies Markets";
        job2._JobTitle = "Deli Associate";
        job2._StartYear = "2018";
        job2._EndYear = "2020";

        Resume resume1 = new Resume();
        resume1._EmployeeName = "Philip";
        resume1._job.Add(job1);
        resume1._job.Add(job2);
    }
}