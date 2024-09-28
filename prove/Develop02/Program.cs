using System;
using System.IO;


class Program
{

    static void Main(string[] args)
    {
        int choice = 0;
    
        Console.Clear();
        Console.WriteLine("==== Welcome to the Journal Program ====");
        

        Journal journal = new Journal();
        PromptGenerator newpt = new PromptGenerator();
        

        while (choice != 5)
        {

            choice = Menu();


            switch(choice)
            {
                case  1: 
                    string dateStamp = GetDateTime();
                    string prompt = newpt.GetRandomPrompt();
                    
                    Entry entry = new Entry();
                    entry._date = dateStamp;
                    entry._promptText = prompt;

                    Console.Clear();
                    Console.WriteLine("==== Add a Journal Entry ====");
                    Console.WriteLine();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write(">");
                    string userEntry = Console.ReadLine();
                    entry._entryText = userEntry;

                    journal._entries.Add(entry);

                    Console.Clear();

                    break;


                case  2: 
                    journal.DisplayAll();
                    Console.WriteLine();
                    Console.Write("Press ENTER to continue ");
                    Console.ReadLine();
                    Console.Clear();

                    break;


                case  3: 
                    journal.LoadFromFile();

                    break;


                case  4: 
                    journal.CreateFile();

                    break;


                case  5: 
                    EndProgram();

                    break;


                default: 
                    Console.WriteLine();
                    Console.Write("Invalid entry "); 
                    Thread.Sleep(1550);
                    Console.Clear();
                    break;

            }
            
        }
    }


     static int Menu()
    // Method to display choices to user
    {
        
        string menu = @"
Please select one of the following choices:
1. Write in Journal
2. Display Journal
3. Load Journal File
4. Save Journal File
5. Quit
What would you like to do? ";

        Console.Write(menu);
        string userInput = Console.ReadLine();
        int choice = 0;
        // Error handling for non integer values entered
        try
        {
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
        return choice;
    }



    static string GetDateTime()
    // Method that gets the date and time to add to journal record
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        
        return currentDateTime;
    }

    static void EndProgram()
    {
        Console.Clear();
        Console.WriteLine("Thank you for using the Journal Program");
        Thread.Sleep(2050);
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine();
    }


}
