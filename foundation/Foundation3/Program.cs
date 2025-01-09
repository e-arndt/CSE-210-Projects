using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Exercise Traking");
        Console.WriteLine("");

        List<Activity> activities = new();
        
        Running running = new();
        running.StartRunning();
        activities.Add(running);
        

        Cycling cycling = new();
        cycling.StartCycling();
        activities.Add(cycling);
        

        Swimming swimming = new();
        swimming.StartSwimming();
        activities.Add(swimming);
        
    
        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
                        
                
            
            
        
    }
} 