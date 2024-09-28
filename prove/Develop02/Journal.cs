using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public string _userFileName;

    public void AddEntry(Entry newEntry)
    {

    }

    public void DisplayAll()
    {
        Console.Clear();
        Console.WriteLine("----------------------- All Journal Entries ------------------------");
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
        Console.WriteLine("------------------------------- End --------------------------------");
    }


    public void CreateFile()
    
    {
        Console.Clear();
        Console.WriteLine("==== Save Journal Entries To A File ====");
        Console.WriteLine();
        Console.WriteLine("Don't use file extensions ");
        Console.Write("Enter a name for your file: ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (!File.Exists(_userFileName))
        {
            //File.CreateText(_userFileName);
            using(StreamWriter create = File.CreateText(_userFileName))
            {
                string fileName = userInput.ToUpper();
                Console.WriteLine();
                Console.Write($"File named {fileName} created! ");
                Thread.Sleep(1050);
            }

            SaveToFile(_userFileName);
            Console.Clear();

        }
        else if (File.Exists(_userFileName))
        {
            string fileName = userInput.ToUpper();
            Console.WriteLine();
            Console.WriteLine($"The file {fileName} already exists.");
            
            AppendToFile(_userFileName);
            
            Console.Clear();
        }

        else
        {
            string fileName = userInput.ToUpper();
            Console.WriteLine();
            Console.WriteLine($"The file named {fileName} was not found!");
            Console.WriteLine("Please check the spelling and try again.");
            Thread.Sleep(4050);
            Console.Clear();
        }

    }

    public void SaveToFile(string _userFileName)
    {
        string fileName = _userFileName;
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}; {entry._promptText}; {entry._entryText}");
            }
        }
        
        Console.Write($"Your journal has been saved to {fileName} ");
        Thread.Sleep(2750);
    }

    public void AppendToFile(string _userFileName)
    
    {
        string fileName = _userFileName;
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append: true))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}; {entry._promptText}; {entry._entryText}");
            }
        }
    
        Thread.Sleep(1250);
        Console.Write($"Your journal entries have been added to {fileName}.");
        Thread.Sleep(2750);
        
    }

    public void LoadFromFile()
    {
        Console.Clear();
        Console.WriteLine("==== Load A Journal File Into Program ====");
        Console.WriteLine();
        Console.Write("Enter name of file ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (File.Exists(_userFileName))
        {
            string fileName = userInput.ToUpper();
            Console.WriteLine();
            Console.Write($"File {fileName} found!");
            Thread.Sleep(1050);
            Console.Write($" Loading file....");
            Thread.Sleep(1750);

            List<string> journalFile = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in journalFile)
            {
                string[] entries = line.Split("; ");

                Entry entry = new Entry();

                entry._date = entries[0];
                entry._promptText = entries[1];
                entry._entryText = entries[2];

                _entries.Add(entry);
            }

            Console.Clear();
        }

        else
        {
            string fileName = userInput.ToUpper();
            Console.WriteLine();
            Console.WriteLine($"The file named {fileName} was not found!");
            Console.WriteLine("Please check the spelling and try again.");
            Thread.Sleep(4050);
            Console.Clear();
        }
    }

}