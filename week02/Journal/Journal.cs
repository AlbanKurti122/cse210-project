using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    // List property holding all active entries
    public List<Entry> Entries { get; set; } = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        Entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("The journal is currently empty. Try writing an entry first!");
            return;
        }

        Console.WriteLine("\n=== Journal Entries ===");
        foreach (var entry in Entries)
        {
            entry.Display();
        }
    }

    // Exceeding Requirements: Using structured JSON formatting instead of standard string splitting.
    // This allows users to use commas, quotes, and newlines in their writing safely.
    public void SaveToFile(string filename)
    {
        try
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(Entries, options);
            File.WriteAllText(filename, jsonString);
            Console.WriteLine($"Journal successfully saved to '{filename}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine($"Error: The file '{filename}' does not exist.");
                return;
            }

            string jsonString = File.ReadAllText(filename);
            // Deserialization replaces the current entry list entirely
            Entries = JsonSerializer.Deserialize<List<Entry>>(jsonString) ?? new List<Entry>();
            Console.WriteLine($"Journal successfully loaded from '{filename}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading: {ex.Message}");
        }
    }
}