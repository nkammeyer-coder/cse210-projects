using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Google";
        job1._startYear = 2015;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Senior Software Engineer";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2026;

        job1.Display();
        job2.Display();
    }
}