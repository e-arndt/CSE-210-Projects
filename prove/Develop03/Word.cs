using System;

// Adding a namespace because... it helps provide added encapsulation of the code within
namespace ScriptureMemorization
{

    // Define the Word class
    public class Word
    {
        // Variables
        public string _words = "";
        public string _ref = "";
        public string[] _result;
        public List<int> _hidden;



        // Word Class Method for splitting the verse text into separate parts / words
        public void GetRenderedText(Scripture scripture)
        {
            // Set variable to equal the randomly selected scripture text
            var _words = scripture._scriptureText;
            // Set variable to equal the separated words
            _result = _words.Split(" ");
            // Create a new list of integers
            _hidden = new List<int>();
        }



        // Function that shows instrutions, scripture reference / text, hidden text and user input
        public void Show(string verseRef)
        {
            // Set local variable from reference passed into function
            _ref = verseRef;
            // Clear screen, display banner and instructions to user
            Console.Clear();
            Console.WriteLine("========== Scripture Memorizer Program ==========");
            Console.WriteLine();
            Console.WriteLine("       Use Enter or Spacebar to hide words       ");
            Console.WriteLine("                 Press Q to Quit                 ");
            Console.WriteLine();

            // Display scripture reference
            Console.WriteLine($"{_ref}");

            // Loop to iterate through all word indexes, up to the last one which is equal to the length of _result
            // which contains every word of the verse and its associated index number
            for (var i = 0; i < _result.Length; i++)
            {
                // Variable the holds each word within -result at index [i]
                var str = _result[i];
                // Variable that holds the length or 'size' of the word in the 'str' variable (example lord = 4)
                int len = str.Length;
                //String that holds the replacement characters equal in length to the word being replaced
                string dashedLine = new String('_', len);
                // If the _hidden list contains the word at index (i), print the dashedline replacement instead
                if (_hidden.Contains(i))
                {
                    Console.Write($"{dashedLine} ");
                }
                // If the word is not yet in the hidden list, print the word
                else
                {
                    Console.Write($"{str} ");
                }
            }
        }


        // Function to read single key press from user
        public void GetReadKey()
        {
            // Read key press from user and store in 'input'
            var input = Console.ReadKey();
            // If the input is the spacebar or enter key do this
            if (input.Key == ConsoleKey.Spacebar || input.Key == ConsoleKey.Enter)
            {
                // Call function to get a new hidden word
                GetNewHiddenWord();
            }
            // If the input is the Q key do this
            else if (input.Key == ConsoleKey.Q)
            {
                // Call the function that ends the program
                Program.EndProgram();
            }
        }


        // Function to select new hidden words
        public void GetNewHiddenWord()
        {
            // Call random generator function
            var random = new Random();
            // Set index1 and index2 with random # from 0 to the length of the scripture verse
            var index1 = random.Next(_result.Length);
            var index2 = random.Next(_result.Length);
            // If the list called '_hidden' already contains one or both of the randomly selected numbers,
            // run the function again and generate two more numbers
            if (_hidden.Contains(index1) || _hidden.Contains(index2))
            {
                // Call the function again
                GetNewHiddenWord();
            }
            // If the randomly selected numbers are not already in the _hidden list then do this
            else
            {
                // Add those new numbers to the _hidden list
                _hidden.Add(index1);
                _hidden.Add(index2);

            }

        }

    }

}