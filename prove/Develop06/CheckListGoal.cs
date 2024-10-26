// Child class of Goal base class for checklist goals - Attributes and default method
public class CheckListGoal : Goal
{
    private string _typeOfGoal;
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    private bool _isComplete = false;

    public CheckListGoal(string name, string description, int points, string goal, int target, int bonus) : base(name, description, points)
    {
        _typeOfGoal = goal;
        _target = target;
        _bonus = bonus;
    }

    // Child override of the base method called RecordEvent that records when a goal is fully or partly completed
    public override void RecordEvent()
    {
        
        if (IsComplete() && GetAmountCompleted() == (_target -1))
        {
            AddSetPointToCurrentPoint();
            AddBonusPointToCurrentPoint();
            SetAmountCompleted();
            SetCheckBox();
            
        }
        else
        {
            AddSetPointToCurrentPoint();
            SetAmountCompleted();
            _isComplete = false;
        }
    }

    // Child override of the base method called IsComplete that returns the current condition
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Child override of the base method called GetDetailsString that returns a string of the checkbox, name, desc and progress of the goal
    public override string GetDetailsString()
    {
        return $"{GetCheckBox()} {_shortName} - {_description} -- Progress status {GetAmountCompleted()}/{_target}";
    }

    // Child override of the base method called GetStringRepresentation that returns a string of the goal and attributes
    public override string GetStringRepresentation()
    {
        return $"{_typeOfGoal}: {_shortName} | {_description} | {_setPoints} | {_bonus} | {_target} | {GetAmountCompleted()} | {IsComplete()}";
    }

    // Function that advances the amount of completion for multi-stage goals
    public void SetAmountCompleted()
    {
        _amountCompleted++;
    }

    // Function that returns the amount of completion for multi-stage goals
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    // Child override of the base method called SetIsCompleteToTrue that sets the _isComplete variable to true
    public override void SetIsCompleteToTrue()
    {
        _isComplete = true;
    }

    // Function that sets the amount of the goal completed from the string of checklist goal data
    public void AddSaveAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

    // Function that adds the bonus points to the current points
    public void AddBonusPointToCurrentPoint()
    {
         _currentPoint += _bonus;
    }

}