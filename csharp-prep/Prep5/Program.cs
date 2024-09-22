using System;

class Program
{

    // Function for displaying Welcome Message
    static void DisplayWelcome() // Static = standalone function, Void = nothing to be returned
    {
        Console.Clear(); // Clear terminal screen
        Console.WriteLine("Welcome to the Program! "); // Print string to terminal screen
        Console.WriteLine(); // Print a blank line for spacing
    }


    // Function for getting the User's name
    static string PromptUserName() // Static = standalone function, String = a string value is expected to be returned
    {
        Console.Write("Please enter your full name: "); // Print string to terminal screen
        string UserName = Console.ReadLine(); // Read an input from the user. string = string data expected, save in var UserName
        return UserName; // Return user input string
    }


    // Function for getting the user's favorite number
    static int PromptUserNumber() // Static = standalone function, Int = a number value is expected to be returned
    {
        Console.Write("Enter your favorite number : "); // Print string to terminal screen
        string GetNum  = Console.ReadLine(); // Read an input from the user. string = string data expected, save in var GetNum
        int UserNum    = int.Parse(GetNum); // Convert the input from user into an integer. Note: a number should have been entered but must be converted
        
        return UserNum; // Return user's input which was converted
    }


    // Function that squares the number given by the user
    static int SquareNumber(int UserNum) // Static = standalone function, Int = a number value is expected to be returned, UserNum is being passed into the function
    {
        int SqrNum = (UserNum * UserNum);// Declare var SqrNum as an integer, multiply the number in UserNum by itself and save result in var SqrNum
        return SqrNum; // Return the squared number
    }


    // Function that displays the results from the previous functions
    static void DisplayResult(string UserName, int SqrNum) // Static = standalone function, Void = no data returned, string data and a number being passed to function
    {
        Console.WriteLine(); // Print a blank line for spacing
        Console.WriteLine($"{UserName}, the square of your number is {SqrNum}"); // Print string, with embedded vars to terminal screen
        Console.WriteLine(); // Print a blank line for spacing
    }


    // Main function
    static void Main(string[] args) // Static = standalone function, Int = a number value is expected to be returned
            {
                char input;
                
                do //Do these, then drop to the while statement
                {
                    DisplayWelcome(); // Call this function
                    string Name   = PromptUserName(); // Call this function, a string is expected to be returned, save it in var Name
                    int Num       = PromptUserNumber(); // Call this function, an integer is expected to be returned, save it in var Num
                    int NumSqr    = SquareNumber(Num); // Call this function, an integer is expected to be returned, save it in var NumSqr
                    DisplayResult(Name, NumSqr); // Call this function

                    Console.Write("Would you like to play again? [Y / N]"); //Once the above function calls are complete as user to quit or run again
                    input = Convert.ToChar(Console.ReadLine()); // Input from user, but just interested in a single character Y or N
                }

                while (input == 'y');

                // If unser inputs N, perform these next steps
                Console.Clear(); // Clear terminal screen
                Console.WriteLine(); // Print a blank line for spacing
                Console.WriteLine("Thanks for playing... Bye!"); // Print thank you for playing to user
                Thread.Sleep(1500); // Wait 1.5 seconds
                Console.Clear(); // Clear screen

            }
}