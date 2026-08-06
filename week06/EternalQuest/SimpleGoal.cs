using System;
public class SimpleGoal : Goal
{
    private bool _isComplete;
    private string _completionDate;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
        _completionDate = "";
    }
    public SimpleGoal(string shortName, string description, int points, bool isComplete, string completionDate) : base(shortName, description, points)
    {
        _isComplete = isComplete;
        _completionDate = completionDate;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        if (_isComplete)
        {
            return $"{base.GetDetailsString()} - Completed: {_completionDate}";
        }

        return base.GetDetailsString();
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetShortName()}|{GetDescription()}|{GetPoints()}|{_isComplete}|{_completionDate}";
    }
    public override int RecordEvent()
    {
        _isComplete = true;
        _completionDate = DateTime.Now.ToString("g");
        return GetPoints();
    }
}