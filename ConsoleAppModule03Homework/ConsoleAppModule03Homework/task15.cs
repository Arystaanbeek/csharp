/*using System;

class task15
{
    static void Main()
    {
        
        string input = Console.ReadLine();

        string newString = ConvertCase(input);

        Console.WriteLine($"Result: {newString}");
        Console.ReadKey();
    }

    static string ConvertCase(string text)
    {
        char[] arr = text.ToCharArray();

        for (int i = 0; i < arr.Length; i++)
        {
            char currentChar = arr[i];

            if (char.IsLower(currentChar))
            {
                arr[i] = char.ToUpper(currentChar);
            }
            else if (char.IsUpper(currentChar))
            {
                arr[i] = char.ToLower(currentChar);
            }
        }

        return new string(arr);
    }
}
*/