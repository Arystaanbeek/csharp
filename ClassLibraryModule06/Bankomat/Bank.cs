using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Bank
    {
        private List<Client> clients = new List<Client>();

        public Client OpenAccount(string name, string password)
        {
            int clientId = GenerateUniqueClientId();
            Client client = new Client(name, clientId, password);
            clients.Add(client);
            return client;
        }

        private int GenerateUniqueClientId()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }
    }
}