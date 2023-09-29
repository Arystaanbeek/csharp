using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice15
    {
        static void Main(string[] args)
        {

            bool X = bool.Parse(Console.ReadLine());
            bool Y = bool.Parse(Console.ReadLine());
            Console.WriteLine($"a: {!X && !Y}");
            Console.WriteLine($"b: {X || (!X && Y)}");
            Console.WriteLine($"c: {(!X && Y) || Y}");
            Console.ReadKey();

        }
    }
}
