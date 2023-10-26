using System;

class RangeOfArray
{
    private int lowerBound;
    private int upperBound;
    private int[] array;

    public RangeOfArray(int lower, int upper)
    {
        lowerBound = lower;
        upperBound = upper;
        int length = upper - lower + 1;
        array = new int[length];
    }

    public int this[int index]
    {
        get
        {
            if (IsIndexValid(index))
            {
                return array[index - lowerBound];
            }
            else
            {
                throw new IndexOutOfRangeException("Index outside the acceptable range");
            }
        }
        set
        {
            if (IsIndexValid(index))
            {
                array[index - lowerBound] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index outside the acceptable range");
            }
        }
    }

    private bool IsIndexValid(int index)
    {
        return index >= lowerBound && index <= upperBound;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int lowerBound = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int upperBound = int.Parse(Console.ReadLine());

        RangeOfArray array = new RangeOfArray(lowerBound, upperBound);

        for (int i = lowerBound; i <= upperBound; i++)
        {
            array[i] = i * 2;
        }

        for (int i = lowerBound; i <= upperBound; i++)
        {
            Console.WriteLine($"array[{i}] = {array[i]}");
        }
        Console.ReadKey();
    }
}
