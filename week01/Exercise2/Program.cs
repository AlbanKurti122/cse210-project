using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Marrja e përqindjes nga përdoruesi
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string letter = "";
        string sign = "";

        // 2. Logjika për përcaktimin e shkronjës së notës
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // --- Stretch Challenge: Përcaktimi i shenjës (+ ose -) ---
        int lastDigit = percent % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Rregullimi i rasteve specifike (A+, F+, F-)
        if (letter == "A" && sign == "+")
        {
            sign = ""; // Nuk ekziston A+
        }
        if (letter == "F")
        {
            sign = ""; // Nuk ekziston F+ ose F-
        }

        // 3. Shfaqja e notës përfundimtare
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // 4. Kontrolli nëse ka kaluar klasën
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying! You can do better next time.");
        }
    }
}