using System;
using System.Collections.Generic;

class WordStatistics
{
    public Dictionary<string, int> GetWordFrequency(string text)
    {
        var wordFrequency = new Dictionary<string, int>();
        var separators = new char[] { ' ', ',', '.', '!', '?', '\n', '\r' };

        foreach (var word in text.Split(separators, StringSplitOptions.RemoveEmptyEntries))
        {
            var cleanedWord = word.Trim().ToLower();

            if (wordFrequency.ContainsKey(cleanedWord))
            {
                wordFrequency[cleanedWord]++;
            }
            else
            {
                wordFrequency[cleanedWord] = 1;
            }
        }

        return wordFrequency;
    }

    public void DisplayWordStatistics(Dictionary<string, int> wordFrequency)
    {
        Console.WriteLine("Word\tFrequency");
        Console.WriteLine("----------------");

        foreach (var pair in wordFrequency)
        {
            Console.WriteLine($"{pair.Key}\t{pair.Value}");
        }
    }
}

class Program
{
    static void Main()
    {
        string sampleText = @"
            Here is the house that Jack built.
            This is the malt that lay in the house that Jack built.
            This is the rat that ate the malt that lay in the house that Jack built.
            This is the cat that killed the rat that ate the malt that lay in the house that Jack built.
            This is the dog that worried the cat that killed the rat that ate the malt that lay in the house that Jack built.
            ";

        var wordStats = new WordStatistics();
        var statistics = wordStats.GetWordFrequency(sampleText);

        wordStats.DisplayWordStatistics(statistics);
    }
}
