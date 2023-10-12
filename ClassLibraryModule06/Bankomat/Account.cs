using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Account
    {
        public int AccountNumber { get; }
        public double Balance { get; private set; }

        public Account(int accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Недопустимая сумма для пополнения.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
            }
        }
    }
}