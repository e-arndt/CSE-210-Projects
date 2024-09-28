// Creativity: Datestamp shows Date and Time, in case of multiple entires per day, rather than just a date.
// Each menu function has its own "page" with a title banner for a cleaner, eaiser to read look.
// Added messages to user to inform them when files and data are found, not found, created, saved and loaded.
// User only needs to type the name of the file, the program deals with the file extension like .txt
// Some error handling for invalid inputs
// Added a gracefull program exit and lots of text / screen formating for a clean and organized look.
// Added lots of my own prompt messages


using System;
using System.IO;


// Define the Program class
class Program
{

    // The Main function
    static void Main(string[] args)
    {
        // Set the variable choice to 0
        int choice = 0;
    
        // Clear screen, Display Welcome Banner
        Console.Clear();
        Console.WriteLine("==== Welcome to the Journal Program ====");
        
        // Start a new instance of the Journal Class and the PromptGenerator Class
        Journal journal = new Journal();
        PromptGenerator newpt = new PromptGenerator();
        
        // Process the following code while the user hasn't selected '5' to quit
        while (choice != 5)
        {
            // Call the Menu Function which displays a menu and asks user for a selection
            choice = Menu();

            // Based on the menu choice of user, select or switch to on of the foollowing options
            switch(choice)
            {
                // Option 1 - Write an entry
                case  1: 
                    // Call the GetDateTime and GetRandomPrompt functions, store returned values in variables
                    string dateStamp = GetDateTime();
                    string prompt = newpt.GetRandomPrompt();
                    
                    // Create new instance of Entry class and store the vaules from above into the Entry class variables,
                    // called _date and _promptText
                    Entry entry = new Entry();
                    entry._date = dateStamp;
                    entry._promptText = prompt;

                    // Clear screen, display banner for current operation, print a random prompt, 
                    // get user response and store in Entry class variable -entryText
                    Console.Clear();
                    Console.WriteLine("==== Add a Journal Entry ====");
                    Console.WriteLine();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write(">");
                    string userEntry = Console.ReadLine();
                    entry._entryText = userEntry;

                    // Write user response to List named _entries, 
                    // which is in the Journal class with instance name of journal
                    journal._entries.Add(entry);

                    // Clear the screen
                    Console.Clear();

                    // end of this option, go back and see if the while statement is still true,
                    // which if true will run again starting with the main menu.
                    break;

                // Option 2 - Display all currently loaded or typed journal entries
                case  2: 
                    // Call the DisplayAll function of the journal instance under the Journal class
                    // to display all current journal entries
                    journal.DisplayAll();
                    // Blank line for spacing
                    Console.WriteLine();
                    // Display message for user to press Enter when done viewing entries
                    Console.Write("Press ENTER to continue ");
                    // Reads input from user, in this case just waiting for an "empty" input.
                    Console.ReadLine();
                    // Clear screen
                    Console.Clear();

                    // end of this option, go back and see if the while statement is still true,
                    // which if true will run again starting with the main menu.
                    break;

                // Option 3 - Load saved journal entries from a save file
                case  3: 
                    // Call the LoadFromFile function of the journal instance of the Journal class
                    // which will ask user for a file name and load from that file, if found
                    journal.LoadFromFile();

                    // end of this option, go back and see if the while statement is still true,
                    // which if true will run again starting with the main menu.
                    break;

                // Option 4 - Saved journal entries to a save file
                case  4: 
                    // Call the CreateFile function of the journal instance of the Journal class
                    // which will ask user for a file name and save journal entries to that file, if found
                    // or create the file if not found.
                    journal.CreateFile();

                    // end of this option, go back and see if the while statement is still true,
                    // which if true will run again starting with the main menu.
                    break;

                // Option 5 - Ends the program
                case  5: 
                    // Call the EndProgram function
                    EndProgram();

                    // end of this option, go back and see if the while statement is still true,
                    // which if true will run again starting with the main menu.
                    // In this case, '5' was entered, so the while statement is now false and
                    // this code will not run again.
                    break;

                // In the case that 1 - 5 was not entered, this message will display
                default: 
                    // Spacing, display message, wait for about 1.5 seconds, clear screen
                    Console.WriteLine();
                    Console.Write("Invalid entry "); 
                    Thread.Sleep(1550);
                    Console.Clear();

                    // end of this option, go back and see if the while statement is still true,
                    // which if true will run again starting with the main menu.
                    break;

            }
            
        }
    }

    // Main Menu function
     static int Menu()
    // Method to display choices to user
    {
        // Set string called menu to the follwing string, exactly as formatted
        string menu = @"
Please select one of the following choices:
1. Write in Journal
2. Display Journal
3. Load Journal File
4. Save Journal File
5. Quit
What would you like to do? ";

        // Display the menu string
        Console.Write(menu);
        // Get input from user
        string userInput = Console.ReadLine();
        // Set varible 'choice' to equal 0
        int choice = 0;

        // Error handling for non integer values entered
        try
        {
            // Set variable 'choice' to equal the userInput variable
            choice = int.Parse(userInput);
        }
        catch (FormatException)
        {
            choice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }

        // Return the value stored in variable to the code that called the function
        return choice;
    }


    // Date and Time function
    static string GetDateTime()
    // Method that gets the date and time to add to journal record
    {
        // New instance of DateTime, calling for current date and time (Now) and storing value in the 'now' variable
        DateTime now = DateTime.Now;
        // Format the 'now' string and save to currentDateTime variable
        string currentDateTime = now.ToString("F");
        // Return the value stored in variable to the code that called the function
        return currentDateTime;
    }

    // Function that gracefully quits the program
    static void EndProgram()
    {
        // Clear screen, display thank you msg, wait 2.5 sec, clear screen, space 2 lines
        Console.Clear();
        Console.WriteLine("Thank you for using the Journal Program");
        Thread.Sleep(2050);
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine();
    }


}
