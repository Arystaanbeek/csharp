using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02
{
    internal class task19
    {
        static void Main()
        {
            if (double.TryParse(Console.ReadLine(), out double a))
            {
                double x = 12 * Math.Pow(a, 2) + 7 * a - 16;
                Console.WriteLine($"If a = {a} is x = {x}");
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
        }
    }
}
