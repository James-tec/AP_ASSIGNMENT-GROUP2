
using System;

public class SalesReport
{
    public static void Main(string[] args)
    {
        string[] salesmanNames = new string[10];

        int[,] sales = new int[10, 5];

        //Get details
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter salesman name:");
            salesmanNames[i] = Console.ReadLine();

            Console.WriteLine("Enter sales for each item:");
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine($"Item {j + 1}:");
                sales[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Calculate total sales
        int[] totalSales = new int[10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                totalSales[i] += sales[i, j];
            }
        }

        // Calculate grand total
        int grandTotal = 0;
        for (int i = 0; i < 10; i++)
        {
            grandTotal += totalSales[i];
        }

        // Output report
        Console.WriteLine("\nName\tItem1\tItem2\tItem3\tItem4\tItem5\tTotalSales");
        Console.WriteLine("___________________________________________________");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{salesmanNames[i]}\t");
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{sales[i, j]}\t");
            }
            Console.WriteLine($"{totalSales[i]}");
        }
        Console.WriteLine($"GrandTotal\t{grandTotal}");
    }
}
