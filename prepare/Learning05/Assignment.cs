using System;

namespace homework_assignments
{

    public class Assignment
{
    protected string _studentName;
    protected string _topic;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    public void SetStudentName(string name)
    {
        _studentName = name;
        
    }


    public string GetStudentName()
    {
        return _studentName;
    }


    public void SetTopic(string topic)
    {
        _topic = topic;
    }


    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummery()
    {
        return $"Name    : {_studentName} \nTopic   : {_topic}";
    }
}







}