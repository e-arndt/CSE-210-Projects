// Creativity: Create a clean easy to read menu system that has individual menus
// for each available function. Most menu functions are reusable by each type of goal.

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