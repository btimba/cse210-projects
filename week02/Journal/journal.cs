using System.Collections.Generic;
using System.Xml;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        // Method to add a journal entry
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry
        {
            _date = DateTime.Now.ToString("MM/dd/yyyy"),
            _promptText = prompt,
            _entryText = response
        };

        _entries.Add(newEntry);
        Console.WriteLine("Journal entry added successfully.");

    }
    public void DisplayEntries()
    {   // Method to display all journal entries
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries to display.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }

    }
    public void SaveToFile()

    {
        // Method to save journal entries to a file
        Console.Write("Enter the filename to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._promptText);
                writer.WriteLine(entry._entryText);
                writer.WriteLine(); // Blank line to separate entries
            }
        }
    }
    public void LoadFromFile()
    {
        // Method to load journal entries from a file
        Console.Write("Enter the filename to load from: ");
        string filename = Console.ReadLine();

        if(!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
            };

            _entries.Add(entry);
            }
        }
    }

    public void ShowMenu()
    {
        Console.WriteLine("Welcome to the Journal Program.");
        Console.WriteLine("Please select one of the following options:");
        Console.WriteLine("1. Add Entry");
        Console.WriteLine("2. Display Entries");
        Console.WriteLine("3. Save to File");
        Console.WriteLine("4. Load from File");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }
}

