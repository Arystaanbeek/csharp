using System;

class Practice6
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

        Console.WriteLine("Array:");
        PrintArray(array);

        int minRowIndex = 0;
        int minColIndex = 0;
        int maxRowIndex = 0;
        int maxColIndex = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array[i, j] < array[minRowIndex, minColIndex])
                {
                    minRowIndex = i;
                    minColIndex = j;
                }
                if (array[i, j] > array[maxRowIndex, maxColIndex])
                {
                    maxRowIndex = i;
                    maxColIndex = j;
                }
            }
        }

        Console.WriteLine($"Minimal element: {array[minRowIndex, minColIndex]}");
        Console.WriteLine($"Maximal element: {array[maxRowIndex, maxColIndex]}");

        int sum = 0;
        int startRow = Math.Min(minRowIndex, maxRowIndex);
        int endRow = Math.Max(minRowIndex, maxRowIndex);
        int startCol = Math.Min(minColIndex, maxColIndex);
        int endCol = Math.Max(minColIndex, maxColIndex);

        for (int i = startRow; i <= endRow; i++)
        {
            for (int j = startCol; j <= endCol; j++)
            {
                sum += array[i, j];
            }
        }

        Console.WriteLine($"Sum min and max: {sum}");
        Console.ReadKey();
    }

    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
