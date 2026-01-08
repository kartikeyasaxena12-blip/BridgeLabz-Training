using System;

class Student
{
    public int RollNo;
    public string Name;
    public int Age;
    public char Grade;
    public Student next;

    public Student(int roll, string name, int age, char grade)
    {
        RollNo = roll;
        Name = name;
        Age = age;
        Grade = grade;
        next = null;
    }
}

class StudentLinkedList
{
    Student head;

    public void AddAtBeginning(int roll, string name, int age, char grade)
    {
        Student newNode = new Student(roll, name, age, grade);
        newNode.next = head;
        head = newNode;
    }

    public void AddAtEnd(int roll, string name, int age, char grade)
    {
        Student newNode = new Student(roll, name, age, grade);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Student temp = head;
        while (temp.next != null)
            temp = temp.next;

        temp.next = newNode;
    }

    public void AddAtPosition(int roll, string name, int age, char grade, int position)
    {
        if (position == 1)
        {
            AddAtBeginning(roll, name, age, grade);
            return;
        }

        Student newNode = new Student(roll, name, age, grade);
        Student temp = head;

        for (int i = 1; i < position - 1 && temp != null; i++)
            temp = temp.next;

        if (temp == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        newNode.next = temp.next;
        temp.next = newNode;
    }

    public void DeleteByRollNo(int roll)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        if (head.RollNo == roll)
        {
            head = head.next;
            Console.WriteLine("Student deleted");
            return;
        }

        Student temp = head;
        while (temp.next != null && temp.next.RollNo != roll)
            temp = temp.next;

        if (temp.next == null)
            Console.WriteLine("Student not found");
        else
        {
            temp.next = temp.next.next;
            Console.WriteLine("Student deleted");
        }
    }

    public void Search(int roll)
    {
        Student temp = head;

        while (temp != null)
        {
            if (temp.RollNo == roll)
            {
                Console.WriteLine("Roll: " + temp.RollNo +
                                  ", Name: " + temp.Name +
                                  ", Age: " + temp.Age +
                                  ", Grade: " + temp.Grade);
                return;
            }
            temp = temp.next;
        }

        Console.WriteLine("Student not found");
    }

    public void UpdateGrade(int roll, char newGrade)
    {
        Student temp = head;

        while (temp != null)
        {
            if (temp.RollNo == roll)
            {
                temp.Grade = newGrade;
                Console.WriteLine("Grade updated");
                return;
            }
            temp = temp.next;
        }

        Console.WriteLine("Student not found");
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No student records");
            return;
        }

        Student temp = head;
        while (temp != null)
        {
            Console.WriteLine("Roll: " + temp.RollNo +
                              ", Name: " + temp.Name +
                              ", Age: " + temp.Age +
                              ", Grade: " + temp.Grade);
            temp = temp.next;
        }
    }
}

class Program
{
    static void Main()
    {
        StudentLinkedList list = new StudentLinkedList();
        int choice;

        do
        {
            Console.WriteLine("\n--- Student Record Management ---");
            Console.WriteLine("1. Add at Beginning");
            Console.WriteLine("2. Add at End");
            Console.WriteLine("3. Add at Position");
            Console.WriteLine("4. Delete by Roll Number");
            Console.WriteLine("5. Search by Roll Number");
            Console.WriteLine("6. Display All");
            Console.WriteLine("7. Update Grade");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            int roll, age, pos;
            string name;
            char grade;

            switch (choice)
            {
                case 1:
                    Console.Write("Roll: ");
                    roll = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Grade: ");
                    grade = Convert.ToChar(Console.ReadLine());
                    list.AddAtBeginning(roll, name, age, grade);
                    break;

                case 2:
                    Console.Write("Roll: ");
                    roll = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Grade: ");
                    grade = Convert.ToChar(Console.ReadLine());
                    list.AddAtEnd(roll, name, age, grade);
                    break;

                case 3:
                    Console.Write("Position: ");
                    pos = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Roll: ");
                    roll = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Grade: ");
                    grade = Convert.ToChar(Console.ReadLine());
                    list.AddAtPosition(roll, name, age, grade, pos);
                    break;

                case 4:
                    Console.Write("Roll Number to delete: ");
                    roll = Convert.ToInt32(Console.ReadLine());
                    list.DeleteByRollNo(roll);
                    break;

                case 5:
                    Console.Write("Roll Number to search: ");
                    roll = Convert.ToInt32(Console.ReadLine());
                    list.Search(roll);
                    break;

                case 6:
                    list.Display();
                    break;

                case 7:
                    Console.Write("Roll Number: ");
                    roll = Convert.ToInt32(Console.ReadLine());
                    Console.Write("New Grade: ");
                    grade = Convert.ToChar(Console.ReadLine());
                    list.UpdateGrade(roll, grade);
                    break;
            }

        } while (choice != 0);
    }
}
