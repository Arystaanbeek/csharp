using System;

class Employee
{
    protected string name;
    protected int age;
    protected double salary;

    public Employee(string name, int age, double salary)
    {
        this.name = name;
        this.age = age;
        this.salary = salary;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}");
    }

    public virtual double CalculateAnnualSalary()
    {
        return salary * 12;
    }
}

class Manager : Employee
{
    private double bonus;

    public Manager(string name, int age, double salary, double bonus) : base(name, age, salary)
    {
        this.bonus = bonus;
    }

    public override void GetInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}, Bonus: {bonus}");
    }

    public override double CalculateAnnualSalary()
    {
        return base.CalculateAnnualSalary() + bonus;
    }
}

class Developer : Employee
{
    private int linesOfCodePerDay;

    public Developer(string name, int age, double salary, int linesOfCodePerDay) : base(name, age, salary)
    {
        this.linesOfCodePerDay = linesOfCodePerDay;
    }

    public override void GetInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}, Lines of Code per Day: {linesOfCodePerDay}");
    }

    public override double CalculateAnnualSalary()
    {
        double extraPayPerDay = linesOfCodePerDay * 1.5;
        double yearlyExtraPay = extraPayPerDay * 365; 
        return base.CalculateAnnualSalary() + yearlyExtraPay;
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager("Arystanbek Mukhammed", 20, 500000, 5000);
        Developer developer = new Developer("Tolegenov Islam", 19, 450000, 1000);

        Console.WriteLine("Info:");
        manager.GetInfo();
        Console.WriteLine($"Salary: {manager.CalculateAnnualSalary()}");
        Console.WriteLine();

        Console.WriteLine("Info:");
        developer.GetInfo();
        Console.WriteLine($"Salary: {developer.CalculateAnnualSalary()}");
    }
}
