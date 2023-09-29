/*using System;

class task6
{
    static void Main()
    {
        Random rnd = new Random();
        int[,] array = new int[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = rnd.Next(-100, 101);
            }
        }

        int minElement = array[0, 0];
        int maxElement = array[0, 0];
        int minRowIndex = 0;
        int minColIndex = 0;
        int maxRowIndex = 0;
        int maxColIndex = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minRowIndex = i;
                    minColIndex = j;
                }
                if (array[i, j] > maxElement)
                {
                    maxElement = array[i, j];
                    maxRowIndex = i;
                    maxColIndex = j;
                }
            }
        }

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

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"min element: {minElement}");
        Console.WriteLine($"max element: {maxElement}");
        Console.WriteLine($"sum: {sum}");
        Console.ReadKey();
    }
}
*/