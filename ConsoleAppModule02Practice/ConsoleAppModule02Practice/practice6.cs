using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice6
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;
            bool C = false;

            bool resultA = !A && B;
            bool resultB = A || !B;
            bool resultC = (A && B) || C;

            Console.WriteLine("не А и В: " + resultA);
            Console.WriteLine("А или не В: " + resultB);
            Console.WriteLine("А и В или С: " + resultC);
        }
    }
}
