using System;

class Program
{
     // Creativity:
    // Added a persistent scoring system with Save/Load.
   // Users can level up based on points (future extension idea).
  // Checklist goals track progress automatically.
 // Eternal goals encourage long-term habits.
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            manager.DisplayPlayerInfo();

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "6")
                break;

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;

                case "2":
                    manager.ListGoals();
                    break;

                case "3":
                    Console.Write("Enter goal number: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                    break;

                case "4":
                    manager.SaveGoals("goals.txt");
                    Console.WriteLine("Saved!");
                    break;

                case "5":
                    manager.LoadGoals("goals.txt");
                    Console.WriteLine("Loaded!");
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            manager.AddGoal(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            manager.AddGoal(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }
}