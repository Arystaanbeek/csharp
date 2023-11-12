using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.DAL
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool Status { get; set; } = true;

        //Amount >= 0
        private bool _TransactionType
        {
            get
            {
                if (Amount >= 0) 
                    return true;
                else 
                    return false;
            }
        }
        public bool TransactionType { get; set; }
        public string Acccount { get; set; }

        public override string ToString()
        {
            string categoryInfo = this.Category != null ? this.Category : "No Category";
            string info = $"Date: {this.CreateDate}, Amount: {this.Amount}, Category: {categoryInfo}, Description: {this.Description}";

            return info;
        }
    }
}
