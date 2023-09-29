using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice13
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = n / 1000;
            int n2 = n / 100 % 10;
            int n3 = n % 100 / 10;
            int n4 = n % 100 % 10;
            Console.WriteLine(n1 + n2 + n3 + n4);
            Console.WriteLine(n2 * n1 * n3 * n4);


            Console.ReadKey();
        }
    }
}
