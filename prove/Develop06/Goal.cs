// Base class - Attributes and default method
public  abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _setPoints;
    protected int _currentPoint = 0;
    protected string _checkBox = "[ ]";

    public Goal (string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _setPoints = points;
    }

    // RecordEvent method with no default, each inheritance will have to provide their own functions
    public abstract void RecordEvent();

    // IsComplete method with no default, each inheritance will have to provide their own functions
    public abstract bool IsComplete();

    // SetIsCompleteToTrue method with no default, each inheritance will have to provide their own functions
    public virtual void SetIsCompleteToTrue()
    {
        
    }

    // Default function for string with checkbox, name and desc of goal
    public virtual string GetDetailsString()
    {
        return $"{GetCheckBox()} {_shortName} - {_description}";
    }

    // GetStringRepresentation method with no default, each inheritance will have to provide their own functions
    public abstract string GetStringRepresentation();

    // Default function to return current points
    public int GetCurrentPoint()
    {
        return _currentPoint;
    }

    // Default function to return string with name of goal
    public string GetGoalName()
    {
        return _shortName;
    }

    // Default function to return number of points set by user for goal
    public int GetSetPoint()
    {
        return _setPoints;
    }

    // Default function to add completion points to accumalated points
    public void AddSetPointToCurrentPoint()
    {
        _currentPoint += _setPoints;
    }

    // Default function to set string with filled checkbox
    public void SetCheckBox()
    {
        string newCheckBox = _checkBox.Replace(_checkBox, "[X]");
        _checkBox = newCheckBox;
    }

    // Default function to return string with the checkbox
    public string GetCheckBox()
    {
        return _checkBox;
    }
}