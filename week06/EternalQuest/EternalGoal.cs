public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Implementation for recording an event for an eternal goal
        Console.WriteLine("Eternal goal event recorded.");
    }
    public override bool IsComplete()
    {
        // Implementation to check if the eternal goal is complete
        return false; // Eternal goals are never complete
    }

    public override string GetStringRepresentation()
    {
        return "EternalGoal Representation"; // Placeholder
    }

    public override string GetDetailsString()
    {
        return "EternalGoal Details"; // Placeholder
    }
}