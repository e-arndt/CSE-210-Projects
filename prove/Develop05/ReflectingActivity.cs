// A namespace for better code organization, reduction of conflicts and added encapsulation
namespace mindfulness
{
    // Sub class Reflection of base class Activity
    public class Reflection : Activity
    {
        // Set properties for class, includes Lists and Filenames
        private string _activityName = "Reflection";
        private string _descMsg = "Take a few moments to reflect on your experiences and insights.\nThis activity will guide you through thoughtful questions to help you gain perspective and cultivate gratitude.";
        private List<string> _UsedPrompts  = new ();
        private List<string> _UsedFollowUpPrompt = new ();
        private string _questionFileName = "questionPrompts.txt";
        private string _followUpFileName = "followUpPrompts.txt";

        // Each new instance of Listing will have zero attributes
        public Reflection () : base()
        {
        }

        // Method to return the name of the activity
        private string GetActivityName()
        {
            return _activityName;
        }

        // Method to display the welcome msg and the Reflection prompt
        private void ReflectionPrompt()
        {   
            Console.Clear();
            WelcomeMsg(_activityName, _descMsg);
            Console.WriteLine($"Consider the following prompt:\n\n---- {GetPrompt(_UsedPrompts, _questionFileName)} ----");
            Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        // Method to display the ponder prompts
        private void PonderPrompts()
        {
            DateTime date = DateTime.Now;
            DateTime future = date.AddSeconds(GetSessionTime());

            do
            {
                Console.Write($"> {GetPrompt(_UsedFollowUpPrompt, _followUpFileName)} ");
                GetAnimation(10);
                
            } while (DateTime.Now < future);

            CompletionMsg(GetSessionTime(), _activityName);
        }

        // Method to call to run the Reflecting activity
        public void Run()
        {
            ReflectionPrompt();
            PonderPrompts();
        }
    }

}