using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Exercise Tracking Program!");

        // Create a list of activities
        var activities = new List<Activity>
        {
            new Running("Running: 2023-10-01", 30, 3.0),
            new Cycling("Cyclying: 2023-10-02", 45, 15.0),
            new Swimming("Swimming: 2023-10-03", 60, 2.0)
        };
        // Display summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}