using System;

namespace ScriptureMemorization
{
// A code template for the category of things known as 
    public class Reference
    {
        // Variables
        public List<Reference> _reference = new List<Reference>();
        private string _fileName = "VersesFile.txt";
        private string _book;
        private int _chapter;
        private int _verseStart;
        private int _verseEnd;



        // Methods
        public void ReadReferences()
        {
            List<string> Verses = File.ReadAllLines(_fileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

            foreach (string verse in Verses)
            {
                string[] entries = verse.Split(";");

                Reference entry = new Reference();

                entry._book = entries[0];
                entry._chapter = int.Parse(entries[1]);
                entry._verseStart = int.Parse(entries[2]);
                entry._verseEnd = int.Parse(entries[3]);

                _reference.Add(entry);
            }
        }



        public string GetReference(Scripture scripture)
        {
            var index = scripture._index;

            var refIndex = _reference[index];
            string verseRef;
            if (refIndex._verseEnd.Equals(0))
            {
                return verseRef = ($"{refIndex._book} {refIndex._chapter}:{refIndex._verseStart}");
                
            }
            else
            {
                return verseRef = $"{refIndex._book} {refIndex._chapter}:{refIndex._verseStart}-{refIndex._verseEnd}";
            }
        }



        public void DisplayReference()
        {
            foreach (Reference item in _reference)
            {
                
                if (item._verseEnd.Equals(0))
                {
                    item.OneVerseReference();
                }
                else
                {
                    item.TwoVerseReference();
                }
            }
        }



        public void OneVerseReference()
        {
            Console.WriteLine($"{_book} {_chapter}:{_verseStart}");
        }



        public void TwoVerseReference()
        {
            Console.WriteLine($"{_book} {_chapter}:{_verseStart}-{_verseEnd}");
        }


    }


}