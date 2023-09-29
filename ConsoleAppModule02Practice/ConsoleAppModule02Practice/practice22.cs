using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice22
    {
        static bool even(int n)
        {
            if (n % 2 == 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
          
            Console.Write("Enter a number: ");
            int Num = int.Parse(Console.ReadLine());
            bool numEven = even(Num);
            Console.WriteLine($"{numEven}");
            Console.ReadKey();
        }
    }
}
