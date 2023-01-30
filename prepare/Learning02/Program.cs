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
        job1.DisplayJobDetails();
    }
}