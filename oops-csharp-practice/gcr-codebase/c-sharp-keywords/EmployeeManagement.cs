using System;

class EmployeeManagement
{
    public static string CompanyName = "XYZ Pvt Ltd";
    private static int totalEmployees = 0;

    // readonly variable (cannot be changed after assignment)
    public readonly int Id;

    public string Name;
    public string Designation;

    // Constructor
    public EmployeeManagement(string Name, int Id, string Designation)
    {
        this.Name = Name;
        this.Id = Id;
        this.Designation = Designation;

        totalEmployees++;
    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    // method to display employee details
    public void DisplayDetails(object obj)
    {
        if (obj is EmployeeManagement)
        {
            Console.WriteLine("Company Name: " + CompanyName);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee ID: " + Id);
            Console.WriteLine("Designation: " + Designation);
        }
        else
        {
            Console.WriteLine("Object is not an EmployeeManagement");
        }
    }
}

class Program
{
    static void Main()
    {
        EmployeeManagement e1 = new EmployeeManagement("Rahul", 201, "Software Engineer");
        EmployeeManagement e2 = new EmployeeManagement("Anita", 202, "Project Manager");

        e1.DisplayDetails(e1);
        Console.WriteLine();

        e2.DisplayDetails(e2);
        Console.WriteLine();

        EmployeeManagement.DisplayTotalEmployees();

        Console.ReadLine();
    }
}
