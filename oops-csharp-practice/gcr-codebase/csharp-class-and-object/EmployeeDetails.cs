using System;

class EmployeeDetails
{
    // Attributes
    int id;
    string name;
    double salary;

    // Constructor
    public EmployeeDetails(int id, string name, double salary)
    {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }

    // Method to display details
    public void Display()
    {
        Console.WriteLine("Employee ID : " + id);
        Console.WriteLine("Employee Name : " + name);
        Console.WriteLine("Salary : " + salary);
    }

    // Main method
    static void Main(string[]args)
    {
        EmployeeDetails emp = new EmployeeDetails(1201, "Rohan", 55050);
        emp.Display();
    }
}
