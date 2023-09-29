using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice14
    {
        static void Main()
        {
            int number = 456;
            int secondDigit = number % 100 % 10;
            Console.WriteLine(secondDigit);
            Console.ReadKey();
        }
    }
}
