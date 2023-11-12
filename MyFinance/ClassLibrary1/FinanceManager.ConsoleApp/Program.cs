using System;
using System.Collections.Generic;
using FinanceManager.LIB;
using FinanceManager.DAL;

namespace FinanceManager.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            Manager manager = new Manager();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add a transaction");
                Console.WriteLine("2. View transaction history");
                Console.WriteLine("3. Calculate balance");
                Console.WriteLine("4. Filter transactions");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Amount: ");
                        if (double.TryParse(Console.ReadLine(), out double amount))
                        {
                            Transaction transaction = new Transaction
                            {
                                Amount = amount,
                                TransactionType = true,
                            };


                            Console.Write("Description: ");
                            transaction.Description = Console.ReadLine();

                            Console.Write("Category: ");
                            transaction.Category = Console.ReadLine();

                            string result = service.AddTransaction(transaction);
                            Console.WriteLine(result);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for Amount. Please enter a valid number.");
                        }
                        break;

                    case "2":

                        manager.ViewTransactionHistory();

                        break;

                    case "3":

                        double balance = manager.CalculateBalance();
                        Console.WriteLine($"Balance: {balance}");

                        break;

                    case "4":

                        Console.Write("Start Date (yyyy-MM-dd): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime startDate))
                        {
                            Console.Write("End Date (yyyy-MM-dd): ");
                            if (DateTime.TryParse(Console.ReadLine(), out DateTime endDate))
                            {
                                Console.Write("Category: ");
                                string Category = Console.ReadLine();
                                if (!string.IsNullOrEmpty(Category))
                                {
                                    List<Transaction> filteredTransactions = service.GetTransactionsByFilter(startDate, endDate, Category);

                                    ///todo to string
                                    foreach (var transaction in filteredTransactions)
                                    {
                                        Console.WriteLine($"Date: {transaction.CreateDate}, Amount: {transaction.Amount}, Category: {transaction.Category}, Description: {transaction.Description}");
                                    }

                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input for Category. Please enter a valid category.");

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for End Date. Please enter a valid date in yyyy-MM-dd format.");

                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for Start Date. Please enter a valid date in yyyy-MM-dd format.");

                        }
                        break;

                    case "5":

                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
