using System;
using System.Collections.Generic;

class Car
{
    public string Model { get; set; }
    public string LicensePlate { get; set; }
    public bool IsAvailable { get; set; } = true;

    public Car(string model, string licensePlate)
    {
        Model = model;
        LicensePlate = licensePlate;
    }
}

class Driver
{
    public string Name { get; set; }
    public bool IsAvailable { get; set; } = true;
    public bool NeedsRepair { get; set; } = false;

    public Driver(string name)
    {
        Name = name;
    }

    public void RequestRepair()
    {
        NeedsRepair = true;
        IsAvailable = false;
    }

    public void CompleteTrip()
    {
        NeedsRepair = false;
        IsAvailable = true;
    }
}

class Dispatcher
{
    public List<Driver> drivers;
    public List<Car> cars;

    public Dispatcher()
    {
        drivers = new List<Driver>();
        cars = new List<Car>();
    }

    public void AssignTrip(string driverName, string carModel)
    {
        Driver driver = drivers.Find(d => d.Name == driverName);
        Car car = cars.Find(c => c.Model == carModel);

        if (driver != null && car != null && driver.IsAvailable && car.IsAvailable)
        {
            Console.WriteLine($"Диспетчер распределяет рейс на {car.Model} для водителя {driver.Name}");
            driver.IsAvailable = false;
            car.IsAvailable = false;
        }
        else
        {
            Console.WriteLine("Не удалось назначить рейс. Проверьте доступность водителя и автомобиля.");
        }
    }

    public void SuspendDriver(string driverName)
    {
        Driver driver = drivers.Find(d => d.Name == driverName);

        if (driver != null)
        {
            Console.WriteLine($"Диспетчер отстраняет водителя {driver.Name} от работы.");
            driver.IsAvailable = false;
        }
        else
        {
            Console.WriteLine($"Водитель с именем {driverName} не найден.");
        }
    }

    public void DisplayDriversStatus()
    {
        Console.WriteLine("Список водителей и их состояние:");
        foreach (var driver in drivers)
        {
            Console.WriteLine($"{driver.Name}: {(driver.IsAvailable ? "Доступен" : "Не доступен")}");
        }
    }
}

class practice4
{
    static void Main()
    {
        Dispatcher dispatcher = new Dispatcher();

        dispatcher.drivers.Add(new Driver("User1"));
        dispatcher.drivers.Add(new Driver("User2"));
        dispatcher.cars.Add(new Car("Toyota Camry", "А123АВ"));
        dispatcher.cars.Add(new Car("Ford Focus", "В456ВС"));
        dispatcher.AssignTrip("User1", "Toyota Camry");

        Driver ivan = dispatcher.drivers.Find(d => d.Name == "User1");
        ivan.RequestRepair();
        ivan.CompleteTrip();
        dispatcher.SuspendDriver("User2");
        dispatcher.DisplayDriversStatus();
        Console.ReadKey();
    }
}