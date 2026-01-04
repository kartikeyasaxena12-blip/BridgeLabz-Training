using System;

class Course
{
    // Instance variables
    string courseName;
    int duration;    
    double fee;

    static string instituteName = "GLA University";

    // Constructor
    public Course(string courseName, int duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine("Institute Name : " + instituteName);
        Console.WriteLine("Course Name    : " + courseName);
        Console.WriteLine("Duration       : " + duration + " weeks");
        Console.WriteLine("Course Fee     : " + fee);
    }

    public static void UpdateInstituteName(string newName)
    {
        instituteName = newName;
    }
}

class Program
{
    static void Main()
    {
        Course c1 = new Course("C# Programming", 6, 12000);
        Course c2 = new Course("Web Development", 8, 15000);

        c1.DisplayCourseDetails();
        Console.WriteLine();

        // Update institute name
        Course.UpdateInstituteName("XYZ Online Academy");

        c2.DisplayCourseDetails();
    }
}
