using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// Employee class
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}

class EmployeeSerializationDemo
{
    static string filePath = "employees.json";

    static void Main()
    {
        // Create employee list
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Amit", Department = "IT" },
            new Employee { Id = 2, Name = "Neha", Department = "HR" },
            new Employee { Id = 3, Name = "Ravi", Department = "Finance" }
        };

        // Serialize
        SaveEmployees(employees);

        // Deserialize
        List<Employee> retrievedEmployees = LoadEmployees();

        // Display data
        Console.WriteLine("Employee Data from File:");
        foreach (var emp in retrievedEmployees)
        {
            Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Department}");
        }
    }

    // Save object to file
    static void SaveEmployees(List<Employee> employees)
    {
        string jsonData = JsonSerializer.Serialize(employees);
        File.WriteAllText(filePath, jsonData);
        Console.WriteLine("Employees saved successfully.\n");
    }

    // Load object from file
    static List<Employee> LoadEmployees()
    {
        string jsonData = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Employee>>(jsonData);
    }
}
