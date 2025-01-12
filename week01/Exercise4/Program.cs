using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Markup;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number = -1; // Initiating variable with a dummy value

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0) // Adding number to the list if it is not zero
            {
                numbers.Add(number);
            }
        }

        int sum = 0; // Declaring variable to store the sum of numbers

        foreach (int value in numbers)
        {
            sum += value;
        }

        int count = numbers.Count; // Number of items in the list
        double average = (double)sum / count; // Double for better decimal

        int maxValue = numbers[0]; // Setting first number as the max value
        foreach (int value in numbers)
        {
            if (value > maxValue)
            {
                maxValue = value;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxValue}");
    }
}