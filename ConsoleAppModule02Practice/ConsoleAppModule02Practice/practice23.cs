using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice23
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a first number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter a first number: ");
            int c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine($"{a}");
            }
            else if (b < c && b < a)
            {
                Console.WriteLine($"{b}");
            }
            else if (c < b && c < a)
            {
                Console.WriteLine($"{c}");
            }
            else
            {
                Console.WriteLine($"a = b = c");
            }
            Console.ReadKey();
        }

    }
}
