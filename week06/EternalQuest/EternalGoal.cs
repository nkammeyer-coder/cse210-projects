public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        
    }
    public override void RecordEvent()
    {
        // no value to change or add.  points are earned each time as it never completes.
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetShortName()}|{GetDescription()}|{GetPoints()}";
    }
}