/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule03Practice
{
    internal class practice9
    {
        static void Main()
        {
            string input = Console.ReadLine();

            input = input.Replace(" ", "").ToLower();

            int length = input.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (input[i] != input[length - 1 - i])
                {
                    Console.WriteLine("the string is not a palindrome.");
                }
                else
                {
                    Console.WriteLine("the string is a palindrome.");
                }
            }
            Console.ReadKey();
        }

    }
}
*/