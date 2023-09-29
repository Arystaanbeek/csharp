/*using System;

class task2
{
    static int FindMaxElement(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("Array is empty");
        }

        int maxElement = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maxElement)
            {
                maxElement = i;
            }
        }

        return maxElement;
    }

    static void Main()
    {
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine()); ;
        }

        int maxEl = FindMaxElement(numbers);

        Console.WriteLine("Max Element index : " + maxEl);
        Console.ReadKey();
    }
}
*/