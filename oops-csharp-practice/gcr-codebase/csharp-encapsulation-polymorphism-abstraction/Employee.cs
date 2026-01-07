using System;

// Interface
interface IDepartment
{
    void AssignDepartment(string deptName);
    string GetDepartmentDetails();
}

abstract class Employee : IDepartment
{
    protected int employeeId;
    protected string name;
    protected double baseSalary;
    protected string department;

    // Constructor
    public Employee(int id, string name, double salary)
    {
        employeeId = id;
        this.name = name;
        baseSalary = salary;
    }

    // Abstract method
    public abstract double CalculateSalary();

    // Concrete method
    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID : " + employeeId);
        Console.WriteLine("Name        : " + name);
        Console.WriteLine("Department  : " + department);
        Console.WriteLine("Salary      : " + CalculateSalary());
        Console.WriteLine("---------------------------");
    }

    // Interface methods
    public void AssignDepartment(string deptName)
    {
        department = deptName;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}

class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int id, string name, double salary)
        : base(id, name, salary)
    {
    }

    public override double CalculateSalary()
    {
        return baseSalary; // fixed salary
    }
}

class PartTimeEmployee : Employee
{
    private int hoursWorked;
    private double ratePerHour;

    public PartTimeEmployee(int id, string name, int hours, double rate)
        : base(id, name, 0)
    {
        hoursWorked = hours;
        ratePerHour = rate;
    }

    public override double CalculateSalary()
    {
        return hoursWorked * ratePerHour;
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Employee emp1 = new FullTimeEmployee(101, "Amit", 50000);
        Employee emp2 = new PartTimeEmployee(102, "Riya", 80, 300);

        emp1.AssignDepartment("HR");
        emp2.AssignDepartment("IT");

        Employee[] employees = { emp1, emp2 };

        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
        }
    }
}
