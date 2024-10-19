using System.IO;
using System.Collections.Generic;
using System.Threading;

// A namespace for better code organization, reduction of conflicts and added encapsulation
namespace mindfulness
{
    // Base class that handles all of the common function used by the sub classes
    public class Activity 
    {
        // Class properties and methods
        private string _promptsPath = "prompts/";
        private int _sessionTime;
        private string[] _animation = {"|", "/", "-", "\\", "|", "/", "-", "\\"};
        
        // Each new instance of Activity will have _sessionTime start at zero
        public Activity (int session = 0)
        {
            _sessionTime = session;
        }

        // Method to set the session time to what is entered by the user
        public void SetSessionTime () 
        {
            Console.Write("Enter the session duration in seconds: ");
            _sessionTime = int.Parse(Console.ReadLine());
            
        }

        // Welcome msg that displays the activity name, calls SetSession and 5 seconds of spinner animation
        public void WelcomeMsg(string activity, string msg)
        {
            Console.WriteLine($"Welcome to the {activity} Activity.\n");
            Console.WriteLine($"{msg}\n");
            SetSessionTime();
            Console.Clear();
            Console.WriteLine("Get ready...");
            GetAnimation(5);

        }

        // Method to display msg at completion of each activity
        public void CompletionMsg (int session, string activity)
        {
            Console.WriteLine("\nWell done!!!");
            Console.Write($"You've completed the {session} seconds of the {activity} Activity. ");
            GetAnimation(5);
            Console.Clear();
        }

        // Method to read prompts from text file and randomly select from a list of unused prompts
        public string GetPrompt (List<string> theList, string file)
        {
            Random random = new ();
            List<string> prompts = new ();
            prompts.AddRange(File.ReadAllLines($"{_promptsPath}/{file}"));
            int randomIndex = random.Next(prompts.Count());
            string thePrompt = prompts[randomIndex];
            theList.Add(thePrompt);
            prompts.RemoveAt(randomIndex);
            if (prompts.Count() == 0)
            {
                prompts.AddRange(theList);
            }
            return thePrompt;
        }

        // Method for calling count down
        public void CountDown (int num)
        {
            Spinner(num, 1);
            Console.WriteLine("");
        }

        // Method for calling animated spinner
        public void GetAnimation (int num) 
        {
            Spinner(num);
            Console.WriteLine("");
        }
        
        // Method to return the session time entered by user
        public int GetSessionTime ()
        {
            return _sessionTime;
        }

        // Method for displaying the spinner
        public bool Spinner(int num, int activity = 0) 
        {
            DateTime date = DateTime.Now;
            DateTime future = date.AddSeconds(num);
            while(date < future)
            {
                if (activity == 0)
                {
                    int i = 0;
                    do 
                    {
                        Console.Write($"{_animation[i]}");
                        Thread.Sleep(500);
                        Console.Write("\b \b");
                        i++;  
                        if(i >= _animation.Length)
                        {
                            i = 0;       
                        }
                    } while (DateTime.Now < future);
                }
                
                if (activity == 1)
                {
                    do 
                    { 
                    Console.Write(num--.ToString().PadLeft(2, '0'));
                    Thread.Sleep(1000);
                    Console.Write("\b \b\b \b");
                    } while (DateTime.Now < future);
                }
                date = DateTime.Now;
            }
            return false;
        }

    }

}