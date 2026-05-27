using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>();
        string filename = "scriptures.txt";

        // Create a default backup file if it doesn't exist yet to make testing easy
        if (!File.Exists(filename))
        {
            string[] defaultLines = {
                "John|3|16|For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
                "Proverbs|3|5|6|Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
                "Philippians|4|13|I can do all things through Christ which strengtheneth me."
            };
            File.WriteAllLines(filename, defaultLines);
        }

        // Load scriptures from the file
        try
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                // Check if it's a single verse (4 parts) or a range (5 parts)
                if (parts.Length == 4)
                {
                    Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
                    scriptureLibrary.Add(new Scripture(reference, parts[3]));
                }
                else if (parts.Length == 5)
                {
                    Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
                    scriptureLibrary.Add(new Scripture(reference, parts[4]));
                }
            }
        }
        catch (Exception)
        {
            // Safe fallback if file read encounters unexpected formatting issues
            scriptureLibrary.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world..."));
        }

        // Pick a random scripture from the library
        Random random = new Random();
        Scripture selectedScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        // Main game loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();

            if (selectedScripture.IsCompletelyHidden())
            {
                Console.WriteLine("Great job! You have fully memorized the scripture reference block.");
                break;
            }

            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            // Hide 3 random words per turn
            selectedScripture.HideRandomWords(3);
        }
    }
}