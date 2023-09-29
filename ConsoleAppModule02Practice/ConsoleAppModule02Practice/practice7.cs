using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice7
    {
        static void Main()
        {
            br


            int r = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            double s1 = Math.PI * Math.Pow(r, 2); // круга
            double s2 = Math.Pow(a, 2); // квадрат                                   
            if (s1 > s2)
            {
                Console.WriteLine("у круга больше " + s1);
            }
            else
            {
                Console.WriteLine("у квадрата больше " + s2);
            }
            Console.ReadKey();
        }
    }
}
