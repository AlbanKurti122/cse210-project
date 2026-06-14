public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;
    private int _current;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _current = 0;
    }

    public override int RecordEvent()
    {
        _current++;

        if (_current >= _target)
        {
            return _points + _bonus;
        }

        return _points;
    }

    public override bool IsComplete()
    {
        return _current >= _target;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_name} ({_description}) -- Completed {_current}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_bonus}|{_current}|{_target}";
    }

    public int GetCurrent() => _current;
    public int GetTarget() => _target;
}