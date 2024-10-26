// Child class of Goal base class for eternal goals - Attributes and default method
public class EternalGoal : Goal
{
    private string _typeOfGoal;

    public EternalGoal(string name, string description, int points, string goal) : base(name, description, points)
    {
        _typeOfGoal = goal;
    }

    // Child override of the base method called RecordEvent adds points, if goal completed
    // No checkbox is set for eternal goals
    public override void RecordEvent()
    {
        if (IsComplete())
        {
            AddSetPointToCurrentPoint();
        }
    }

    // Child override of the base method called IsComplete that returns a false condition
    // because eternal goals are never completed
    public override bool IsComplete()
    {
         return false;
    }

    // Child override of the base method called GetStringRepresentation that returns a string of 
    // the goal type, name, desc and point values of the goal
    public override string GetStringRepresentation()
    {
        return $"{_typeOfGoal}: {_shortName} | {_description} | {_setPoints}";
    }


}