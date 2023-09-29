using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice11
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.Write("R = ");
            int R = int.Parse(Console.ReadLine());
            Console.WriteLine($"L = {2 * pi * R}");
            Console.WriteLine($"S = {pi * Math.Pow(R, 2)}");
            Console.ReadKey();
        }
    }
}
