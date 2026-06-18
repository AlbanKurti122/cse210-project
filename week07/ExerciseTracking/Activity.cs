using System;
namespace ExerciseTracking{
public abstract class Activity
{
    private DateTime _date;
    private int _length; // in minutes

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetLength()
    {
        return _length;
    }

    // Abstract methods (must be overridden)
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_length} min) - " +
               $"Distance {GetDistance():0.0}, Speed {GetSpeed():0.0}, Pace: {GetPace():0.0}";
    }
} 
}