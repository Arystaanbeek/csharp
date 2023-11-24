using System;
using System.Collections.Generic;

public class Client
{
    public string ID { get; }
    public string ServiceType { get; }

    public Client(string id, string serviceType)
    {
        ID = id;
        ServiceType = serviceType;
    }
}

public class BankQueue
{
    private readonly Queue<Client> queue = new Queue<Client>();

    public void Enqueue(Client client)
    {
        queue.Enqueue(client);
        DisplayQueueStatus();
    }

    public void ServiceNextClient()
    {
        if (queue.Count > 0)
        {
            Client nextClient = queue.Dequeue();
            Console.WriteLine($"Servicing client with ID: {nextClient.ID}");
            DisplayQueueStatus();
        }
        else
        {
            Console.WriteLine("No clients in the queue.");
        }
    }

    public void DisplayQueueStatus()
    {
        Console.WriteLine("Current Queue Status:");
        foreach (var client in queue)
        {
            Console.WriteLine($"Client ID: {client.ID}, Service: {client.ServiceType}");
        }
        Console.WriteLine("--------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankQueue bankQueue = new BankQueue();

        while (true)
        {
            Console.WriteLine("Enter client ID:");
            string id = Console.ReadLine();

            Console.WriteLine("Enter service type (e.g., loan, deposit, consultation):");
            string serviceType = Console.ReadLine();

            Client newClient = new Client(id, serviceType);
            bankQueue.Enqueue(newClient);

            Console.WriteLine("Do you want to service the next client? (Y/N)");
            string response = Console.ReadLine();

            if (response?.ToUpper() != "Y")
                break;

            bankQueue.ServiceNextClient();
        }
    }
}
