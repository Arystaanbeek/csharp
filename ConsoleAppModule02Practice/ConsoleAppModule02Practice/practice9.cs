using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice9
    {
        static void Main(string[] args)
        {
        
            Console.Write("first volume: ");
            double firstVolume = double.Parse(Console.ReadLine());
            Console.Write("first weight: ");
            double firstWeight = double.Parse(Console.ReadLine());
            Console.Write("second volume: ");
            double secondVolume = double.Parse(Console.ReadLine());
            Console.Write("second weight: ");
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
