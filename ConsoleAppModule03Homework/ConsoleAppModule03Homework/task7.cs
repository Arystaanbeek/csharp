/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule03
{
    internal class task7
    {
        static void Main()
        {
            string text = Console.ReadLine();
            bool check = ContainsOneWord(text);
            if (check)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadKey();
        }

        static bool ContainsOneWord(string text)
        {

            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);


            foreach (string word in words)
            {
                if (word.Equals("one", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
*/