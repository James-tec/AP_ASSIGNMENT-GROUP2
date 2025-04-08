using System;

namespace ComputerGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Secret number for the game
            const int secretNumber = 7; // Can be any number
            int totalScore = 0;
        
            Console.WriteLine("Welcome to the Lucky Number Game!");
            
            // Get the number of rounds from the user
            Console.Write("Enter the number of rounds you wish to play: ");
            int rounds = Convert.ToInt32(Console.ReadLine());
            
            // Loop through each round
            for (int round = 1; round <= rounds; round++)
            {
                Console.Write($"Round {round}: Enter your lucky number: ");
                int luckyNumber = Convert.ToInt32(Console.ReadLine());
              
                // Calculate the remainder
                int remainder = luckyNumber % secretNumber;
              
                // Check the result based on the remainder
                if (remainder == 0)
                {
                    totalScore += 1;
                    Console.WriteLine("It's a draw! +1 point");
                }
                else if (remainder % 2 == 0)
                {
                    totalScore += 3;
                    Console.WriteLine("You win this round! +3 points");
                }
                else
                {
                    totalScore -= 3;
                    Console.WriteLine("You lose this round! -3 points");
                }
              
                Console.WriteLine($"Current score: {totalScore}");
                Console.ReadKey();
            }
            
            // Determine if the player won overall
            if (totalScore > 0)
            {
                Console.WriteLine($"Congratulations! You won with a final score of {totalScore}");
            }
            else if (totalScore == 0)
            {
                Console.WriteLine("It's a tie! Your final score is 0");
            }
            else
            {
                Console.WriteLine($"Sorry, you lost with a final score of {totalScore}");
            }
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
