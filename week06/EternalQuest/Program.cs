using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display Info");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.ListGoalNames();
                    Console.Write("Enter the type of goal to create (1-3): ");
                    string goalType = Console.ReadLine();
                    Console.Write("Enter the name of the goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter a short description of the goal: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter the points associated with this goal: ");
                    int points = int.Parse(Console.ReadLine());

                    Goal newGoal = null;
                    if (goalType == "1")
                    {
                        newGoal = new SimpleGoal(name, description, points);
                    }
                    else if (goalType == "2")
                    {
                        newGoal = new EternalGoal(name, description, points);
                    }
                    else if (goalType == "3")
                    {
                        Console.Write("Enter the number of times to complete for bonus: ");
                        int targetCount = int.Parse(Console.ReadLine());
                        Console.Write("Enter the bonus points for completing the checklist: ");
                        int bonusPoints = int.Parse(Console.ReadLine());
                        newGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal type.");
                        break;
                    }

                    goalManager.CreateGoal(newGoal);
                    break;

                case "2":
                    goalManager.ListGoalDetails();
                    break;

                case "3":
                    Console.Write("Enter the filename to save goals: ");
                    string saveFilename = Console.ReadLine();
                    goalManager.SaveGoals(saveFilename);
                    break;

                case "4":
                    Console.Write("Enter the filename to load goals: ");
                    string loadFilename = Console.ReadLine();
                    goalManager.LoadGoals(loadFilename);
                    break;
                case "5":
                    goalManager.ListGoalDetails();
                    Console.Write("Enter the index of the goal to record an event for: ");
                    int goalIndex = int.Parse(Console.ReadLine());
                    goalManager.RecordEvent(goalIndex - 1); // Adjust for 0-based index
                    break;
                case "6":
                    goalManager.DisplayInfo();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        Console.WriteLine("Thank you for using the Eternal Quest Goal Tracker!");
    }
}

