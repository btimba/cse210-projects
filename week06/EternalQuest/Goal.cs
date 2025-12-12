class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetails()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description})";
    }

    public virtual void RecordEvent()
    {
        // Default implementation does nothing
    }

    public virtual string GetStringRep()
    {
        return $"{_shortName},{_description},{_points}";
    }

    public int GetPoints()
    {
        return _points;
    }
}