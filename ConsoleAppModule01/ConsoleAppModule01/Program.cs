using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string firstname = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string secondname = Console.ReadLine();
            Console.WriteLine($"Приветствую тебя {firstname} {secondname}");
        }
    }
}
