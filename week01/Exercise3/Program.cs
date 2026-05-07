using System;


class Program
{
    static void Main(string[] args)
    {
      string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // 1. Gjenerimi i numrit magjik rastësor (nga 1 në 100)
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("\nI have thought of a magic number between 1 and 100.");

            // 2. Cikli që vazhdon derisa përdoruesi ta gjejë numrin
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++; // Shton një tentativë

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    // Stretch: Shfaq numrin e tentativave
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            // Stretch: Pyet përdoruesin nëse dëshiron të luajë përsëri
            Console.Write("\nDo you want to play again (yes/no)? ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}