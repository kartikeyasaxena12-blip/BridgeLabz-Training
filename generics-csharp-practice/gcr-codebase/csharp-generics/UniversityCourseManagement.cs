using System;
using System.Collections.Generic;

//Abstract base class
abstract class CourseType
{
    public string CourseName { get; set; }

    public CourseType(string name)
    {
        CourseName = name;
    }

    public abstract void Evaluate();
}

//Exam-based course
class ExamCourse : CourseType
{
    public ExamCourse(string name) : base(name) { }

    public override void Evaluate()
    {
        Console.WriteLine(CourseName + " is evaluated by written exams.");
    }
}

//Assignment-based course
class AssignmentCourse : CourseType
{
    public AssignmentCourse(string name) : base(name) { }

    public override void Evaluate()
    {
        Console.WriteLine(CourseName + " is evaluated by assignments.");
    }
}

//Generic course manager with constraint
class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();

    public void AddCourse(T course)
    {
        courses.Add(course);
    }

    public void DisplayCourses()
    {
        foreach (T course in courses)
        {
            Console.WriteLine("Course: " + course.CourseName);
            course.Evaluate();
        }
    }
}

//Main class
class Program
{
    static void Main()
    {
        Course<ExamCourse> examCourses = new Course<ExamCourse>();
        examCourses.AddCourse(new ExamCourse("Mathematics"));
        examCourses.AddCourse(new ExamCourse("Physics"));

        Course<AssignmentCourse> assignmentCourses = new Course<AssignmentCourse>();
        assignmentCourses.AddCourse(new AssignmentCourse("Software Engineering"));
        assignmentCourses.AddCourse(new AssignmentCourse("Data Science"));

        Console.WriteLine("Exam Courses:");
        examCourses.DisplayCourses();

        Console.WriteLine("\nAssignment Courses:");
        assignmentCourses.DisplayCourses();

        Console.ReadLine();
    }
}
