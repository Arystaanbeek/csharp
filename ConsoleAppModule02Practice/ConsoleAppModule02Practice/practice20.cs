using System;

namespace ConsoleAppModule02Practice
{
    internal class practice20
    {
        public static int CalculateDaysPassed(int m, int d)
        {
            if (m < 1 || m > 12 || d < 1 || d > 31)
            {
                throw new ArgumentException("Error");
            }

            int daysPassed = 0;

            for (int month = 1; month < m; month++)
            {
                int daysInMonth = 30;
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    daysInMonth = 31;
                }
                else if (month == 2)
                {
                    daysInMonth = 28; // Assuming non-leap year
                }

                daysPassed += daysInMonth;
            }

            daysPassed += d;
            return daysPassed;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a month (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a day (1-31): ");
            int day = int.Parse(Console.ReadLine());

            int daysPassed = CalculateDaysPassed(month, day);
            Console.WriteLine($"{daysPassed} days have passed since the beginning of the year");

            Console.ReadKey();
        }
    }
}
