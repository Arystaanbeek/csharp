/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int reverseNumber = ReverseNumber(n);
            Console.WriteLine(reverseNumber);
            Console.ReadLine();

        }
        static int ReverseNumber(int n)
        {
            int reverseNum = 0;
            while (n > 0)
            {
                int lastNum = n % 10;
                reverseNum = reverseNum * 10 + lastNum;
                n = n / 10;
            }
            return reverseNum;
        }
    }
}
*/