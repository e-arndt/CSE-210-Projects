// class that manages the functioning of the program
// Includes menu systems and non-inherited classes or functions

using System;
using System.IO;

// GoalManager attributes and methods
public class GoalManager
{
    private List<Goal> _goals = new ();
    private int _score;

    private int _count = 0;

    private string _folderPath = "saved/";

    public GoalManager()
    {

    }

    // Function to handle exiting of the program
    static void EndProgram()
    {
        // Clear screen, display thank you msg, wait 2.5 sec, clear screen, space 2 lines
        Console.Clear();
        Console.Write("Thank you for using the Eternal Quest Program ");
        Thread.Sleep(3000);
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine();
        System.Environment.Exit(1);
    }

    // Function to handle menu system for the 3 goal choices
    private void CreateNewGoalMenu()
    {
        // Initialize new variable as an integer
        int userChoice;
        // Do this code, then check the while condition
        do
        {
            // Print menu to terminal screen
            Console.Clear();
            Console.Write("     Type Of New Goal\n");
            Console.WriteLine("===========================\n");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Return to Main Menu");
            
            Console.Write("Select a menu option: ");
        
            // Menu option input from user, convert from string to integer
            userChoice = int.Parse(Console.ReadLine()); 
            Console.WriteLine("");

            // If option 1, Call the CreateSimpleGoal function
            if (userChoice == 1)
            {
                CreateSimpleGoal();
            }
            // If option 2, Call the CreateEternalGoal function
            else if(userChoice == 2)
            {
                CreateEternalGoal();
            }
            // If option 3, Call the CreateListGoal function - CheckList Goal
            else if (userChoice == 3)
            {
                CreateListGoal();
            }
            // If option 4, Call the MainMenu function
            else if (userChoice == 4)
            {
                MainMenu();
            }
            //Else assume an invalid entry was made, display error msg
            else
            {
                Console.WriteLine("Invalid Entry - [1-4]");
                Thread.Sleep(2700);
            }

        } while (userChoice != 4);
        
    }


    // Function that handles the main menu options
    public void MainMenu()
    {
        // Initialize new variable as an integer
        int userChoice;
        // Do this code, then check the while condition
        do
        {
            // Print menu to terminal screen
            Console.Clear();
            DisplayScore();
            Console.Write("   Eternal Goals Quest\n");
            Console.WriteLine("===========================\n");
            Console.WriteLine("1. Create A Goal");
            Console.WriteLine("2. List My Goals");
            Console.WriteLine("3. Save My Goals");
            Console.WriteLine("4. Load My Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a menu option: ");
        
            // Menu option input from user, convert from string to integer
            userChoice = int.Parse(Console.ReadLine()); 


            // If option 1, Call the menu function to choose one of the 3 goals
            if (userChoice == 1)
            {
                CreateNewGoalMenu();
            }
            // If option 2, Call the function to list your goals
            else if(userChoice == 2)
            {
                ListGoals();
            }
            // If option 3, Call the function to save your goals to a file
            else if (userChoice == 3)
            {
                SaveGoal();
            }
            // If option 4, Call the function to load your goals from a file
            else if (userChoice == 4)
            {
                LoadGoals();
            }
            // If option 5, Call the function to record a goal event
            else if (userChoice == 5)
            {
                RecordEvent();
            }
            // If option 6, Call the end of program function
            else if (userChoice == 6)
            {
                EndProgram();
            }
            //Else assume an invalid entry was made, display error msg
            else
            {
                Console.WriteLine("Invalid Entry - [1-6]");
                Thread.Sleep(2700);
            }

        } while (userChoice != 6);
        EndProgram();

    }

    // Function to display the current points
    private void DisplayScore()
    {
        Console.WriteLine($" Your score is {_score} points\n");
    }

