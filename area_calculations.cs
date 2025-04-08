using System;

class Program
{
    static void Main(string[] args)
    {
        int attempts = 0;
        const int maxAttempts = 3;
        bool validChoice = false;

        while (attempts < maxAttempts && !validChoice)// starts a while loop that continues as long as all the above conditions are met
        {
            Console.WriteLine("Select a figure to calculate its area:");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Circle");
            Console.Write("Enter your choice (1, 2, or 3): ");

            string choice = Console.ReadLine();



            switch (choice) // switch statement helps user input their choice and the selection now gets executed
            {
                case "1": // Triangle
                    Console.Write("Enter the base of the triangle: ");
                    double baseLength = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the height of the triangle: ");
                    double height = Convert.ToDouble(Console.ReadLine());

                    double triangleArea = 0.5 * baseLength * height;
                    Console.WriteLine($"The area of the triangle is: {triangleArea}");
                    validChoice = true;
                    break;

                case "2": // Rectangle
                    Console.Write("Enter the length of the rectangle: ");
                    double length = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the width of the rectangle: ");
                    double width = Convert.ToDouble(Console.ReadLine());

                    double rectangleArea = length * width;
                    Console.WriteLine($"The area of the rectangle is: {rectangleArea}");
                    validChoice = true;
                    break;

                case "3": // Circle
                    Console.Write("Enter the radius of the circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    double circleArea = Math.PI * radius * radius;
                    Console.WriteLine($"The area of the circle is: {circleArea}");
                    validChoice = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    attempts++;
                    if (attempts < maxAttempts)
                    {
                        Console.WriteLine($"You have {maxAttempts - attempts} attempts remaining.");
                    }
                    else
                    {
                        Console.WriteLine("You have exceeded the maximum number of attempts.");
                    }
                    break;// it breaks the switch statement
            }
        }
        //executed if user enters any other value that does not match the cases given
        if (!validChoice)
        {
            Console.WriteLine("Invalid choice. Please enter choice 1, 2 or 3.");
        }
        else
        {
            Console.WriteLine("Thank you for using the area calculator!");
        }
    }
}
