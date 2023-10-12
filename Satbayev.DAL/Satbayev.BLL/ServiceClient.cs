﻿using Satbayev.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.BLL
{
    public class ServiceClient
    {
        public string Path {  get; set; }
        public ServiceClient(string Path) {
            this.Path = Path;
        }
        public void Registration(Client client)
        {
            repositoryClient reposity = new repositoryClient(Path);
            bool result = reposity.CreateClient(client);
        }
        public Client Auth(string login, string password)
        {
            repositoryClient reposity = new repositoryClient(Path);
            Client client = reposity.GetClient(login, password);
            return client;
        }
    }
}
