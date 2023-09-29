/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule03Practice
{
    internal class practice10
    {
        static void Main()
        {
            int[,] array = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(-100, 101);
                }
            }


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[] minIndex = FindMinIndex(array);
            int[] maxIndex = FindMaxIndex(array);


            if (minIndex != null && maxIndex != null)
            {
                int sum = Sum(array, minIndex, maxIndex);

                Console.WriteLine($"Sum: {sum}");
            }
            else
            {
                Console.WriteLine("error");
            }

            Console.ReadKey();
        }


        static int[] FindMinIndex(int[,] array)
        {
            int min = array[0, 0];
            int[] minIndex = { 0, 0 };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minIndex[0] = i;
                        minIndex[1] = j;
                    }
                }
            }

            return minIndex;
        }

        static int[] FindMaxIndex(int[,] array)
        {
            int max = array[0, 0];
            int[] maxIndex = { 0, 0 };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxIndex[0] = i;
                        maxIndex[1] = j;
                    }
                }
            }

            return maxIndex;
        }

        static int Sum(int[,] array, int[] minIndex, int[] maxIndex)
        {
            int sum = 0;

            for (int i = Math.Min(minIndex[0], maxIndex[0]) + 1; i < Math.Max(minIndex[0], maxIndex[0]); i++)
            {
                for (int j = Math.Min(minIndex[1], maxIndex[1]) + 1; j < Math.Max(minIndex[1], maxIndex[1]); j++)
                {
                    sum += array[i, j];
                }
            }

            return sum;
        }
    }
}
*/