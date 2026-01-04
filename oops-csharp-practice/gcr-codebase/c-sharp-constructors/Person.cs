using System;

class Person
{
    string name;
    int age;

    // Parameterized constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Copy constructor
    public Person(Person other)
    {
        this.name = other.name;
        this.age = other.age;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age : " + age);
    }
}

class Program
{
    static void Main()
    {
        // Original object
        Person p1 = new Person("Amit", 25);
        p1.Display();

        Console.WriteLine();

        // copy constructor
        Person p2 = new Person(p1);
        p2.Display();
    }
}
