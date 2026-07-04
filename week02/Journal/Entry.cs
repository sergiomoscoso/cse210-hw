using System;

public class Entry
{
    // Private member variables (Encapsulation)
    private string _date = "";
    private string _promptText = "";
    private string _entryText = "";

    // Constructor
    public Entry(string date, string prompt, string text)
    {
        _date = date;
        _promptText = prompt;
        _entryText = text;
    }

    // Method to display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine(); // Blank line for readability
    }
    
    // Getters for saving/loading functionality
    public string GetDate() => _date;
    public string GetPrompt() => _promptText;
    public string GetText() => _entryText;
}
