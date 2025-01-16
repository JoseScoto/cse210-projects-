using System;
public class Job
{
    // These are the member variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Behavior (Methods)
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

