using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            task3();
        }

        static void task1()
        {
            List<int> list = new List<int>();
            Random random = new Random();
            int max1 = 0;
            int x = 0;
            int max2 = 0;

            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(1, 5));
            }

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            for (int i = 0; i < 10; i++)
            {
                if (list.ElementAt(i) > max1)
                {
                    max1 = list.ElementAt(i);
                    x = i;
                }
            }

            list.RemoveAt(x);

            for (int i = 0; i < 10; i++)
            {
                if (list.ElementAt(i) > max2)
                {
                    max2 = list.ElementAt(i);
                }
            }

            Console.WriteLine(max1);
            Console.WriteLine(max2);

            Console.WriteLine("\n");

            for (int i = 0; i < 10; i++)
            {
                if (list.ElementAt(i) % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }
            foreach (int i in list)
            { Console.WriteLine(i); }

        }

        static void task2()
        {
            List<double> list = new List<double>();
            Random random = new Random();

            double sum = 0;
            double avarage = 0;

            for (int i = 0; i < 10; i++)
            {
                double d = (double)random.Next(1, 10) / random.Next(1, 10);
                list.Add(d);
            }

            foreach (double item in list)
            {
                Console.WriteLine(item);
            }

            foreach (double i in list)
            {
                sum += i;
            }

            Console.Write("Averege is: ");

            avarage = sum / list.Count;
            Console.WriteLine(avarage);

        }

        static void task3()
        {
            List<int> FirstList = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                FirstList.Add(random.Next(1, 10));
                Console.WriteLine(FirstList[i]);
            }

            List<int> SecondList = new List<int>();

            Console.WriteLine("Reverse: ");

            for (int i = FirstList.Count - 1; i >= 0; i--)
            {
                SecondList.Add(FirstList[i]);
            }

            foreach (int item in SecondList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
