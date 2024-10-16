using System;

namespace homework_assignments
{

    public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;


    public MathAssignment(string name, string topic, string section, string problems) : base (name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }


    public void SetTextbookSection(string section)
    {
        _textbookSection = section;
    }


    public string GetTectbookSection()
    {
        return _textbookSection;
    }


    public void SetProblems(string problems)
    {
        _problems = problems;
    }


    public string GetProblems()
    {
        return _problems;
    }

    public string GetHomeworkList()
    {
        return $"Section : {_textbookSection} \nProblems: {_problems}";
    }
}



}