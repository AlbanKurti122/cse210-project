using System; 
namespace ExerciseTracking
{
public class Swimming : Activity
{
    private int _laps;
    private double _lapLength = 50.0; // meters

    public Swimming(DateTime date, int length, int laps)
        : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * _lapLength) / 1000; // km
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}
}