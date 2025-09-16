using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        // Create a new entry instance     
        Entry myEntry = new Entry();
        myEntry._date = DateTime.Now.ToShortDateString();
        myEntry._entryText = Console.ReadLine();

        // Use PromptGenerator to get a random prompt
        PromptGenerator myPrompt = new PromptGenerator();
        string prompt = myPrompt.GetRandomPrompt();
        myEntry._promptText = prompt;
        

        // Display the entry
        Console.WriteLine($"{_date} ({_promptText}) {_entryText}");       

    }
}