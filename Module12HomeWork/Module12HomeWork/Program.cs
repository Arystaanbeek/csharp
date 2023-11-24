using System;

public abstract class Car
{
    public string Name { get; set; }
    public int Speed { get; set; }
    public int Distance { get; set; }

    public event EventHandler Finish;

    public Car(string name, int speed)
    {
        Name = name;
        Speed = speed;
        Distance = 0;
    }

    public void Move()
    {
        Distance += Speed;
        if (Distance >= 100)
            OnFinish();
    }

    protected virtual void OnFinish()
    {
        Finish?.Invoke(this, EventArgs.Empty);
    }
}

public class SportsCar : Car
{
    public SportsCar(string name, int speed) : base(name, speed) { }
}

public class PassengerCar : Car
{
    public PassengerCar(string name, int speed) : base(name, speed) { }
}

public class Truck : Car
{
    public Truck(string name, int speed) : base(name, speed) { }
}

public class Bus : Car
{
    public Bus(string name, int speed) : base(name, speed) { }
}

public class RacingGame
{
    public delegate void RaceAction();

    public event EventHandler<string> WinnerAnnouncement;

    public void StartRace(Car[] cars)
    {
        RaceAction startDelegate = null;
        RaceAction raceDelegate = null;

        foreach (Car car in cars)
        {
            startDelegate += car.Move;
            car.Finish += OnCarFinish;
        }

        startDelegate?.Invoke();
        raceDelegate += startDelegate;

        while (!HasWinner(cars))
        {
            raceDelegate?.Invoke();
        }
    }

    private void OnCarFinish(object sender, EventArgs e)
    {
        if (sender is Car car)
        {
            WinnerAnnouncement?.Invoke(this, $"{car.Name} has finished the race!");
        }
    }

    private bool HasWinner(Car[] cars)
    {
        foreach (Car car in cars)
        {
            if (car.Distance >= 100)
                return true;
        }
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var sportsCar = new SportsCar("Ferrari", 10);
        var passengerCar = new PassengerCar("Toyota", 8);
        var truck = new Truck("Volvo", 5);
        var bus = new Bus("Mercedes", 6);

        var game = new RacingGame();
        game.WinnerAnnouncement += OnWinnerAnnouncement;
        game.StartRace(new Car[] { sportsCar, passengerCar, truck, bus });
    }

    private static void OnWinnerAnnouncement(object sender, string e)
    {
        Console.WriteLine($"Winner: {e}");
    }
}
