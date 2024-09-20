using System;
using System.Threading;



namespace Guess
{

        internal class Program
        {
            private static void NumberGuess()
            {
                Random rndNum = new Random();
                int MagicNumber = rndNum.Next(1, 250);

                int NumberGuess = 0;
                int GuessCount = 0;

                Console.Clear();
                Console.WriteLine("Guess the Magic Number! [1 - 250]");
                Console.WriteLine();
                Console.Write("Press 'Enter' when ready ");
                Console.ReadLine();
                Console.Clear();
                
                while (NumberGuess != MagicNumber)
                {
                    GuessCount++;
                    Console.Write("What is your guess? ");
                    string MyGuess = Console.ReadLine();
                    NumberGuess = int.Parse(MyGuess);

                    if (NumberGuess > MagicNumber)
                        {
                            Console.Write("Lower");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                            else if (NumberGuess < MagicNumber)
                        {
                            Console.Write("Higher");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                            else
                        {
                            Console.Clear();
                            Console.WriteLine($"You guessed the Magic Number {MagicNumber} in {GuessCount} tries!");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                }
            }

            static void Main(string[] args)
            {
                char input;
                do
                {
                    NumberGuess();

                    Console.Write("Would you like to play again? [Y / N]");
                    input = Convert.ToChar(Console.ReadLine());
                }

                while (input == 'y');

                Console.WriteLine();
                Console.WriteLine("Thanks for playing... Bye!");
                Thread.Sleep(1250);
                Console.Clear();
            }
        }
}
                  
        






        