using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice5
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = n / 10;
            int n2 = n % 10;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine("сумма его цифр " + (n1 + n2));
            Console.WriteLine("произведение его цифр " + n1 * n2);
            Console.ReadKey();
        }
    }
}