    // Function to display a list of goal names to choose from in the record event menu
    private void ListGoalNames()
    {
        if (_goals.Count != 0)
        {
            foreach (Goal goal in _goals)
            {
                _count++;
                Console.WriteLine($"{_count}. {goal.GetGoalName()}");
            }
            _count = 0;
        }
        else 
        {
            Console.WriteLine("The goal list is empty. Try loading a list");
            Thread.Sleep(3000);
            MainMenu();
        }
    }

    // Function that lists your current goals and details such as completion
    private void ListGoalDetails()
    {
        if (_goals.Count != 0)
        {
            foreach (Goal goal in _goals)
            {
                _count++;
                Console.WriteLine($"{_count}. {goal.GetDetailsString()}");
            }
            _count = 0;
        }
        else 
        {
            Console.WriteLine("The goal list is empty.");
        }
    }

    // Menu function for the Simple Goals
    private void CreateSimpleGoal()
    {
        Console.Clear();
        Console.Write("  Create New Simple Goal\n");
        Console.WriteLine("===========================\n");
        CreateGoal(1);
        
    }

    // Menu function for the Eternal Goals
    private void CreateEternalGoal()
    {
        Console.Clear();
        Console.Write("  Create New Eternal Goal\n");
        Console.WriteLine("===========================\n");
        CreateGoal(2);
        
    }

    // Menu function for the Checklist Goals
    private void CreateListGoal()
    {
        Console.Clear();
        Console.Write(" Create New Checklist Goal\n");
        Console.WriteLine("===========================\n");
        CreateGoal(3);
        
    }

