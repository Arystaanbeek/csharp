using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice8
    {
        static void Main(string[] args)
        {
            
            double firstVolume = double.Parse(Console.ReadLine());
            double firstWeight = double.Parse(Console.ReadLine());
            double secondVolume = double.Parse(Console.ReadLine());
            double secondWeight = double.Parse(Console.ReadLine());
            if (firstVolume * firstWeight > secondVolume * secondWeight)
            {
                Console.WriteLine("The density of the first object is greater than the second");
            }
            else if (firstVolume * firstWeight < secondVolume * secondWeight)
            {
                Console.WriteLine("The density of the second object is greater than the first");
            }
            else
            {
                Console.WriteLine("first density = second density");
            }
            Console.ReadKey();
        }
    }
}
