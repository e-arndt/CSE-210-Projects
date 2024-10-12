
using System;
using System.IO;



namespace YouTubeVideos
{
    // Define the Program class
    class Program
    {
        // The Main function
        static void Main(string[] args)
        {
            // Clear screen, 
            Console.Clear();
            // New instance of list of Video objects
            Video video = new Video();
            // Perform the Read Videos from file function
            video.ReadVideos();
            // New instance of list of video objects
            Comment comment = new Comment();
            // Perform the Read comments from file function
            comment.ReadComments();
            
            // New instance of list of Display objects
            Display display = new Display();

           
            while (comment._index < comment._comment.Count -1)
            {
                // Get comment text from function
                string videoText = comment.GetComments();
                // Get video reference text from function
                string videoRef  = video.GetVideo(comment);
                // Call function to parsed comments
                display.GetCommentText(comment);

                display.Show(videoRef);
                
                display.GetReadKey();
                
                
            }
            // Call function to end the program
            EndProgram();

        }

        

        // Function that gracefully quits the program
        public static void EndProgram()
        {
            // Clear screen, display quit msg, wait 3 secs, clear screen, space 2 lines
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========== End Program ==========");
            // Thread.Sleep(3000);
            // Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            // Call for instant exit rather than go back to Main() in Program.cs
            Environment.Exit(0);
        }

    }

}