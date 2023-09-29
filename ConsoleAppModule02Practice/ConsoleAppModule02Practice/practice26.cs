using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice26
    {
        static int f(int N, int n)
        {
            int result = N;

            while (result % n != 0)
            {
                result++;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            int smallestNumber = f(N, n);
            Console.WriteLine($"The smallest number greater than or equal to {N} that is completely divisible by {n} is equal to {smallestNumber} ");
            Console.ReadKey();
        }
    }
}
