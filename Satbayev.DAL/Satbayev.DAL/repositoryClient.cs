using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.DAL
{
    public class repositoryClient
    {
        private string path;

        public repositoryClient(string path)
        {
            this.path = path;
        }
        public bool CreateClient(Client client)
        {
           
                using (var db = new LiteDatabase(path))
                {
                    var clients = db.GetCollection<Client>("Client");
                    clients.Insert(client);
                }
                return true;
            
            
            
        }
        public Client GetClient(string email, string password) 
        {
            try
            {
                using (var db = new LiteDatabase(path))
                {
                    return db.GetCollection<Client>("Client")
                        .FindAll().First(f => f.Email == email & f.Password == password);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public Client GetClient(int Id)
        {
            try
            {
                using (var db = new LiteDatabase(path))
                {
                    return db.GetCollection<Client>("Client")
                        .FindAll().First(f => f.Id == Id);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
