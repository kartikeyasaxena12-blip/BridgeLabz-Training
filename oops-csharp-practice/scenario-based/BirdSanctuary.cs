using System;

// creating interface 
interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

class Bird
{
    string bird_Name;
    //constructor for class bird
    public Bird(string name)
    {
        bird_Name = name;
    }

    //method to display bird name
    public void Display()
    {
        Console.WriteLine("Bird Name : "+bird_Name);
    }
}

// eagle class inheriting Bird and interface Iflyable
class Eagle : Bird, IFlyable
{
    public Eagle(string name) : base(name)
    {}

    public void Fly()
    {
        Console.WriteLine("Eagle can fly");
    }
}

class Sparrow : Bird, IFlyable
{
    public Sparrow(string name) : base(name)
    {}

    public void Fly()
    {
        Console.WriteLine("Sparrow can fly");
    }
}

class Duck : Bird, ISwimmable
{
    public Duck(string name) : base(name){} //constructor of child class calling constructor of parent class

    public void Swim()
    {
        Console.WriteLine("Duck can swim");
    }
}

class Penguin : Bird, ISwimmable
{
    public Penguin(string name) : base(name) {}

    public void Swim()
    {
        Console.WriteLine("Penguin can swim");
    }
}

class Seagull : Bird, IFlyable, ISwimmable
{
    public Seagull(string name) : base(name) {}

    public void Swim()
    {
        Console.WriteLine("Seagull can swim");
    }

    public void Fly()
    {
        Console.WriteLine("Seagull can fly");
    }
}

class Program
{
    // main method
    static void Main(string[]args)
    {
        // creating array to store birds name
        Bird[] birds = new Bird[5];
        birds[0]= new Eagle("Eagle");
        birds[1] = new Duck("Duck");
        birds[2] = new Sparrow("Sparrow");
        birds[3] = new Penguin("Penguin");
        birds[4] = new Seagull("Seagull");

        // for loop
        for(int i=0; i<birds.Length; i++)
        {
            Bird b = birds[i];
            b.Display();
            
            if(b is IFlyable)
            {
                ((IFlyable)b).Fly();
            }
            
            if(b is ISwimmable)
            {
                ((ISwimmable)b).Swim();
            }

            Console.WriteLine();
        }

    }
}