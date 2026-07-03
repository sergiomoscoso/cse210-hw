using System;

public class Job
{
    // Attributes (State) - Using _underscoreCamelCase convention
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // Behavior (Method to display info) - Using TitleCase convention
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}