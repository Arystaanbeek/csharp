using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a:");
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
            Console.Write("b:");
            Console.ReadKey();
            Console.Write("Enter a number (more than 10): ");
            int firstNumber = int.Parse(Console.ReadLine());
            for (int i = 10; i <= firstNumber; i++)
            {
                Console.WriteLine($"{Math.Pow(i, 2)}");
            }
            Console.Write("c:");
            Console.ReadKey();
            Console.Write("Enter a number (less than 10): ");
            int secondNum = int.Parse(Console.ReadLine());
            for (int i = secondNum; i <= 50; i++)
            {
                Console.WriteLine($"{Math.Pow(i, 3)}");
            }
            Console.Write("d:");
            Console.ReadKey();
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
