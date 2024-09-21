using System;
using System.Collections.Generic;


namespace Lists
{

        internal class Program
        {
            static void Main(string[] args)
            {
        List<string> words = new List<string>();

        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

        Console.Clear();
        Console.Write("Word count of the lists is: ");
        Console.WriteLine(words.Count);
        Console.WriteLine();

        Console.WriteLine("Words in the lists are: ");
        
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine();
        Console.WriteLine();

            }
        }

}