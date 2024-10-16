using System;

namespace homework_assignments
{
class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Bubba Gump", "Business Administration");
        //assignment1.SetStudentName("Bubba Gump");
        //assignment1.SetTopic("Business Administration");
        //assignment1.SetTextbookSection("11.4");
        //assignment1.SetProblems("10-15, 17, 20");

        Console.Clear();
        Console.WriteLine(assignment1.GetSummery());
        Console.WriteLine();



        MathAssignment mathAssignment1 = new MathAssignment("Olivia Bell", "Vector Math", "11.4", "10-15, 17, 20-24");
        //assignment1.SetStudentName("Bubba Gump");
        //assignment1.SetTopic("Business Administration");
        //assignment1.SetTextbookSection("11.4");
        //assignment1.SetProblems("10-15, 17, 20");

        Console.WriteLine(mathAssignment1.GetSummery());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        Console.WriteLine();



        WritingAssignment writingAssignment1 = new WritingAssignment("Kristen Dunne", "English Composition", "Student Athletes");
        

        Console.WriteLine(writingAssignment1.GetSummery());
        Console.WriteLine(writingAssignment1.GetWritingInfo());
        Console.WriteLine();
    }
}


}