class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }
    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override void RecordEvent()
    {
        // Eternal goals get points every time an event is recorded
    }

    public override string GetStringRep()
    {
        return $"EternalGoal,{base.GetStringRep()}"; // Eternal goals are never complete
    }
}