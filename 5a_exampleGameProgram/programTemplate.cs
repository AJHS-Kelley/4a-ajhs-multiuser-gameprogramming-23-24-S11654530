//Ronald Durham, Program Template, v0.0

using System;

class BasketballGame
{
    static void Main()
    {
        int playerScore = 0;

        Console.WriteLine("Welcome to the Basketball Game!");
        Console.WriteLine("Try to score as many points as you can.");

        while (true)
        {
            Console.WriteLine($"Your current score: {playerScore}");
            Console.Write("Do you want to shoot the ball? (yes/no): ");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "yes")
            {
                // Simulate shooting by generating a random number (1 or 0)
                int shotResult = new Random().Next(2);

                if (shotResult == 1)
                {
                    Console.WriteLine("Swish! You scored a point!");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("Oh no! You missed the shot.");
                }
            }
            else if (userInput == "no")
            {
                Console.WriteLine("Thanks for playing! Your final score is: " + playerScore);
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
        }
    }
}