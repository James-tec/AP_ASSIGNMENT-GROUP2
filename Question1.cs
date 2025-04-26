using System;

class LuckyNumberGame
{
    static void Main()
    {
        Console.Write("Enter the number of rounds you wish to play: ");
        int rounds = int.Parse(Console.ReadLine());

        int totalScore = 0;
        int secretNumber = 7; 

        for (int i = 1; i <= rounds; i++)
        {
            Console.Write($"Round {i}: Enter your lucky number: ");
            int luckyNumber = int.Parse(Console.ReadLine());
            int remainder = luckyNumber % secretNumber;

            if (remainder == 0)
            {
                Console.WriteLine("It's a draw! (+1 point)");
                totalScore += 1;
            }
            else if (remainder % 2 == 0)
            {
                Console.WriteLine("You win this round! (+3 points)");
                totalScore += 3;
            }
            else
            {
                Console.WriteLine("You lose this round! (-3 points)");
                totalScore -= 3;
            }
        }

        Console.WriteLine($"Final Score: {totalScore}");
        if (totalScore > 0)
        {
            Console.WriteLine("Congratulations! You won the game!");
        }
        else
        {
            Console.WriteLine("Game over! You lost the game!");
        }
    }
}
