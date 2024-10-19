// A namespace for better code organization, reduction of conflicts and added encapsulation
namespace mindfulness
{
    // Sub class Breathing of base class Activity
    public class Breathing : Activity
    {
        // Set properties for class
        private string _activityName = "Breathing"; 
        private string _descMsg = "This is a guided exercise that will help you relax through slow deep breathing.";

        // Each new instance of Breathing will have zero attributes
        public Breathing ()
        {
        }

        // Method to display welcome msg, display breathing exercise
        private void Breath ()
        {
            DateTime date = DateTime.Now;
            Console.Clear();
            WelcomeMsg(_activityName, _descMsg);
            DateTime future = date.AddSeconds(GetSessionTime());
            int breathingLength = 5;
            
            do
            {
                Console.Write("Breathe IN.... ");
                CountDown(breathingLength);
                Console.Write("Breathe OUT... ");
                CountDown(breathingLength);
                Console.WriteLine("");
                
            } while (DateTime.Now < future);
            CompletionMsg(GetSessionTime(), _activityName);
        }

        // Method that calls the Breath method. No other methods needed here
        public void Run()
        {
            Breath();
        }
    }

}