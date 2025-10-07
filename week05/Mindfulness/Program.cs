using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness Activities");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.Write("Select an activity (1-3): ");
        string choice = Console.ReadLine();
        Activity activity;

        switch (choice)
        {
            case "1":
                activity = new BreathingActivity();
                break;
            case "2":
                activity = new ReflectingActivity();
                break;
            case "3":
                activity = new ListingActivity();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        if (activity is BreathingActivity breathingActivity)
        {
            breathingActivity.run();
        }
        else if (activity is ReflectingActivity reflectingActivity)
        {
            reflectingActivity.run();
        }
        else if (activity is ListingActivity listingActivity)
        {
            listingActivity.run();
        }
    }
}