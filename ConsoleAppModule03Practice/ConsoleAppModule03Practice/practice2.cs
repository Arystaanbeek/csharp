/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        int count = CountWordsWithSameFirstAndLastChar(inputString);
        Console.WriteLine($"The number of words with the same first and last character: {count}");
        Console.ReadKey();
    }

    public static int CountWordsWithSameFirstAndLastChar(string input)
    {
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;

        foreach (string word in words)
        {
            if (word.Length > 0 && word[0] == word[word.Length - 1])
            {
                count++;
            }
        }

        return count;
    }
}
*/