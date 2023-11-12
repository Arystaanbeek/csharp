using System;
using System.Collections.Generic;

interface IPart
{
    void Build();
}

interface IWorker
{
    void Work(House house);
}

class Basement : IPart
{
    public void Build()
    {
        Console.WriteLine("Foundation built");
    }
}

class Wall : IPart
{
    public void Build()
    {
        Console.WriteLine("Wall built");
    }
}

class Door : IPart
{
    public void Build()
    {
        Console.WriteLine("Door built");
    }
}

class Window : IPart
{
    public void Build()
    {
        Console.WriteLine("Window built");
    }
}

class Roof : IPart
{
    public void Build()
    {
        Console.WriteLine("Roof built");
    }
}

class House
{
    private List<IPart> parts = new List<IPart>();

    public List<IPart> Parts
    {
        get { return parts; }
    }

    public void AddPart(IPart part)
    {
        parts.Add(part);
    }

    public void Show()
    {
        Console.WriteLine("House built. Consists of:");
        foreach (var part in parts)
        {
            part.Build();
        }
    }
}

class TeamLeader : IWorker
{
    public void Work(House house)
    {
        Console.WriteLine("Team leader: Checking the construction progress");
    }
}

class Worker : IWorker
{
    public void Work(House house)
    {
        foreach (var part in house.Parts)
        {
            part.Build();
        }
    }
}

class Team
{
    private List<IWorker> workers = new List<IWorker>();

    public void AddWorker(IWorker worker)
    {
        workers.Add(worker);
    }

    public void Work(House house)
    {
        Console.WriteLine("Team starts working:");

        foreach (var worker in workers)
        {
            worker.Work(house);
        }

        Console.WriteLine("House construction completed.");
    }
}

class Program
{
    static void Main()
    {
        House house = new House();
        house.AddPart(new Basement());
        house.AddPart(new Wall());
        house.AddPart(new Wall());
        house.AddPart(new Wall());
        house.AddPart(new Wall());
        house.AddPart(new Door());
        house.AddPart(new Window());
        house.AddPart(new Window());
        house.AddPart(new Window());
        house.AddPart(new Window());
        house.AddPart(new Roof());

        Team team = new Team();
        team.AddWorker(new Worker());
        team.AddWorker(new Worker());
        team.AddWorker(new Worker());
        team.AddWorker(new Worker());
        team.AddWorker(new TeamLeader());

        team.Work(house);

        house.Show();

        Console.ReadLine();
    }
}
