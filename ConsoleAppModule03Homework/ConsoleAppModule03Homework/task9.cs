/*using System;

class task9
{
    static void Main()
    {

        int[] arr = { 1, 2, 66, 4, 5 };
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine("enter index to remove: ");
        int indexToRemove = int.Parse(Console.ReadLine());
        if (indexToRemove >= 0 && indexToRemove < arr.Length)
        {
            int[] newArr = new int[arr.Length - 1];

            for (int i = 0; i < indexToRemove; i++)
            {
                newArr[i] = arr[i];
            }

            for (int i = indexToRemove + 1; i < arr.Length; i++)
            {
                newArr[i - 1] = arr[i];
            }

            arr = newArr;

            Console.WriteLine("Element deleted.");
        }
        else
        {
            Console.WriteLine("error");
        }

        Console.WriteLine("New array:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.ReadKey();

    }
}
*/