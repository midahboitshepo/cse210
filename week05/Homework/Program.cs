using System;

class Program
{
    public static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Midah", "Programming with C#");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Bothepha", "Multiplication", "Section 10.3", "Problems 20-29");
        Console.WriteLine(mathAssignment.GetSummary());

        WritingAssignment writingAssignment = new WritingAssignment("Nancy", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}