// Creativity: Add banner to identify the program
// Format screen output for better readability and look
// Add option to allow user to use the enter key or spacebar to cycle through the hide function
// Add a text file and function that loads multiple scriptures from the text file
// Add function to randomly select the scripture shown to the user
// Add a function that displays a message to user when they quit or finish using the program

using System;
using System.IO;


// Adding a namespace because... it does help provided added encapsulation of the code within
namespace ScriptureMemorization
{
    // Define the Program class
    class Program
    {
        // The Main function
        static void Main(string[] args)
        {
            // Clear screen, 
            Console.Clear();
            // New instance of list of Reference objects
            Reference reference = new Reference();
            // Perform the Read References from file function
            reference.ReadReferences();
            // New instance of list of Scripture objects
            Scripture scripture = new Scripture();
            // Perform the Read Scriptures from file function
            scripture.ReadScriptures();
            
            // New instance of list of Word objects
            Word word = new Word();

            // Loop that process scripture, reference, user input, hidden words until all are hiden or user quits
            while (true)
            {
                // Get random verse text from RandomVerse function
                string verseText = scripture.RandomVerse();
                // Get random reference text from RandomReference function
                string verseRef  = reference.GetReference(scripture);
                // Call function to get the text of the randomly selected verse
                word.GetRenderedText(scripture);

                // Loop that calls the processes for instructions, reference, verse, hidding of words and
                // user input while the count of hidden words is less than the total of words in verse
                while (word._hidden.Count < word._result.Length)
                    {
                        word.Show(verseRef);
                        word.GetReadKey();
                    }
                    word.Show(verseRef);
                    break;
                
            }
            // Call function to end the program
            EndProgram();

        }

        

        // Function that gracefully quits the program
        public static void EndProgram()
        {
            // Clear screen, display quit msg, wait 3 secs, clear screen, space 2 lines
            Console.Clear();
            Console.WriteLine("Thanks for using the Scripture Memorizer Program");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            // Call for instant exit rather than go back to Main() in Program.cs
            Environment.Exit(0);
        }

    }

}