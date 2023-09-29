using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice18
    {
        static int f(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                return 0;
            }
            else if (y == 0 && x != 0)
            {
                return 12 / x;
            }
            else if (x == 0 && y != 0)
            {
                return 12 / y;
            }
            else
            {
                return 144 / (x * y);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());
            int funcResult = f(x, y);
            Console.WriteLine($"function result: {funcResult}");
            Console.ReadKey();
        }
    }
}
