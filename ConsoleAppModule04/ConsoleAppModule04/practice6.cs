using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule04
{
    internal class practice6
    {
        class Client
        {
            public string Name { get; set; }
            public string AccountNumber { get; set; }
            public BankCard BankCard { get; set; }
            public BankAccount BankAccount { get; set; }

            public Client(string name, string accountNumber)
            {
                Name = name;
                AccountNumber = accountNumber;
                BankCard = new BankCard(this);
                BankAccount = new BankAccount(this);
            }

            public void MakePayment(decimal amount)
            {
                if (BankCard.IsBlocked)
                {
                    Console.WriteLine($"{Name}, ваша банковская карта заблокирована.");
                }
                else
                {
                    BankAccount.Withdraw(amount);
                    Console.WriteLine($"{Name}, заказ на сумму {amount} оплачен.");
                }
            }

            public void TransferFunds(decimal amount, BankAccount recipientAccount)
            {
                if (BankCard.IsBlocked)
                {
                    Console.WriteLine($"{Name}, ваша банковская карта заблокирована.");
                }
                else
                {
                    BankAccount.Withdraw(amount);
                    recipientAccount.Deposit(amount);
                    Console.WriteLine($"{Name}, переведено {amount} на счет {recipientAccount.Owner.Name}.");
                }
            }

            public void CancelAccount()
            {
                BankAccount.CloseAccount();
                Console.WriteLine($"{Name}, счет аннулирован.");
            }
        }

        class BankCard
        {
            public bool IsBlocked { get; private set; } = false;
            public Client Owner { get; }

            public BankCard(Client owner)
            {
                Owner = owner;
            }

            public void BlockCard()
            {
                IsBlocked = true;
                Console.WriteLine($"{Owner.Name}, ваша банковская карта заблокирована.");
            }
        }

        class BankAccount
        {
            public decimal Balance { get; private set; } = 0;
            public bool IsClosed { get; private set; } = false;
            public Client Owner { get; }

            public BankAccount(Client owner)
            {
                Owner = owner;
            }

            public void Deposit(decimal amount)
            {
                Balance += amount;
                Console.WriteLine($"{Owner.Name}, на счет поступило {amount}.");
            }

            public void Withdraw(decimal amount)
            {
                if (!IsClosed && Balance >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine($"{Owner.Name}, со счета списано {amount}.");
                }
                else
                {
                    Console.WriteLine($"{Owner.Name}, недостаточно средств на счете.");
                }
            }

            public void CloseAccount()
            {
                IsClosed = true;
                Balance = 0;
            }
        }

        class Administrator
        {
            public void BlockCardForExceedingPayment(Client client, decimal paymentLimit)
            {
                if (client.BankCard.IsBlocked)
                {
                    Console.WriteLine($"Карта клиента {client.Name} уже заблокирована.");
                }
                else if (client.BankAccount.Balance >= paymentLimit)
                {
                    Console.WriteLine($"Превышен лимит платежа для клиента {client.Name}. Блокируем карту.");
                    client.BankCard.BlockCard();
                }
            }
        }

        class Program
        {
            static void Main()
            {
                Client client1 = new Client("User1", "1234567890");
                Client client2 = new Client("User2", "0987654321");

                client1.BankAccount.Deposit(1000);
                client2.BankAccount.Deposit(500);

                Administrator admin = new Administrator();
                admin.BlockCardForExceedingPayment(client1, 900);

                client1.MakePayment(800);
                client2.TransferFunds(200, client1.BankAccount);

                client1.CancelAccount();
                client2.BankCard.BlockCard();

                Console.ReadKey();
            }

        }

    }
}