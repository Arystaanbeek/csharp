/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Enter a name: ");
        string name = Console.ReadLine();

        if (CanSpellName(input, name))
        {
            Console.WriteLine($"You can make a name: {name}");
        }
        else
        {
            Console.WriteLine("Noname");
        }
        Console.ReadKey();
    }

    public static bool CanSpellName(string text, string name)
    {
        int currentIndex = 0;

        foreach (char letter in name)
        {
            currentIndex = text.IndexOf(letter, currentIndex);

            if (currentIndex == -1)
            {
                return false;
            }

            currentIndex++;
        }

        return true;
    }
}
*/