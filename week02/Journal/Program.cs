using System;

class Program
{
    static void Main(string[] args)
    {
        // SHOWING CREATIVITY / EXCEEDING REQUIREMENTS:
        // 1. Storage Format: Implemented robust data persistence using JSON format via System.Text.Json. 
        //    This cleanly circumvents delimiter collision bugs caused by users typing commas or quotes.
        // 2. Extra Prompts: Expanded the prompt array beyond the structural minimums to offer better variety.

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("Welcome to your Journal App!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load the journal from a file");
            Console.WriteLine("4. Save the journal to a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry
                    {
                        Date = DateTime.Now.ToShortDateString(),
                        PromptText = prompt,
                        EntryText = response
                    };

                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added to session.\n");
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter the filename to load (e.g., journal.json): ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine();
                    break;

                case "4":
                    Console.Write("Enter the filename to save as (e.g., journal.json): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine();
                    break;

                case "5":
                    keepRunning = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please enter a number from 1 to 5.\n");
                    break;
            }
        }
    }
}