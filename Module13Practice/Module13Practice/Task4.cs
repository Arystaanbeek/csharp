/*using System;
using System.Collections.Generic;
using System.IO;

class Employee
{
    public string FullName { get; set; }
    public decimal Salary { get; set; }

    public override string ToString()
    {
        return $"{FullName}, Salary: {Salary}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { FullName = "John Doe", Salary = 9000 },
            new Employee { FullName = "Jane Smith", Salary = 11000 },
            new Employee { FullName = "Mike Johnson", Salary = 9500 }
        };

        string filePath = @"D:\\myprojects\\internship\\csharp\\Module13Practice\\Module13Practice\\employees.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var employee in employees)
            {
                writer.WriteLine($"{employee.FullName}, {employee.Salary}");
            }
        }

        Console.WriteLine("Employees written to file.");
    }
}
*/