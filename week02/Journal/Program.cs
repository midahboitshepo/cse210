using System;
using System.ComponentModel.Design;

class Program
{

    static void Main(string[] args)
    {// Main menu loop
        while (true)
        {
            // Display the main menu
            Console.Write("Welcome to the Jornal Program!\n");
            Console.Write("Please select one of the following choices:\n");
            Console.Write("1. Write\n");
            Console.Write("2. Display\n");
            Console.Write("3. Load\n");
            Console.Write("4. Save\n");
            Console.Write("5. Quit\n");
            Console.Write("What would you like to do? ");

            // Get the user's choice
            string choice = Console.ReadLine();

            // Create a new journal instance
            Journal myJournal = new Journal();
            myJournal._name = "My Journal";
            myJournal._entries = new List<Entry>();

            // Handle the user's choice
            if
            (choice == "1")
            {
                Console.Write("You chose to write a new entry.\n");
                PromptGenerator myPrompt = new PromptGenerator();
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = myPrompt.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);
                Console.Write("Type your response: ");
                newEntry._entryText = Console.ReadLine();
                myJournal.AddEntry(newEntry);
                Console.WriteLine("Entry added to the journal.");

            }

            else if (choice == "2")
            {
                Console.Write("You chose to display the journal.\n");
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("You chose to load a journal.\n");
                myJournal.LoadFromFile("myEntries.txt");
            }
            else if (choice == "4")
            {
                Console.Write("You chose to save the journal.\n");
                Journal mySavedJournal = new Journal();
                mySavedJournal._name = "My Journal";
                mySavedJournal._entries = new List<Entry>();
                mySavedJournal.SaveToFile("myEntries.txt");
                Console.WriteLine("Journal saved to myEntries.txt");
            }
            else if (choice == "5")
            {
                Console.Write("Thank you for using the Journal Program. Goodbye!\n");
                return;
            }
            else
            {
                // Handle invalid input
                Console.Write("Invalid choice. Please select a valid option.\n");
            }
            // Add a blank line for better readability
            Console.WriteLine();
        }
    }
}
