using System;

class Student
{
    public int rollNumber;
    protected string name;
    private double cgpa;

    // Constructor
    public Student(int rollNumber, string name, double cgpa)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.cgpa = cgpa;
    }

    public double GetCGPA()
    {
        return cgpa;
    }

    public void SetCGPA(double cgpa)
    {
        this.cgpa = cgpa;
    }

    public void DisplayStudent()
    {
        Console.WriteLine("Roll Number : " + rollNumber);
        Console.WriteLine("Name        : " + name);
        Console.WriteLine("CGPA        : " + cgpa);
    }
}

// Subclass
class PostgraduateStudent : Student
{
    string specialization;

    public PostgraduateStudent(int rollNumber, string name, double cgpa, string specialization)
        : base(rollNumber, name, cgpa)
    {
        this.specialization = specialization;
    }

    public void DisplayPGStudent()
    {
        // Accessing protected member
        Console.WriteLine("Name            : " + name);
        Console.WriteLine("Specialization  : " + specialization);
        Console.WriteLine("CGPA            : " + GetCGPA());
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student(101, "Aman", 8.2);
        s1.DisplayStudent();

        Console.WriteLine();

        s1.SetCGPA(8.6);
        Console.WriteLine("Updated CGPA: " + s1.GetCGPA());

        Console.WriteLine();

        PostgraduateStudent pg = new PostgraduateStudent(201, "Neha", 9.1, "Computer Science");
        pg.DisplayPGStudent();
    }
}
