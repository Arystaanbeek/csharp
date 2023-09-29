using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice24
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int value = rnd.Next(2, 6);
            Console.WriteLine($"Value = {value}");

            switch (value)
            {
                case 2:
                    Console.WriteLine("So Bad");
                    break;
                case 3:
                    Console.WriteLine("Bad");
                    break;
                case 4:
                    Console.WriteLine("Nice");
                    break;
                case 5:
                    Console.WriteLine("Good");
                    break;
                default:
                    Console.WriteLine("You are lucky!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
