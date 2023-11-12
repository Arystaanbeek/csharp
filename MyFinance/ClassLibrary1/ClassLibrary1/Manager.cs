using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanceManager.DAL
{
    public class Manager
    {
        private string Path = @"C:\Temp\FinanceManager.db";
        public Manager()
        {

        }

        /// <summary>
        /// Метод котрый создает Транзацию
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public bool CreateTransaction(Transaction transaction)
        {
            try
            {
                using (var db = new LiteDatabase(Path))
                {
                    var col = db.GetCollection<Transaction>("Transaction");
                    col.Insert(transaction);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public double CalculateBalance()
        {
            try
            {
                double totalIncome = 0;
                double totalExpense = 0;
                using (var db = new LiteDatabase(Path))
                {
                    var col = db.GetCollection<Transaction>("Transaction");
                    var transactions = col.FindAll();
                    foreach (var transaction in transactions)
                    {
                        if (transaction.TransactionType)
                            totalIncome += transaction.Amount;
                        else
                            totalExpense += transaction.Amount;
                    }
                }
                return totalIncome - totalExpense;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        //перенести в LIB
        public void ViewTransactionHistory()
        {
            using (var db = new LiteDatabase(Path))
            {
                var col = db.GetCollection<Transaction>("Transaction");
                var transactions = col.FindAll();
                foreach (Transaction transaction in transactions)
                {
                    Console.WriteLine(transaction.ToString());
                }
            }
        }

        public List<Transaction> GetListTransactions()
        {
            List<Transaction> list = null;
            using (var db = new LiteDatabase(Path))
            {
                var col = db.GetCollection<Transaction>("Transaction");
                var query = col.Query();

            }

            return list;
        }

        public ILiteQueryable<Transaction> GetTransactions()
        {
            ILiteQueryable<Transaction> list = null;
            using (var db = new LiteDatabase(Path))
            {
                var col = db.GetCollection<Transaction>("Transaction");
                list = col.Query();

            }

            return list;
        }


        public List<Transaction> FilterTransactions(DateTime? startDate, DateTime? endDate, string Category, out string message)
        {
            message = "";
            ILiteQueryable<Transaction> list = null;
            try
            {
                list = GetTransactions();

                if (startDate.HasValue)
                    list = list.Where(t => t.CreateDate >= startDate);

                if (endDate.HasValue)
                    list = list.Where(t => t.CreateDate <= endDate);

                if (!string.IsNullOrEmpty(Category))
                    list = list.Where(t => t.Category == Category);
            }
            catch (Exception ex)
            {
                message = ex.Message;
                ///TO DO write log exception
            }

            return list.ToList();
        }
    }
}
