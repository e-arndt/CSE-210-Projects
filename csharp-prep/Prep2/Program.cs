using System;

namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.Write("What is your grade percent? ");
            string MyGrade = Console.ReadLine();
            int UserGrade = int.Parse(MyGrade);
            string letter = "";
            Console.Clear();

                if (UserGrade >= 90)
                {
                    letter = "A";
                }

                else if (UserGrade >= 80)
                {
                    letter = "B";
                }

                else if (UserGrade >= 70)
                {
                    letter = "C";
                }

                else if (UserGrade >= 60)
                {
                    letter = "D";
                }
                
                else if (UserGrade < 60)
                {
                    letter = "F";
                }

        Console.WriteLine($"Your Letter Grade is {letter}.");

                if (UserGrade >= 70)
                {
                    Console.WriteLine();
                    Console.Write("You passed the class, Congratulations!");
                }

                else if (UserGrade < 70)
                {
                    Console.WriteLine();
                    Console.WriteLine("You did not pass the class.");
                    Console.WriteLine("Try again, ask a tutor for help.");
                }

        Console.WriteLine();
        Console.WriteLine();
        }
    }
}