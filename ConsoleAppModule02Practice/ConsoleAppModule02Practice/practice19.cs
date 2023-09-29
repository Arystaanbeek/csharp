using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02Practice
{
    internal class practice19
    {
        public static int CalculateDaysPassed(int m, int d)
{
    if (m < 1  m > 12  d < 1 || d > 31)
    {
        throw new ArgumentException("Error");
    }

    int daysPassed = 0;

    for (int month = 1; month < m; month++)
    {
        int daysInMonth = 30;

        daysPassed += daysInMonth;
    }

    daysPassed += d;
    return daysPassed;
}

static void Main(string[] args)
{
    Console.WriteLine("Enter a month (1-12): ");
    int month = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter a day (1-30): ");
    int day = int.Parse(Console.ReadLine());

    int daysPassed = CalculateDaysPassed(month, day);
    Console.WriteLine($"{daysPassed} days have passed since the beginning of the year");


    Console.ReadKey();
}
    }
}
