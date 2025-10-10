public class Goal
{
    private string _shortName;
    private string _Description;
    private int _Points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _Description = description;
        _Points = points;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _Description;
    }

    public int GetPoints()
    {
        return _Points;
    }

    public virtual void RecordEvent()
    {
        // This method can be overridden in derived classes
    }

    public virtual bool IsComplete()
    {
        return false; // Default implementation, can be overridden
    }

    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_Description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName},{_Description},{_Points}";
    }

    public virtual void DisplayGoal()
    {
        System.Console.WriteLine(GetDetailsString());
    }
}