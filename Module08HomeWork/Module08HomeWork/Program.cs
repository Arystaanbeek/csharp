using System;

class ArrayWithSquaredIndexer
{
    private double[] array;

    public ArrayWithSquaredIndexer(int size)
    {
        array = new double[size];
    }
    public double this[int index]
    {
        get
        {
            return array[index];
        }
        set
        {
            array[index] = value * value;
        }
    }
}

class Program
{
    static void Main()
    {
        ArrayWithSquaredIndexer arr = new ArrayWithSquaredIndexer(5);

        arr[0] = 2;
        arr[1] = 3;
        arr[2] = 4;

        Console.WriteLine("Array values:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Index {i}: {arr[i]}");
        }
    }
}
