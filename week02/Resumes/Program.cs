using System;

class Program
{
    static void Main()
    {
        // 1. Create a new Resume object
        Resume myResume = new Resume();
        myResume._name = "Sergio Moscoso";

        // 2. Create Job objects and set their data
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2024;

        // 3. Add jobs to the resume list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // 4. Display the full resume (this calls the Display method which loops through jobs)
        myResume.Display();
    }
}