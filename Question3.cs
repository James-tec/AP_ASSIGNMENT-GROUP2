namespace ConsoleApp1;

using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask how many customers will be processed
        Console.Write("Enter the number of customers to evaluate: ");
        int numberOfCustomers = int.Parse(Console.ReadLine());

        // Loop through each customer
        for (int i = 0; i < numberOfCustomers; i++)
        {
            Console.WriteLine($"\nProcessing Customer {i + 1}...");

            // Read the client's credit limit
            Console.Write("Enter your credit limit: ");
            double creditLimit = double.Parse(Console.ReadLine());

            // Read the price of the item
            Console.Write("Enter the price of the item: ");
            double price = double.Parse(Console.ReadLine());

            // Initialize quantity and total value
            int quantity = 0;
            double totalValue = 0;

            // Check whether the total purchase value is within the credit limit
            do
            {
                // Read the quantity of items to purchase
                Console.Write("Enter the quantity of items you wish to purchase: ");
                quantity = int.Parse(Console.ReadLine());

                // Calculate the total value of the purchase
                totalValue = price * quantity;

                // Check if the total value exceeds the credit limit
                if (totalValue > creditLimit)
                {
                    Console.WriteLine("Sorry, you cannot purchase goods worth such a value on credit. Please re-enter the quantity.");
                }
                else
                {
                    Console.WriteLine($"Thank you for purchasing from us! The total value of your purchase is: {totalValue:C}");
                }

            } while (totalValue > creditLimit);
        }
    }
}