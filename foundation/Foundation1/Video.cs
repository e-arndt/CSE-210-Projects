using System;


namespace YouTubeVideos
{

// Define the Video class
    public class Video
    {
        // Variables
        public List<Video> _video = new List<Video>();
        private string _fileName = "VideosFile.txt";
        private string _title;
        private string _author;
        private int _length;
        



        // Video Class Method for loading and reading video reference from file
        public void ReadVideos()
        {
            // Create list where all string data from file will be stored, ignore empty spaces in file.
            List<string> Videos = File.ReadAllLines(_fileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

            // Loop through each string in the list called videos
            foreach (string video in Videos)
            {
                // Split string into separate parts whereever a ';' is found, save each part in 'entries' array
                string[] entries = video.Split(";");

                // New instance of Video list called entry
                Video entry = new Video();

                // Set class variables to the proper part in the entry list, convert numbers to int
                entry._title = entries[0];
                entry._author = entries[1];
                entry._length = int.Parse(entries[2]);
                

                // Save the video data to _video list
                _video.Add(entry);
            }
        }


        // Function for getting the video data
        public string GetVideo(Comment comment)
        {
            
            
            var index = comment._index;
            
            var refIndex = _video[index];
            
            string videoRef;
        
            // Set and return videoRef with just the title, author and length
            return videoRef = ($"TITLE:  {refIndex._title} \nAUTHOR: {refIndex._author}: \nLENGTH: {refIndex._length} Secs");
                
            
        }


    }


}