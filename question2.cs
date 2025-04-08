using System;

namespace PatternOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pattern Output Program");
            Console.WriteLine();
            
            // Define size of the pattern
            const int size = 6;
            
            // Loop through each row
            for (int row = 0; row < size; row++)
            {
                // Loop through each column in the current row
                for (int col = 0; col < size; col++)
                {
                    // Print '&' if it's on the border or diagonal, otherwise print '*'
                    if (row == 0 || row == size - 1 || col == row)
                    {
                        Console.Write("&");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                // Move to the next line after each row
                Console.WriteLine();
            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
