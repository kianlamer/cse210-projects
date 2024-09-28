using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain;

        do
        {
            // Generate a number between 1 and 100
            int magicNumber = random.Next(1, 101);
            int guess = 0;
            int guessCount = 0;

            Console.WriteLine("Welcome to Number Guesser!");

            while (guess != magicNumber)
            {
                // Ask user to input a number
                Console.Write("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                // Determine if the number is too high/low, or correct
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
                }
            }
            // Inform the user how many guesses they made
            Console.WriteLine($"It took you {guessCount} guesses.");

            // Ask if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "yes";

        } while (playAgain);
        
        Console.WriteLine("Thanks for playing!");
    }

}
