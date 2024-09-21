using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt for first name 
        Console.Write("What is your first name?");
        string firstname = Console.ReadLine();

        // Prompt for last name
        Console.Write("What is your last name?");
        string lastname = Console.ReadLine();
        
        // Display the formatted output
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}