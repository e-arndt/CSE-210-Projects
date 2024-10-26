// Child class of Goal base class for simple goals - Attributes and default method
public class SimpleGoal : Goal
{
    private string _typeOfGoal;
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points, string goal) : base(name, description, points)
    {
        _typeOfGoal = goal;
    }

    // Child override of the base method called GetDetailsString sets completed checkbox
    // and adds points if completed
    public override void RecordEvent()
    {
        if (IsComplete())
        {
            AddSetPointToCurrentPoint();
            SetCheckBox();
        }
    }

    // Child override of the base method called IsComplete that returns the current condition
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Child override of the base method called IsComplete that returns a true condition
    public override void SetIsCompleteToTrue()
    {
        _isComplete = true;
    }

    // Child override of the base method called GetStringRepresentation that returns a string of 
    // the goal type, name, desc, point values and completion of the goal
    public override string GetStringRepresentation()
    {
        return $"{_typeOfGoal}: {_shortName} | {_description} | {_setPoints} | {IsComplete()}";
    }
}