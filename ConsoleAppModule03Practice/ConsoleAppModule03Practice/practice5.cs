/*using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a text: ");
        string input = Console.ReadLine();

        int maxConsecutiveCount = FindMaxConsecutiveCount(input);
        Console.WriteLine($"The largest number of consecutive identical characters: {maxConsecutiveCount}");
        Console.ReadKey();
    }
    public static int FindMaxConsecutiveCount(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return 0;
        }

        int maxCount = 1; 
        int currentCount = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == input[i - 1])
            {
                currentCount++;
            }
            else
            {
                maxCount = Math.Max(maxCount, currentCount);
                currentCount = 1;
            }
        }
        maxCount = Math.Max(maxCount, currentCount);

        return maxCount;
    }
}
*/