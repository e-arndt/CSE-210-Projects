using System;

// Adding a namespace because... it helps provide added encapsulation of the code within
namespace ScriptureMemorization
{

// Define the Scripture class
    public class Reference
    {
        // Variables
        public List<Reference> _reference = new List<Reference>();
        private string _fileName = "VersesFile.txt";
        private string _book;
        private int _chapter;
        private int _verseStart;
        private int _verseEnd;



        // Reference Class Method for loading and reading scripture reference from file
        public void ReadReferences()
        {
            // Create list where all string data from file will be stored, ignore empty spaces in file.
            List<string> Verses = File.ReadAllLines(_fileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

            // Loop through each string in the list called verses
            foreach (string verse in Verses)
            {
                // Split string into separate parts whereever a ';' is found, save each part in 'entries' array
                string[] entries = verse.Split(";");

                // New instance of Reference list called entry
                Reference entry = new Reference();

                // Set class variables to the proper part in the entry list, convert numbers to int
                entry._book = entries[0];
                entry._chapter = int.Parse(entries[1]);
                entry._verseStart = int.Parse(entries[2]);
                entry._verseEnd = int.Parse(entries[3]);

                // Save the reference data to _reference list
                _reference.Add(entry);
            }
        }


        // Function for getting the reference of the randonly selected scripture verse
        public string GetReference(Scripture scripture)
        {
            // Set local variable 'index' to = the index number of the randomly selected verse from the data file
            var index = scripture._index;
            // Set local variable 'refIndex' to = the reference info of the scripture at that index in data file
            // ex. Book = Moroni, Chapter = 10, verseStart = 5....
            var refIndex = _reference[index];
            // Initialize string variable called 'verseRef'
            string verseRef;
            // If there is only one verse with this scripture reference (verseEnd = 0)
            if (refIndex._verseEnd.Equals(0))
            {
                // Set and return verseRef with just the Book name, chapter # and the single verse # (Moroni 10:5)
                return verseRef = ($"{refIndex._book} {refIndex._chapter}:{refIndex._verseStart}");
                
            }
            // If verseEnd has a value other than 0, do this instead
            else
            {
                // Set and return verseRef with the Book name, chapter # and the verse range (Moroni 10:5-7)
                return verseRef = $"{refIndex._book} {refIndex._chapter}:{refIndex._verseStart}-{refIndex._verseEnd}";
            }
        }


    }


}