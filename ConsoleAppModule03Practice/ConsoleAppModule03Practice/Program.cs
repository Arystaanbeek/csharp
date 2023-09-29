/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule03Practice
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a small Russian letter: ");
            char inputChar = Console.ReadLine()[0];

            if (IsRussianLowerCase(inputChar))
            {
                char upperCaseChar = char.ToUpper(inputChar);
                Console.WriteLine($"Big letter: {upperCaseChar}");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        public static bool IsRussianLowerCase(char c)
        {
            return c >= 'а' && c <= 'я';
        }
    }
}
*/