using System;

public class Entry
{
    // Properties to hold the entry data
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    // Responsible for displaying its own contents cleanly
    public void Display()
    {
        Console.WriteLine($"Date: {Date} — Prompt: {PromptText}");
        Console.WriteLine($"{EntryText}");
        Console.WriteLine(new string('-', 40)); // Visual separator line
    }
}