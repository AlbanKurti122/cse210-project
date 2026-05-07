using System;
using System.Collections.Generic; 


class Program
{
    static void Main(string[] args)
    {
      List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;

        // 1. Marrja e numrave nga përdoruesi
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // --- Core Requirements ---

        // Llogaritja e shumës
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Llogaritja e mesatares
        // Përdorim (double) për të marrë pjesën dhjetore saktë
        double average = ((double)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Gjetja e numrit më të madh
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // --- Stretch Challenges ---

        // 1. Gjetja e numrit pozitiv më të vogël (më afër zeros)
        int smallestPositive = int.MaxValue; 
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // 2. Renditja e listës (Sort)
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}