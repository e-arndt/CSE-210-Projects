using System;

public class Job // create class called Job
{
    public string _jobTitle; // Set member variables for job data
    public string _company;
    public int    _startYear;
    public int    _endYear;

    public void Display() // Function to display job data
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}