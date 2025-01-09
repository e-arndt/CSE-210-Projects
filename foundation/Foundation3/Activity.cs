
public abstract class Activity
{
    
    private int _exerciseDuration;
    private string _exerciseName;
    private double _distance;
    private double _speed;
    private double _pace;
    private string _metricUnit;

    public Activity()
    {}

    private void SetExercisName()
    {
        Console.Write("Enter the exercise name: ");
        _exerciseName = Console.ReadLine();
    }

    private string GetExerciseName()
    {
        return _exerciseName;
    }

    private void SetExerciseDuration()
    {
        Console.Write("Enter the duration of your exercise: ");
        _exerciseDuration = int.Parse(Console.ReadLine());
    }

    protected int GetExerciseDuration()
    {
        return _exerciseDuration;
    }

    public void SetCalculatedDistance()
    {
        _distance = Math.Round(CalculateDistance(), 1);
    }

    private double GetCalculatedDistance()
    {
        SetCalculatedDistance();
        return _distance;
    }

    public void SetCalculatedSpeed()
    {
        _speed = Math.Round(CalculatePace(), 1);
    }

    private double GetCalculatedSpeed()
    {
        SetCalculatedSpeed();
        return _speed;
    }

    public void SetCalculatedPace()
    {
        _pace = Math.Round(CalculateSpeed(), 1);
    }

    private double GetCalculatedPace()
    {
        SetCalculatedPace();
        return _pace;
    }

    public string GetMetricUnit()
    {
        return _metricUnit;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    public void SetMetricUnit()
    {
        
        {
            _metricUnit = "miles";
        } 
    }

    public virtual void GetSummary()
    {
        
        string summary = $"{GetExerciseName()} ({GetExerciseDuration()} min):  Distance {GetCalculatedDistance()} {GetMetricUnit()}, Speed {GetCalculatedSpeed()} {GetMetricUnit()}, Pace {GetCalculatedPace()} min per {GetMetricUnit()}";
        Console.WriteLine(summary);
    }

    public void StartExercise()
    {
        SetMetricUnit();
        SetExercisName();
        SetExerciseDuration();
    }
}