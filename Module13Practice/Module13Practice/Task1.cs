/*using System;
using System.Collections.Generic;
using System.Linq;

class Task1
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 10, 5, 20, 15, 30, 25 };

        int max = numbers.Max();
        int secondMax = numbers.Where(n => n != max).Max();

        int secondMaxIndex = numbers.LastIndexOf(secondMax);

        Console.WriteLine($"Position of second maximum value: {secondMaxIndex}, Value: {secondMax}");

        numbers.RemoveAll(n => n % 2 != 0);

        Console.WriteLine("List after removing odd numbers:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
*/