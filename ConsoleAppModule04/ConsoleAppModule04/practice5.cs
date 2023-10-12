using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule04
{
    internal class practice5
    {
        class Train
        {
            public int TrainNumber { get; set; }
            public string DepartureStation { get; set; }
            public string DestinationStation { get; set; }
            public DateTime DepartureTime { get; set; }
            public decimal Price { get; set; }

            public Train(int trainNumber, string departureStation, string destinationStation, DateTime departureTime, decimal price)
            {
                TrainNumber = trainNumber;
                DepartureStation = departureStation;
                DestinationStation = destinationStation;
                DepartureTime = departureTime;
                Price = price;
            }

            public override string ToString()
            {
                return $"Поезд №{TrainNumber}: {DepartureStation} -> {DestinationStation}, " +
                    $"Время отправления: {DepartureTime}, Цена: {Price} тг.";

            }
        }

        class Passenger
        {
            public string Name { get; set; }
            public string DestinationStation { get; set; }
            public DateTime DepartureDateTime { get; set; }
            public Train SelectedTrain { get; set; }

            public Passenger(string name, string destinationStation, DateTime departureDateTime)
            {
                Name = name;
                DestinationStation = destinationStation;
                DepartureDateTime = departureDateTime;
            }

            public void SearchTrain(List<Train> trains)
            {
                foreach (var train in trains)
                {
                    if (train.DestinationStation == DestinationStation && train.DepartureTime >= DepartureDateTime)
                    {
                        Console.WriteLine($"Найден подходящий поезд для {Name}:\n{train}");
                        SelectedTrain = train;
                        return;
                    }
                }
                Console.WriteLine($"Для {Name} не найдено подходящего поезда.");
            }

            public void GenerateInvoice()
            {
                if (SelectedTrain != null)
                {
                    Console.WriteLine($"Счет на оплату для {Name}:\n{SelectedTrain.Price} тг.");
                }
                else
                {
                    Console.WriteLine($"{Name}, выберите подходящий поезд перед генерацией счета.");
                }
            }
        }

        class Cashier
        {
            public List<Train> EnterTrainsInfo()
            {
                List<Train> trains = new List<Train>();
                while (true)
                {
                    Console.WriteLine("Введите информацию о поезде (или 'готово' для завершения ввода):");
                    Console.Write("Номер поезда: ");
                    if (int.TryParse(Console.ReadLine(), out int trainNumber))
                    {
                        Console.Write("Станция отправления: ");
                        string departureStation = Console.ReadLine();
                        Console.Write("Станция назначения: ");
                        string destinationStation = Console.ReadLine();
                        Console.Write("Дата и время отправления (yyyy-MM-dd HH:mm): ");
                        if (DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime departureTime))
                        {
                            Console.Write("Цена билета: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal price))
                            {
                                trains.Add(new Train(trainNumber, departureStation, destinationStation, departureTime, price));
                            }
                            else
                            {
                                Console.WriteLine("Некорректная цена.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректная дата и время.");
                        }
                    }
                    else if (string.Equals(Console.ReadLine(), "готово", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный номер поезда.");
                    }
                }
                return trains;
            }
        }

        class Program
        {
            static void Main()
            {
                Cashier cashier = new Cashier();
                List<Train> availableTrains = cashier.EnterTrainsInfo();

                Console.Write(" имя пассажира: ");
                string passengerName = Console.ReadLine();
                Console.Write(" станцию назначения: ");
                string destinationStation = Console.ReadLine();
                Console.Write(" датa и время отправления : ");
                if (DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime departureTime))
                {
                    Passenger passenger = new Passenger(passengerName, destinationStation, departureTime);
                    passenger.SearchTrain(availableTrains);
                    passenger.GenerateInvoice();
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.ReadKey();
            }
        }

    }
}