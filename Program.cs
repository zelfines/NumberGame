using System;

class NumberGame
{

    // Game
    static void Main()
    {
        string playAgain;
        int totalWins = 0;
        do
        {
            Random rand = new Random();
            int target = rand.Next(1, 1000);
            int guess = 0;
            int attempts = 0;
            int maxAttempts = 10;

            Console.WriteLine("=========================================");
            Console.WriteLine("       WELCOME TO THE NUMBER GAME!     ");
            Console.WriteLine("=========================================");
            Console.WriteLine("\n        I Am Thinking Of A Number.");
            Console.WriteLine($"           You Have {maxAttempts} Attempts.");
            Console.WriteLine("          Can You Guess It? (o.0)");

            // Game Logic
            while (guess != target)
            {
                if (attempts >= maxAttempts)
                {
                    Console.WriteLine("\n=========================================");
                    Console.WriteLine("        GAME OVER! OUT OF ATTEMPTS.");
                    Console.WriteLine($"        The number was: {target}");
                    Console.WriteLine("=========================================");
                    break;
                }
                Console.WriteLine($"\nAttempt {attempts + 1} of {maxAttempts}");
                Console.Write("Guess The Number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    attempts++;

                    if (guess > target)
                        Console.WriteLine("L O W E R! Try Again.");
                    else if (guess < target)
                        Console.WriteLine("H I G H E R! Try Again.");
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("=========================================");
                        Console.WriteLine("        ! YOU GUESSED IT RIGHT !");
                        Console.WriteLine($"           AFTER {attempts} ATTEMPTS");
                        Console.WriteLine("=========================================");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine(" O_O Please Enter A Valid Number...");
                }
            }

            // Play Again
            Console.Write("\nWant To Play Again? (Y/N): ");
            playAgain = Console.ReadLine().Trim().ToUpper();

        } while (playAgain == "Y");

        Console.WriteLine("=========================================");
        Console.WriteLine("           Thanks For Playing!");
        Console.WriteLine("             Shutting Down...");
        Console.WriteLine("=========================================");
    }
}
