using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for their grade percentage
        Console.Write("What is your grade percentage?");
        float percent = float.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";

        // Determine letter grade based on the percentage
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign for the grades
        if (letter != "F")
        {
            int lastdigit = (int)percent % 10; // Get the last digit of the percentage

            if (lastdigit >= 7)
            {
                sign = "+";
            }
            else if (lastdigit <= 3)
            {
                sign = "-";
            }
        }
        
        // Handle special cases for the grades
        if (letter == "A" && sign == "+")
        {
            sign = ""; // No A+ grade
        }
        else if (letter == "F")
        {
            sign = ""; // No F+ or F- grade
        }

        // Print the letter grade with the sign
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

    }
}