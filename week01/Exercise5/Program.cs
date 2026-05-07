using System;

class Program
{
    static void Main(string[] args)
    {
        // Thirrja e funksioneve dhe ruajtja e vlerave që ato kthejnë
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // 2. Merr emrin e përdoruesit
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // 3. Merr numrin e preferuar
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // 4. Llogarit katrorin e numrit
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // 5. Shfaq rezultatin përfundimtar
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}