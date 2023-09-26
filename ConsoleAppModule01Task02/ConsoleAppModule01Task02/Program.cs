using System;

namespace ConsoleAppModule01Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (to finish typing, press Enter): ");
            int sum = 0;
            bool isEnteringNumbers = true;

            while (isEnteringNumbers)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "")
                {
                    isEnteringNumbers = false;
                }
                else if (int.TryParse(input, out int number)) 
                {
                    sum += number;
                }
                else
                {
                    Console.Write("Error! Please enter a number: ");
                }
            }

            Console.WriteLine($"Sum of numbers: {sum}");
            Console.ReadKey();
        }
    }
}
