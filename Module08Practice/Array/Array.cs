using System;

public class RangeOfArray
{
    private int[] data;
    private int startIndex;

    public RangeOfArray(int startIndex, int endIndex)
    {
        if (startIndex > endIndex)
        {
            throw new ArgumentException("Start index cannot be greater than end index.");
        }

        this.startIndex = startIndex;
        int length = endIndex - startIndex + 1;
        this.data = new int[length];
    }

    public int this[int index]
    {
        get
        {
            int internalIndex = index - startIndex;
            if (internalIndex < 0 || internalIndex >= data.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            return data[internalIndex];
        }
        set
        {
            int internalIndex = index - startIndex;
            if (internalIndex < 0 || internalIndex >= data.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            data[internalIndex] = value;
        }
    }
}
