using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02
{
    internal class task9
    {
        static void Main(string[] args)
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
