// Create class called Entry
public class Entry
{
    // Set class variables
    public string _date;
    public string _promptText;
    public string _entryText;

    // Function to display Entry class variables in desired output / format
    public void Display()
    {
        // Spacing, display the date / time stamp, Prompt text and user text
        Console.WriteLine();
        Console.WriteLine($"Date  : {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry : {_entryText}");
    }

}