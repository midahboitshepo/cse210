using System;

class Program
{
    public static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Midah", "Programming with C#");
        Console.WriteLine(assignment.GetSummary());
    }
}