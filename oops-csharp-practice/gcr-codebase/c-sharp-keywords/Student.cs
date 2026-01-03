using System;

class Student
{
    public static string UniversityName = "Global University";
    private static int totalStudents = 0;

    // readonly variable
    public readonly int RollNumber;

    public string Name;
    public string Grade;

    // Constructor
    public Student(string Name, int RollNumber, string Grade)
    {
        this.Name = Name;
        this.RollNumber = RollNumber;
        this.Grade = Grade;

        totalStudents++;
    }

    //method to display total students
    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students Enrolled: " + totalStudents);
    }

    // method to display student details
    public void DisplayDetails(object obj)
    {
        if (obj is Student)
        {
            Console.WriteLine("University: " + UniversityName);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Roll Number: " + RollNumber);
            Console.WriteLine("Grade: " + Grade);
        }
        else
        {
            Console.WriteLine("Object is not a Student");
        }
    }

    // method to update grade
    public void UpdateGrade(object obj, string newGrade)
    {
        if (obj is Student)
        {
            this.Grade = newGrade;
            Console.WriteLine("Grade updated for " + Name + " to " + Grade);
        }
        else
        {
            Console.WriteLine("Cannot update: Object is not a Student");
        }
    }

    // Main method
    static void Main()
    {
        Student s1 = new Student("Rahul", 101, "A");
        Student s2 = new Student("Anita", 102, "B");

        s1.DisplayDetails(s1);
        Console.WriteLine();

        s2.DisplayDetails(s2);
        Console.WriteLine();

        Student.DisplayTotalStudents();
        Console.WriteLine();

        s2.UpdateGrade(s2, "A+");
        Console.WriteLine();

        s2.DisplayDetails(s2);

        Console.ReadLine();
    }
}
