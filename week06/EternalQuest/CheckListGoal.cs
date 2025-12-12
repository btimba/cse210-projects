class CheckListGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public CheckListGoal(string shortName, string description, int points, int targetCount, int currentCount, int bonusPoints)
        : base(shortName, description, points)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonusPoints = bonusPoints;
    }

    public CheckListGoal(string shortName, string description, int points, int targetCount, int bonusPoints)
        : base(shortName, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public override string GetDetails()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {base.GetDetails()} -- Currently completed: {_currentCount}/{_targetCount}";
    }

    public override string GetStringRep()
    {
        return $"CheckListGoal,{base.GetStringRep()},{_targetCount},{_currentCount},{_bonusPoints}";
    }
}