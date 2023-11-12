using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using FinanceManager.DAL;


namespace FinanceManager.LIB
{
    public class Service
    {
        private Manager manager=null;
        public Service()
        {
            manager = new Manager();
        }

        public string AddTransaction(Transaction transaction)
        {           
            bool result = manager.CreateTransaction(transaction);

            if (result)
                return "The transaction was successful!";
            else
                return "The transaction failed!";
        }
        public List<Transaction> GetTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();
            return transactions;
        }

        public List<Transaction> GetTransactionsByFilter(DateTime CreateDate, DateTime EndDate, string Category)
        {          
            List<Transaction> filteredTransactions = manager.FilterTransactions(CreateDate, EndDate, Category);
            return filteredTransactions;
        }
    }
}
