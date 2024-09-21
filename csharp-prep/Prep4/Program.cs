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
                int NumCount  = 0;
                

                Console.Clear();
                Console.WriteLine("Create a list of numbers, type 0 when finished [# / 0] ");
                
                while (UserNum != 0)
                {
                    Console.Write("Enter number: ");
                    string MyNum = Console.ReadLine();
                    UserNum = int.Parse(MyNum);

                    if (UserNum != 0)
                    {
                        numbers.Add(UserNum);
                    }


                    else
                    {
                        Console.Clear();

                        foreach (int num in numbers)
                        {
                            NumSum = (NumSum + num);

                        }

                        NumAvg = numbers.Average();
                        double Avg = Math.Round(NumAvg, 2);
                        
                        NumMax = numbers.Max();

                        NumCount = numbers.Count();

                        numbers.Sort();

                        Console.WriteLine($"The total sum is     : {NumSum} ");
                        Console.WriteLine($"The average is       : {Avg} ");
                        Console.WriteLine($"The largest number is: {NumMax} ");
                        Console.WriteLine($"The count of numbers : {NumCount} ");
                        Console.WriteLine();
                        Console.WriteLine($"The sorted list is   : ");

                        foreach (int number in numbers)
                        {
                            Console.WriteLine(number);
                        }
                        Console.WriteLine();
                    }
                }
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

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Thanks for playing... Bye!");
                Thread.Sleep(1500);
                Console.Clear();

            }
        }

}