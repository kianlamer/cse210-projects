using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Example scripture
        List<string> verses = new List<string>
        {
            "Trust in the Lord with all thine heart;",
            "and lean not unto thine own understanding.",
            "In all thy ways acknowledge him,",
            "and he shall direct thy paths."
        };

        Scripture scripture = new Scripture("Proverbs 3:5-6", verses);
        ScriptureMemorizer memorizer = new ScriptureMemorizer(scripture);

        while (true)
        {
            memorizer.DisplayScripture();
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            if (memorizer.HideRandomWords())
            {
                Console.WriteLine("All words are hidden. The scripture memorization is complete.");
                break;
            }
        }
    }
}