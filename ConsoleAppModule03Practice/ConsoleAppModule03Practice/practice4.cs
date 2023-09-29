/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a 20-character string: ");
        string input = Console.ReadLine();

        if (input.Length != 20)
        {
            Console.WriteLine("The string must contain 20 characters.");
        }
        else
        {
            int digitCount = CountDigits(input);
            Console.WriteLine($"Number of digits per line: {digitCount}");
        }
        Console.ReadKey();
    }

    public static int CountDigits(string input)
    {
        int digitCount = 0;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                digitCount++;
            }
        }

        return digitCount;
    }
}
*/