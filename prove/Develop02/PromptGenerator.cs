public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    { "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What kind act did I do or see someone do today?",
        "What was one thing I prayed about?",
        "Who did I interact with today in a positive way?",
        "What encouraging words did I say today?",
        "What did I do to help someone?",
        "What was one thing I did today without being asked to do it?",
        "How did I relax or destress today?",
        "Who were you most excieted about seeing or talking to today?",
        "How did you exemplify a Christ-like attribute today?",
        "What part of nature did you see that brought you joy?",
        "What task or duty did you fulfill that brought satisfaction?",
        "What is something you could do to improve a relationship?",
        "What animal brings you the most joy?",
        "Where is your Go-To place for peace and quiet?",
        "Describe something beautiful you saw today.",
        "Describe a person you love.",
        "Describe a place you like to visit.",
        "What is something you like about yourself?",
        "Describe a favorite color, why is it your favorite?.",
        "What is one of your favorite songs?",
        "Describe one of your favorite movies.",
        "What is a favorite scripture and why?.",
        "What is one part of the gospel you enjoy.",
        "If you had to live with only one person, who would it be?",
        "Describe the last time you showed love toward someone.",
        "What is your dream job?",
        "If you could have any calling in the church, what would it be?",
        "Describe a favorite calling you have or had.",
        "What talent or gift do you have?",
        "Describe your feelings toward your spouse, child or loved one.",
        "If you could live anywhere, where would it be?.",
        "What is a favorite book of yours?",
        "Where did you serve your mission or where would you want to serve?",
        "What is something you could say that would make someone happy?"
        };
    //public List<string> _PromptGen = new List<string>(_prompts);

    public PromptGenerator()
    {

    }

    public void Display()
    {
        Random rnd = new Random();
        int ThisOne = rnd.Next(_prompts.Count);
        string RandomPrompt = (_prompts[ThisOne]);
        Console.WriteLine(_prompts);
    }
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int ThisOne = rnd.Next(_prompts.Count);
        string RandomPrompt = (_prompts[ThisOne]);

        return RandomPrompt;
        
        // Random rnd = new Random();
        // int ThisOne = rnd.Next(PromptList.Count);

        // Console.WriteLine(PromptList[ThisOne]);
        // string RandomPrompt = (PromptList[ThisOne]);
        // return RandomPrompt;
    }
}