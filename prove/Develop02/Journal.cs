using System;
using System.Collections.Generic;
using System.IO;

// Define class called Journal
public class Journal
{
    // Specify class variables and create new list of "Entry Objects" called _entries 
    public List<Entry> _entries = new List<Entry>();

    public string _userFileName;

    public void AddEntry(Entry newEntry)
    {

    }

    // Function within the Journal class that displays journal entries
    public void DisplayAll()
    {
        // Clear screen, display start banner, loop through each entry, 
        // call Display function for a formatting, display end of entries banner
        Console.Clear();
        Console.WriteLine("----------------------- All Journal Entries ------------------------");
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
        Console.WriteLine("------------------------------- End --------------------------------");
    }

    // Function to create and save files
    public void CreateFile()
    
    {
        // Clear screen, display banner, display user msgs, get user file name, add ".txt" to file name
        Console.Clear();
        Console.WriteLine("==== Save Journal Entries To A File ====");
        Console.WriteLine();
        Console.WriteLine("Don't use file extensions ");
        Console.Write("Enter a name for your file: ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        // If the file doesn't already exist
        if (!File.Exists(_userFileName))
        {
            // Create a text file using the user supplied name with .txt file extension (MyFile.txt);
            using(StreamWriter create = File.CreateText(_userFileName))
            {
                // Convert user file name to upper case for easier reading
                string fileName = userInput.ToUpper();
                // Spacing, tell user file was created, wait about 1 sec
                Console.WriteLine();
                Console.Write($"File named {fileName} created! ");
                Thread.Sleep(1050);
            }
            // Call the SaveToFile function and pass the full file name to function, clear screen
            SaveToFile(_userFileName);
            Console.Clear();

        }

        // If file already exists
        else if (File.Exists(_userFileName))
        {
            // Convert user file name to upper case for easier reading
            string fileName = userInput.ToUpper();
            // Spacing, tell user file already exists
            Console.WriteLine();
            Console.WriteLine($"The file {fileName} already exists.");
            // Call function AppendToFile and pass the full file name to the function
            AppendToFile(_userFileName);
            // Clear screen
            Console.Clear();
        }

        // else assume there is a problem such as a file access problem or the file wasn't found
        // and do the following
        else
        {
            // Convert user file name to upper case for easier reading
            string fileName = userInput.ToUpper();
            // Spacing, display msg, wait about 4 secs, clear screen
            Console.WriteLine();
            Console.WriteLine($"The file named {fileName} was not found!");
            Console.WriteLine("Please check the spelling and try again.");
            Thread.Sleep(4050);
            Console.Clear();
        }

    }

    // Function that saves journal entries to a file
    public void SaveToFile(string _userFileName)
    {
        // Copy user file name to fileName variable
        string fileName = _userFileName;
        // Open newly created file, loop through all entries and write the date, prompt and user text to file
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}; {entry._promptText}; {entry._entryText}");
            }
        }
        // Display user msg that data has been saved to the file, wait about 3 secs
        Console.Write($"Your journal has been saved to {fileName} ");
        Thread.Sleep(2750);
    }

    // Function that appends data to an existing file
    public void AppendToFile(string _userFileName)
    
    {
        // Copy user file name to fileName variable
        string fileName = _userFileName;
        // Open existing file in append mode, loop through all entries and add the date, prompt and user text to file
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append: true))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}; {entry._promptText}; {entry._entryText}");
            }
        }
        // Wait about 1.25 secs to display previous msg generated in else if from CreateFile function
        Thread.Sleep(1250);
        // Tell user their enteries have been added to the file, wait for about 3 secs
        Console.Write($"Your journal entries have been added to {fileName}.");
        Thread.Sleep(2750);
        
    }

    // Function that loads journal entires from a text file
    public void LoadFromFile()
    {
        // Clear screen, display banner, spacing, request file name, add .txt extension to the name
        Console.Clear();
        Console.WriteLine("==== Load A Journal File Into Program ====");
        Console.WriteLine();
        Console.Write("Enter name of file ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        // If that file exists
        if (File.Exists(_userFileName))
        {
            // Convert user file name to upper case for easier reading
            string fileName = userInput.ToUpper();
            // Spacing, display file was found, wait, display file is loading, wait
            Console.WriteLine();
            Console.Write($"File {fileName} found!");
            Thread.Sleep(1050);
            Console.Write($" Loading file....");
            Thread.Sleep(1750);

            // Create a list to read journal files into
            List<string> journalFile = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            // Loop through all entries in file now stored in the list
            foreach (string line in journalFile)
            {
                // Split each string of text into separate parts
                string[] entries = line.Split("; ");

                // New instance on the Entry class
                Entry entry = new Entry();
                // Assign Entry class variables to each "part" of text string, 
                // date, prompt and user text by index #
                entry._date = entries[0];
                entry._promptText = entries[1];
                entry._entryText = entries[2];

                // Add or save to the _entries list of Entry objects, created at the begining of the Journals class
                _entries.Add(entry);
            }
            // Clear screen
            Console.Clear();
        }

        // else assume there is a problem such as a file access problem or the file wasn't found
        // and do the following
        else
        {
            // Convert user file name to upper case for easier reading
            string fileName = userInput.ToUpper();
            // Spacing, display msg, wait about 4 secs, clear screen
            Console.WriteLine();
            Console.WriteLine($"The file named {fileName} was not found!");
            Console.WriteLine("Please check the spelling and try again.");
            Thread.Sleep(4050);
            Console.Clear();
        }
    }

}