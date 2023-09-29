/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleAppModule03
{
    internal class task14
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();

            int count = 0;

            foreach (char character in text)
            {
                if (char.IsDigit(character))
                {
                    count++;
                }
            }

            Console.WriteLine($"Number of digits: {count}");
            Console.ReadKey();
        }

    }
}
*/