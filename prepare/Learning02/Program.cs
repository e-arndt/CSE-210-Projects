using System;

class Program
{
    static void Main(string[] args)
    {
        // Instance 1 of job class and associated member variables
        Job job1 = new Job();
        job1._jobTitle = "Production Technician";
        job1._company = "NorthWest Cable News";
        job1._startYear = 2015;
        job1._endYear = 2016;

        // Instance 2 of Job class and associated member variables
        Job job2 = new Job();
        job2._jobTitle = "Studio Production Engineer";
        job2._company = "King Broadcasting";
        job2._startYear = 2016;
        job2._endYear = 2023;

        // Create new instance of Resume class
        Resume myResume = new Resume();
        myResume._name = "Eric Arndt"; // Set member variable

        // Add job data from both jobs to list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display(); // Display resume name and jobs from myResume
    }

}