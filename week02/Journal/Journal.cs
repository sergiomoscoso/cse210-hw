using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public int EntryCount => _entries.Count;

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                // Format: Date|Prompt|Text (using | as separator)
                writer.WriteLine($"{entry.GetDate()}|{entry.GetPrompt()}|{entry.GetText()}");
            }
        }
        Console.WriteLine($"Journal saved successfully to {filename}!");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Starting with an empty journal.");
            return;
        }

        _entries.Clear(); // Clear current entries before loading

        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split('|');

                if (parts.Length >= 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    // Join remaining parts in case user typed '|' in their text
                    string text = string.Join("|", parts, 2, parts.Length - 2);

                    Entry newEntry = new Entry(date, prompt, text);
                    _entries.Add(newEntry);
                }
            }
        }
        Console.WriteLine($"Journal loaded successfully from {filename}!");
    }
}