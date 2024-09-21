using System;
using System.Collections.Generic;


namespace Lists
{

        internal class Program
        {
             private static void NumberList()
            {
                List<int> numbers = new List<int>();

                int UserNum   = -100;
                int NumSum    = 0;
                double NumAvg = 0;
                int NumMax    = 0;

                Console.Clear();
                Console.WriteLine("Create a list of numbers, type 0 when finished [# / 0] ");
                

                while (UserNum != 0)
                {
                    Console.Write("Enter number: ");
                    string MyNum = Console.ReadLine();
                    UserNum = int.Parse(MyNum);
                    numbers.Add(UserNum);
                }

                Console.Clear();

                foreach (int num in numbers)
                {
                    NumSum = (NumSum + num);

                }

                NumAvg = numbers.Average();
                Math.Round(NumAvg, 2);
                
                NumMax = numbers.Max();

                Console.WriteLine($"The total sum is     : {NumSum} ");
                Console.WriteLine($"The average is       : {NumAvg} ");
                Console.WriteLine($"The largest number is: {NumMax} ");
                Console.WriteLine();

            }



            static void Main(string[] args)
            {
                char input;
                
                do
                {
                    NumberList();

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