    // Function to create new goals
    private void CreateGoal(int choice)
    {
        string[] goalTypes = {"Simple Goal", "Eternal Goals", "Checklist Goals"};
        
        int typeOfGoal = choice - 1;

        if (typeOfGoal == 0)
        {
            SimpleGoal simpleGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoints(), goal: goalTypes[typeOfGoal]);
            _goals.Add(simpleGoal);
        }
        else if (typeOfGoal == 1)
        {
           EternalGoal eternalGoal = new (name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoints(), goal: goalTypes[typeOfGoal]);
           _goals.Add(eternalGoal);
        }
        else if (typeOfGoal == 2)
        {
            CheckListGoal checkListGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoints(), goal: goalTypes[typeOfGoal], target: SetCheckListCount(), bonus: SetBonusPoint());
            _goals.Add(checkListGoal);
        }
        else
        {
            Console.WriteLine("Invalid Entry.");
        }
    }

    // Menu function for Record Goal Event, also updates score, displays congrats msg and calls Record Event function
    private void RecordEvent()
    {
        Console.Clear();
        Console.Write("     Record Goal Event\n");
        Console.WriteLine("===========================\n");
        ListGoalNames();
        Console.Write("\nSelect goal to update: ");
        int goalCompleteIndex = int.Parse(Console.ReadLine());

        Goal goalAccomplished = _goals[goalCompleteIndex - 1];
        
        goalAccomplished.SetIsCompleteToTrue();
        goalAccomplished.RecordEvent();
        _score += goalAccomplished.GetSetPoint();
        //goalAccomplished.GetCurrentPoint();

        string congratMessage = $"\nWOW! You earned {goalAccomplished.GetSetPoint()}\nYou now have {_score} points";
        Console.WriteLine(congratMessage);
        
        Thread.Sleep(3550);
    }

    // Menu function for listing of Goals, calls the ListGoalDetails function
    private void ListGoals()
    {
        Console.Clear();
        Console.Write("      List Of My Goals\n");
        Console.WriteLine("===========================\n");
        ListGoalDetails();
        Console.Write("\nPress enter when done. ");
        Console.ReadLine();
    }

    // Function for saving goals to a file
    private void SaveGoal()
    {
        Console.Clear();
        Console.Write("    Save Goals To File\n");
        Console.WriteLine("===========================\n");
        Console.Write("Enter a filename: ");
        string fileName = Console.ReadLine();

        using StreamWriter saveGoals = new($"{_folderPath}{fileName}.txt");
        saveGoals.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            saveGoals.WriteLine(goal.GetStringRepresentation());
        }
        _goals.Clear();
        Console.WriteLine();
        Console.WriteLine($"Your goals have been saved to {fileName}.txt");
        Thread.Sleep(2550);

        
    }
    // Function for loading goals from a file
    private void LoadGoals()
    {
        string[] files = Directory.GetFiles(_folderPath);

        if (files.Length != 0)
        {
            Console.Clear();
            Console.Write("    Load Goals From File\n");
            Console.WriteLine("===========================\n");
            
            foreach (string file in files)    
            {
                _count++;
                Console.WriteLine($"{_count}. {Path.GetFileNameWithoutExtension(file)}");
            }
            _count = 0;

            Console.WriteLine();
            Console.Write("Enter # of file to load: ");
            int fileFromList = int.Parse(Console.ReadLine());
            string[] fileContent = File.ReadAllLines(files[fileFromList - 1]);

            _goals.AddRange(ConvertToGoalObjects(fileContent));
        } 
        else Console.WriteLine("Sorry, no files were found.");
        Thread.Sleep(2050);
    }

    // Function that asks user to name their new goal
    private string SetGoalName()
    {
        Console.Write("What is the name of your new goal  : ");
        string _goalname = Console.ReadLine();
        return _goalname;
    }

    // Function that asks user to describe their new goal
    private string SetGoalDescription()
    {
        Console.Write("A short description your new goal  : ");
        string _goalDescription = Console.ReadLine();
        return _goalDescription;
    }

    // Function that asks user to give their new goal a point value
    private int SetGoalPoints()
        {
            Console.Write("Enter a point value for this goal  : ");
            int _goalPoints = int.Parse(Console.ReadLine());
            return _goalPoints;
        }

    // Function that asks user to give their new goal a bonus point value
    private int SetBonusPoint()
    {
        Console.Write("Bonus points for achieving the goal: ");
        int _bonusPoint = int.Parse(Console.ReadLine());
        return _bonusPoint;
    }

    // Function that asks user to give their new goal a # of times repeated before completion
    private int SetCheckListCount()
    {
        Console.Write("Set # of times for goal completion : ");
        int _checklistCount = int.Parse(Console.ReadLine());
        return _checklistCount;
    }
    
    // Function to split the goal string into parts, first to read the goal-type and name 
    // then to split to read description, point values, completion, ect.
    private List<Goal> ConvertToGoalObjects(string[] param)
    {
        _score = int.Parse(param[0]);
        char colon = ':';
        char pipe = '|';
        int start = 1;
        int end = param.Length;
        param = param.Where((value, index) => index >= start && index <= end).ToArray();

        List<Goal> initialGoal = new();

        foreach (string list in param)
        {
            string[] parts = list.Split(colon);
            string goalName = parts[0].Trim();
            string[] contents = parts[1].Split(pipe);

            if (goalName == "Simple Goal")
            {
                SimpleGoal simpleGoal = new(name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), goal: goalName);
                bool isComplete = bool.Parse(contents[3]);
                if (isComplete) 
                {
                    simpleGoal.SetCheckBox();
                    simpleGoal.SetIsCompleteToTrue();
                }
                initialGoal.Add(simpleGoal);
            }
            if (goalName == "Eternal Goals")
            {
                EternalGoal eternalGoal = new (name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), goal: goalName);
                initialGoal.Add(eternalGoal);
            }
            if (goalName == "Checklist Goals")
            {
                CheckListGoal checkListGoal = new(name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), goal: goalName, bonus: int.Parse(contents[3].Trim()), target: int.Parse(contents[4].Trim()));
                bool isComplete = bool.Parse(contents[6]);
                if (isComplete)
                {
                    checkListGoal.SetCheckBox();
                    checkListGoal.SetIsCompleteToTrue();
                } 
                checkListGoal.AddSaveAmountCompleted(int.Parse(contents[5].Trim()));
                initialGoal.Add(checkListGoal);
            }
        }
        Console.WriteLine("\nYour file was successfully loaded");
        return initialGoal;
    }
}