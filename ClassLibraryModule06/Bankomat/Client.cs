using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Client
    {
        public string Name { get; }
        public int ClientID { get; }
        public Account BankAccount { get; }
        public string Password { get; }

        public Client(string name, int clientID, string password)
        {
            Name = name;
            ClientID = clientID;
            Password = password;
            BankAccount = new Account(clientID);
        }

        public bool CheckPassword(string password)
        {
            return Password == password;
        }
    }
}