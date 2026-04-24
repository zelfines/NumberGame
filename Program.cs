using System;

class NumberGame
{

    // Game
    static void Main()
    {
        string playAgain;
        do
        {
            Random rand = new Random();
            int target = rand.Next(1, 1000);
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("=========================================");
            Console.WriteLine("       WELCOME TO THE NUMBER GAME!     ");
            Console.WriteLine("=========================================");
            Console.WriteLine("\n        I Am Thinking Of A Number.");
            Console.WriteLine("         Can You Guess It? (o.0)");

            // Game Logic
            while (guess != target)
            {
                Console.Write("\nGuess The Number: ");
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