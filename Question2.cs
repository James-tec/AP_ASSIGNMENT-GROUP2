using System;

class Program
{
    static void Main()
    {
        int size = 6; 

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (j == i || i == 0 || i == size - 1)
                {
                    Console.Write("&");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine(); 
        }
    }
}