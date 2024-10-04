using System;
using System.IO;


// Adding a namespace because... it does help provided added encapsulation of the code within
namespace ScriptureMemorization
{

    class Program
    {
        // The Main function
        static void Main(string[] args)
        {
            // Clear screen, 
            Console.Clear();
            Reference reference = new Reference();
            reference.ReadReferences();

            Scripture scripture = new Scripture();
            scripture.ReadScriptures();
            
            Word word = new Word();


            while (true)
            {
                string verseText = scripture.RandomVerse();
                string verseRef  = reference.GetReference(scripture);
                word.GetRenderedText(scripture);
                word.GetRenderedRef(scripture);

                while (word._hidden.Count < word._result.Length)
                    {
                        word.Show(verseRef);
                        word.GetReadKey();
                    }
                    word.Show(verseRef);
                    break;
                
            }
            
            EndProgram();

        }

        

        // Function that gracefully quits the program
        public static void EndProgram()
        {
            // Clear screen, display thank you msg, wait 2.5 sec, clear screen, space 2 lines
            Console.Clear();
            Console.WriteLine("Quit the Scripture Memorizer Program");
            Thread.Sleep(2050);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            Environment.Exit(0);
        }

    }

}