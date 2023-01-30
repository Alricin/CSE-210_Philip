using System;

public class Resume
{
    public string _EmployeeName = "";
    public List<Job> _job = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_EmployeeName}");
        Console.WriteLine("Jobs: ");
        foreach (Job job in _job)
        {
            job.DisplayJobDetails();
        }
    }


}