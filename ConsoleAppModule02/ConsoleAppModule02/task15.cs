/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02
{
    internal class task15
    {
        static void Main()
        {
            Console.WriteLine("year: ");
            int g = int.Parse(Console.ReadLine());
            Console.Write("month: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("day: ");
            int n = int.Parse(Console.ReadLine());

            DateTime dateTime = new DateTime(g, m, n);
            Console.WriteLine($"previous day: {dateTime.AddDays(-1)}");
            Console.WriteLine($"next day: {dateTime.AddDays(1)}");
            Console.ReadKey();
        }
    }
}
*/