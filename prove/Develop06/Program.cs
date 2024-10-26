using System;
using System.IO;

// Entry point of program
class Program
{
    static void Main(string[] args)
    {
        // Call instance of goal manager and the Main Menu
        GoalManager goalManager = new GoalManager();
        goalManager.MainMenu();
    }
}