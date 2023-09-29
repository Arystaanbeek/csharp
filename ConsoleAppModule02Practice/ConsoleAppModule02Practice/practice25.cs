using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice25
    {
        static int f(int M, int N)
        {
            int sum = 0;
            for (int i = M; i <= N; i++)
            {
                if (i % 2 != 0)
                {
                    sum++;
                }
            }

            return sum;
        }
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());

            int N = int.Parse(Console.ReadLine());

            int sumOdd = f(M, N);
            Console.WriteLine($"The smallest number greater than or equal to {M} that is completely divisible by {N} is equal to {sumOdd} ");
            Console.ReadKey();
        }
    }
}
