using System;

namespace ConsoleAppModule02Practice
{
    internal class Practice17
    {
        static void Main()
        {
            int a = 0;
            int b = 0;
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Swap(ref a, ref b, x, y);

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.ReadKey();
        }

        static void Swap(ref int a, ref int b, int x, int y)
        {
            a = x * y;
            b = x / y;
        }
    }
}
