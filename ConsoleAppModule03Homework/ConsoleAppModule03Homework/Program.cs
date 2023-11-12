/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule03Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "123 45 674 92 324 7893 12";
            string[] words = input.Split(' ');

            int sum = 0;

            foreach (string i in words)
            {
                if (i.EndsWith("3") || i.EndsWith("4"))
                {
                    if (int.TryParse(i, out int number))
                    {
                        sum += number;
                    }
                }
            }

            Console.WriteLine("The sum of numbers ending in 3 or 4: " + sum);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
*/