using System;
using System.IO;


public class Journal

{
    public string _name;

    // initialize  list to a new List before using it.
    public List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        
    }

    public void DisplayAll()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Entries:");
        
        // Notice the use of the custom data type "Entry" in this loop
        foreach (Entry entry in _entries)
        {
            // This calls the Display method on each entry
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {

        using var outputFile = new StreamWriter(file);
        
        foreach (Entry entry in _entries)
        {
            outputFile.WriteLine($"{entry._date} ({entry._promptText}) {entry._entryText}");
        }

    }
    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            string[] parts = line.Split(")");
            Entry loadedEntry = new Entry();
            loadedEntry._date = parts[0].Substring(0, 10);
            loadedEntry._promptText = parts[0].Substring(12);
            loadedEntry._entryText = parts[1].Trim();
            _entries.Add(loadedEntry);

        }
        
    }
}