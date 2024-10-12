using System;


namespace YouTubeVideos
{

    // Define the Display class
    public class Display
    {
        // Variables
        public string _words = "";
        public string _ref = "";
        public string[] _comment;
        
        


        public void GetCommentText(Comment comment)
        {
            // Set variable to equal the selected comment
            var _words = comment._commentText;
            // Set variable to equal the separated words
            _comment = _words.Split(";");
            
            
        }



        // Function that shows banner and interates through all videos and comments
        public void Show(string videoRef)
        {
            
            _ref = videoRef;
            // Clear screen, display banner and instructions to user
            Console.Clear();
            Console.WriteLine("========== YouTube Video Program ==========");
            Console.WriteLine();
            

            // Display video name, author and length
            Console.WriteLine($"{_ref}");
            Console.WriteLine();
            
            // Loop to iterate through and split comments
            foreach (string result in _comment)

            {
                string[] comments = result.Split("|");
                int _commentCount = comments.Length;
                Console.WriteLine($"Total of {_commentCount} comments for this video:");
                for (var i = 0; i < comments.Length; i++)
                {
                    var str = comments[i];
                    Console.WriteLine($"{str} ");
                }
                
            }
        }


        // Function to read single key press from user
        public void GetReadKey()
        {
            Console.WriteLine();
            Console.Write("Press Q to quit Enter or Spacebar for next video ");
            
            // Read key press from user and store in 'input'
            var input = Console.ReadKey();
            // If the input is the spacebar or enter key do this
            if (input.Key == ConsoleKey.Spacebar || input.Key == ConsoleKey.Enter)
            {
               return;
            }
            // If the input is the Q key do this
            else if (input.Key == ConsoleKey.Q)
            {
                // Call the function that ends the program
                Program.EndProgram();
            }
        }

    }

}