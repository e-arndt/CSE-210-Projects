using System;

namespace Grades
{
        internal class Program
        {
            static void Main(string[] args)
            {
                int MagicNumber = 1;
                int NumberGuess = 0;
                Console.Clear();
                Console.Write("What is the Magic Number? ");
                MagicNumber = int.Parse(Console.ReadLine());
                Console.Clear();

                while (NumberGuess != MagicNumber)
                {
                    Console.Write("What is your guess? ");
                    string MyGuess = Console.ReadLine();
                    NumberGuess = int.Parse(MyGuess);

                    if (NumberGuess > MagicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                        else if (NumberGuess < MagicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                        else
                    {
                        Console.Clear();
                        Console.WriteLine($"You guessed {MagicNumber} which is the Magic Number!");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }    
        }
    }
}