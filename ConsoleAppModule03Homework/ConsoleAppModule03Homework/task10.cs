/*using System;

class task10
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 3, 5, 6, 3 };
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("Enter value to remove: ");
        Console.WriteLine();
        int valueToRemove = int.Parse(Console.ReadLine());

        int[] newArr = new int[arr.Length];
        int newIndex = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != valueToRemove)
            {
                newArr[newIndex] = arr[i];
                newIndex++;
            }
        }

        Array.Resize(ref newArr, newIndex);

        arr = newArr;

        Console.WriteLine("removed");

        Console.WriteLine("New array:");
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.ReadKey();
    }
}
*/