using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice21
    {
        static int f(int m1, int m2, int m3)
        {
            if (m1 < m2 && m1 < m3)
            {
                return m1;
            }
            else if (m2 < m3 && m2 < m1)
            {
                return m2;
            }
            else if (m3 < m2 && m3 < m1)
            {
                return m3;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter numbers in the range from 1 to 999");
            Console.Write("Enter a first number: ");
            int m1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a first number: ");
            int m2 = int.Parse(Console.ReadLine());
            Console.Write("Enter a first number: ");
            int m3 = int.Parse(Console.ReadLine());

            int smallNum = f(m1, m2, m3);
            Console.WriteLine($"{smallNum}");
            Console.ReadKey();
        }
    }
}
