using System;
using System.Collections.Generic;

public class ScriptureMemorizer
{
    private Scripture _scripture;
    private List<string> _displayedVerses;
    private Random _random;

    public ScriptureMemorizer(Scripture scripture)
    {
        _scripture = scripture;
        _displayedVerses = new List<string>(_scripture.GetVerses());
        _random = new Random();
    }

    public bool HideRandomWords()
    {
        bool allWordsHidden = true;
        for (int i = 0; i < _displayedVerses.Count; i++)
        {
            string verse = _displayedVerses[i];
            string[] words = verse.Split(' ');
            for (int j = 0; j < 1; j++)
            {
                int randomIndex = _random.Next(words.Length);
                if (words[randomIndex] != "___")
                {
                    words[randomIndex] = "___";
                    allWordsHidden = false;
                }
            }
            _displayedVerses[i] = string.Join(" ", words);
        }
        return allWordsHidden;
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(_scripture.GetReference());
        foreach (string verse in _displayedVerses)
        {
            Console.WriteLine(verse);
        }
    }
}