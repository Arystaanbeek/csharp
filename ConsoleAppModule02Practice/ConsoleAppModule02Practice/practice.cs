using System;

class Program
{
    static int CalculateSecondsPassed(int h, int m, int s)
    {
        if (h < 0 || h > 23 || m < 0 || m > 59 || s < 0 || s > 59)
        {
            throw new ArgumentException("error");
        }

        int secondsPassed = h * 3600 + m * 60 + s;
        return secondsPassed;
    }

    static void Main()
    {
        Console.WriteLine("Enter hours (0-23): ");
        int hours = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter minutes (0-59): ");
        int minutes = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter seconds (0-59): ");
        int seconds = int.Parse(Console.ReadLine());

        int totalSeconds = CalculateSecondsPassed(hours, minutes, seconds);
        Console.WriteLine($"Total seconds : {totalSeconds}");

        Console.ReadKey();
    }
}
