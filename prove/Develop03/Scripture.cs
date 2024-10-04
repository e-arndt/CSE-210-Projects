using System;

namespace ScriptureMemorization
{

    public class Scripture
    {
        // Variables
        public List<Scripture> _scripture = new List<Scripture>();
        private string _fileName = "VersesFile.txt";
        private string _text;
        public int _index;
        public string _scriptureText;


        // Methods
        public void ReadScriptures()
        {
            List<string> verses = File.ReadAllLines(_fileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

            foreach (string verse in verses)
            {
                string[] entries = verse.Split(";");

                Scripture entry = new Scripture();

                entry._text = entries[4];

                _scripture.Add(entry);
            }
        }



        public void DisplayVerse()
        {
            foreach (Scripture item in _scripture)
            {
                item.ShowVerse();
            }
        }



        public void ShowVerse()
        {
            Console.WriteLine($"{_text}");
        }



        public string RandomVerse()
        {
            _index = GetRandomIndex();
        return _scriptureText = _scripture[_index]._text;
        }



        public int GetRandomIndex()
        {
            var random = new Random();
            _index = random.Next(_scripture.Count);
            return _index;
        }

    }

}