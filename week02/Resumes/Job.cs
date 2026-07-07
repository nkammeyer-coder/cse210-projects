using System;

public class Job
{
    public string _jobTitle = "Software Developer";
    public string _company = "Apple";
    public int _startYear = 2015;
    public int _endYear = 2026;
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
}