public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string shortName, string description, int points, int targetCount, int bonusPoints)
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
            Console.WriteLine("Checklist goal event recorded.");
            if (_currentCount == _targetCount)
            {
                Console.WriteLine($"Congratulations! You've completed the checklist goal and earned a bonus of {_bonusPoints} points!");
            }
        }
        else
        {
            Console.WriteLine("This checklist goal is already complete.");
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_Description},{_bonusPoints},{_targetCount},{_currentCount},{_bonusPoints}";
    }

    public override string GetDetailsString()
    {
        return $"Checklist Goal: {GetStringRepresentation()} (Completed: {_currentCount}/{_targetCount})";
    }
}