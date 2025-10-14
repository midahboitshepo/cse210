public abstract class Goal
{
    protected string _shortName;
    protected string _Description;
    protected int _Points;

    public int Points { get; internal set; }

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _Description = description;
        _Points = points;
    }

    public abstract void RecordEvent();


    public abstract bool IsComplete();


    public abstract string GetDetailsString();


    public abstract string GetStringRepresentation();
   

}