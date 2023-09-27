/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule02
{
    internal class task10
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string dayName = GetDayName(day);

            if (dayName != null)
            {
                Console.WriteLine(day + " - " + dayName);
            }
            Console.ReadKey();
        }

        static string GetDayName(int day)
        {
            switch (day)
            {
                case 1:
                    return "monday";
                case 2:
                    return "tuesday";
                case 3:
                    return "wednesday";
                case 4:
                    return "thursday";
                case 5:
                    return "friday";
                case 6:
                    return "saturday";
                case 7:
                    return "sunday";
                default:
                    return null;
            }
        }
    }
}
*/