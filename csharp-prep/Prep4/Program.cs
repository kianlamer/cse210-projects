using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = new List<double>();
        double input;

        Console.WriteLine("Please give a list of numbers, type 0 when you are finished.");

        // Collect the user numbers
        do
        {
            Console.Write("Enter number: ");
            input = double.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);

        //Core requirements
        if (numbers.Count > 0)
        {
            double sum = 0;
            double max = numbers[0];

            foreach (double number in numbers)
            {
                sum += number;
                if (number > max)
                {
                    max = number;
                }
            }

            double average = sum / numbers.Count;

            // Display results
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");

            // Stretch Challenge
            double smallestPositive = double.MaxValue;

            foreach (double number in numbers)
            {
                if (number > 0 && number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }

            // Check for positive numbers
            if (smallestPositive != double.MaxValue)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }

            // Sort the list
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (double number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}