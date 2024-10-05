using System;

// Adding a namespace because... it helps provide added encapsulation of the code within
namespace ScriptureMemorization
{

    // Define the Scripture class
    public class Scripture
    {
        // Variables
        public List<Scripture> _scripture = new List<Scripture>();
        private string _fileName = "VersesFile.txt";
        private string _text;
        public int _index;
        public string _scriptureText;


        // Scripture class method for loading and reading scripture reference from file
        public void ReadScriptures()
        {
            // Create list where all string data from file will be stored, ignore empty spaces in file.
            List<string> verses = File.ReadAllLines(_fileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

            // Loop through each string in the list called verses
            foreach (string verse in verses)
            {
                // Split string into separate parts whereever a ';' is found, save each part in 'entries' array
                string[] entries = verse.Split(";");

                // New instance of Scripture list called entry
                Scripture entry = new Scripture();

                // Set '_text' in entry instance above = to item at index 4 in entries array, which would be the scripture text
                entry._text = entries[4];

                // Save that scripture text to the list called _scripture
                _scripture.Add(entry);
            }
        }

        // Function to get and return the randomly selected scripture verse text
        public string RandomVerse()
        {
            // Call the GetRandomIndex function to select a number between 0 and the length of the list of scriptures
            _index = GetRandomIndex();
            // Use the returned number from the GetRandomIndex function to return the scripture text
            // in the list of scriptures, found at the returned index vaule
            return _scriptureText = _scripture[_index]._text;
        }


        // Function to randomly select a scripture from a list of scriptures
        public int GetRandomIndex()
        {
            // Call random generator function
            var random = new Random();
            // Assign variable _index to a randomly selected number from 0 to the number of
            // scriptures in the list named _scripturs
            _index = random.Next(_scripture.Count);
            // Return that randomly selected number
            return _index;
        }

    }

}