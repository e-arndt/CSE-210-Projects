// Creativity: Added more Reflection prompts and Listing questions
// Prompts and questions are read from text files
// Build a list of used prompts, randomly select from the list of unused prompts
// Create a clean easy to read menu and activity displays
// Add an end program function to gracefully exit the program

using System;

// A namespace for better code organization, reduction of conflicts and added encapsulation
namespace mindfulness
{

    class Program
    {
        // Main function of Program Class
        static void Main(string[] args)
        {
            // Initialize new intances of each activity
            Activity asset = new Activity();
            Breathing breathing = new Breathing();
            Reflection reflection = new Reflection();
            Listing listing = new Listing();
            
            
            // Initialize new variable as an integer
            int userChoice;
            // Do this code, then check the while condition
            do
            {
                // Print menu to terminal screen
                Console.Clear();
                Console.Write("   Mindfulness Activities\n");
                Console.WriteLine("===========================\n");
                Console.WriteLine("1. Start Breathing Activity");
                Console.WriteLine("2. Start Refelecting Activity");
                Console.WriteLine("3. Start Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Select a menu option: ");
            
                // Menu option input from user, convert from string to integer
                userChoice = int.Parse(Console.ReadLine()); 
                Console.WriteLine("");

                // If option 1, Call the breathing activity
                if (userChoice == 1)
                {
                    breathing.Run();
                    Console.WriteLine("");
                }
                // If option 2, Call the reflection activity
                else if(userChoice == 2)
                {
                    reflection.Run();
                }
                // If option 3, Call the listing activity
                else if (userChoice == 3)
                {
                    listing.Run();
                }
                // If option 4, Call the end of program function
                else if (userChoice == 4)
                {
                    EndProgram();
                }
                //Else assume an invalid entry was made, display error msg
                else
                {
                    Console.WriteLine("Invalid Entry - [1-4]");
                    Thread.Sleep(2700);
                }

            } while (userChoice != 4);


        }
        
        static void EndProgram()
        {
            // Clear screen, display thank you msg, wait 2.5 sec, clear screen, space 2 lines
            Console.Clear();
            Console.Write("Thank you for using the Mindfulness Program ");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
        }
    }

}