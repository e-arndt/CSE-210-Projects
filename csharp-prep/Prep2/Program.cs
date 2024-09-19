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
            Console.Clear();

            if (UserGrade >= 90)
            {
                Console.Write("Your Letter Grade is A");
            }

            else if (UserGrade >= 80)
            {
                Console.Write("Your Letter Grade is B");
            }

            else if (UserGrade >= 70)
            {
                Console.Write("Your Letter Grade is C");
            }

            else if (UserGrade >= 60)
            {
                Console.Write("Your Letter Grade is D");
            }
            
            else if (UserGrade < 60)
            {
                Console.Write("Your Letter Grade is F");
            }

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