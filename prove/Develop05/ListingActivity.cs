// A namespace for better code organization, reduction of conflicts and added encapsulation
namespace mindfulness
{
    // Sub class Listing of base class Activity
    public class Listing : Activity
    {
        // Set properties for class, includes Lists and Filename
        private string _activityName = "Listing";
        private string _descMsg = "This activity will guide you in listing your thoughts and feelings in response to a given prompt.\nIt's helpful to reflect on your experiences and emotions, which can provide clarity and perspective.";
        private string _listFileName = "list.txt";
        private List<string> _UsedListingPrompt = new ();
        private List<string> _userInputs;

        // Each new instance of Listing will have zero attributes
        public Listing()
        {
        }

        // Method to display listing prompts and store user inputs
        private void DisplayListItem()
        {
            Console.Clear();
            DateTime date = DateTime.Now;
            WelcomeMsg(_activityName, _descMsg);
            DateTime future = date.AddSeconds(GetSessionTime());

            Console.Clear();
            Console.WriteLine($"List your responses to the following prompt:\n\n---- {GetPrompt(_UsedListingPrompt, _listFileName)} ----");
            Console.Write("You may begin in: ");
            CountDown(7);

            _userInputs = new ();

            do
            {
            Console.Write("> ");
            string listResponse = Console.ReadLine();
            _userInputs.Add(listResponse);
            } while (DateTime.Now < future);
        }

        // Method to display the number of list items entered by the user
        private void ListAmount()
        {
            Console.WriteLine($"You listed {_userInputs.Count} items!");
            Thread.Sleep(2500);
            CompletionMsg(GetSessionTime(), _activityName);
        }

        // Method to call to run Listing activity and display results
        public void Run()
        {
            DisplayListItem();
            ListAmount();
        }
    }

}
