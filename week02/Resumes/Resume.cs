using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
    

        // Loop to display each job
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}