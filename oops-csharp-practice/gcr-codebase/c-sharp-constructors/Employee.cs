using System;

// Base class
class Employee
{
    public int employeeID;
    protected string department;
    private double salary;

    // Constructor
    public Employee(int employeeID, string department, double salary)
    {
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }

    // method to modify salary
    public void SetSalary(double salary)
    {
        if (salary > 0)
            this.salary = salary;
    }

    public double GetSalary()
    {
        return salary;
    }

    public void DisplayEmployee()
    {
        Console.WriteLine("Employee ID : " + employeeID);
        Console.WriteLine("Department  : " + department);
        Console.WriteLine("Salary      : " + salary);
    }
}

// Subclass
class Manager : Employee
{
    string role;

    public Manager(int employeeID, string department, double salary, string role)
        : base(employeeID, department, salary)
    {
        this.role = role;
    }

    public void DisplayManager()
    {
        Console.WriteLine("Employee ID : " + employeeID);
        Console.WriteLine("Department  : " + department);

        Console.WriteLine("Salary      : " + GetSalary());
        Console.WriteLine("Role        : " + role);
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Employee(1001, "IT", 45000);
        e1.DisplayEmployee();

        Console.WriteLine();

        // Modify salary
        e1.SetSalary(50000);
        Console.WriteLine("Updated Salary: " + e1.GetSalary());

        Console.WriteLine();

        Manager m1 = new Manager(2001, "HR", 70000, "Team Lead");
        m1.DisplayManager();
    }
}
