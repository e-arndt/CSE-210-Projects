using System;


namespace YouTubeVideos
{

    // Define the Comment class
    public class Comment
    {
        // Variables
        public List<Comment> _comment = new List<Comment>();
        private string _fileName = "VideosFile.txt";
        private string _text;
        public int _index = -1;
        public string _commentText;
        public List<string> _videoComments;


        // Comment class method for loading and reading video comments from file
        public void ReadComments()
        {
            
            // Create list where all string data from file will be stored, ignore empty spaces in file.
            List<string> videos = File.ReadAllLines(_fileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

            _videoComments = new List<string>();
            // Loop through each string in the list called videos
            foreach (string video in videos)
            {
                // Split string into separate parts whereever a ';' is found, save each part in 'entries' array
                string[] entries = video.Split(";");

                // New instance of Comment list called entry
                Comment entry = new Comment();

                // Set '_text' in entry instance above = to item at index 3 in entries array
                entry._text = entries[3];

                // Save that comment text to the list called _comment
                _comment.Add(entry);

                
                for (var i = 3; i < entries.Length; i++)
                {
                
                    _videoComments.Add(entries[i]);
                }
            }
        }

        // Function to get and return the selected video comments
        public string GetComments()
        {
            _index = _index +1;

            
            return _commentText = _videoComments[_index];
             
        }


    }

}