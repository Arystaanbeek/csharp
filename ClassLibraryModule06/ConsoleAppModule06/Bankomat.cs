using Bankomat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule06
{
    internal class bankomat
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Client client = bank.OpenAccount("User User", "1234");

            int attempts = 3;
            while (attempts > 0)
            {
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();

                if (client.CheckPassword(password))
                {
                    ShowMenu(client);
                    break;
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Неверный пароль. Осталось попыток: {attempts}");
                }
            }

            if (attempts == 0)
            {
                Console.WriteLine("Исчерпаны попытки ввода пароля. Программа завершается.");
            }

            Console.ReadKey();
        }

        static void ShowMenu(Client client)
        {
            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("a. Вывод баланса");
                Console.WriteLine("b. Пополнение счета");
                Console.WriteLine("c. Снять деньги");
                Console.WriteLine("d. Выход");

                Console.Write("Выберите действие: ");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (choice)
                {
                    case 'a':
                        Console.WriteLine($"Баланс на счете: {client.BankAccount.Balance}");
                        break;

                    case 'b':
                        Console.Write("Введите сумму для пополнения: ");
                        double depositAmount = Double.Parse(Console.ReadLine());
                        client.BankAccount.Deposit(depositAmount);
                        Console.WriteLine($"Счет пополнен на {depositAmount}");
                        break;

                    case 'c':
                        Console.Write("Введите сумму для снятия: ");
                        double withdrawAmount = Double.Parse(Console.ReadLine());
                        if (client.BankAccount.Balance >= withdrawAmount)
                        {
                            client.BankAccount.Withdraw(withdrawAmount);
                            Console.WriteLine($"Со счета снято {withdrawAmount}");
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств на счете.");
                        }
                        break;

                    case 'd':
                        Console.WriteLine("Выход из программы.");
                        return;

                    default:
                        Console.WriteLine("Некорректный выбор.");
                        break;
                }
            }
        }




    }
}