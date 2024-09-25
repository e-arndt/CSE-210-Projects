using System;

public class Resume // Create class called Resume
{
    public string _name; // Set member variable (Name of person on resume)

    // Create a new list called _jobs.
    public List<Job> _jobs = new List<Job>();

    public void Display() //Function to display person's name together with jobs
    {
        Console.Clear(); // Clear terminal screen
        Console.WriteLine($"Name: {_name}"); // Display name on resume
        Console.WriteLine("Jobs:"); // Display jobs and job data

        // Loop to read each job's data and display it.
        foreach (Job job in _jobs)
        {
            // Calls display method from the Job class
            job.Display();
        }
        Console.WriteLine(); // Print a blank line for spacing
    }
}