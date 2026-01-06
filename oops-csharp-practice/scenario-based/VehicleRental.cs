using System;

interface IRentable
{
    double CalculateRent(int days);
}

class Vehicle : IRentable // class vehicle implements Irentablde
{
    int vehicleId;
    string brand;
    double rentPerDay;
    
    public Vehicle(int id, string brand, double rent) // constructor of class vehicle
    {
        vehicleId = id;
        this.brand = brand;
        rentPerDay = rent;
    }

    public double CalculateRent(int days) // to calculate rent
    {
        return rentPerDay*days;
    }

    public void Display() // to display details
    {
        Console.WriteLine("Vehicle Id = "+vehicleId);
        Console.WriteLine("Brand = "+brand);
        Console.WriteLine("Rent Per Day "+rentPerDay);
    }
}

// bike inherits vehicle
class Bike : Vehicle
{
    public Bike(int id, string brand) : base( id, brand, 300){}
}

// car inherit vehicle
class Car : Vehicle
{
    public Car(int id, string brand) : base(id, brand, 600){}
}

// truck inherits vehicle
class Truck : Vehicle
{
    public Truck(int id, string brand) : base(id, brand, 1000){}
}

class Customer
{
    private string name;
    public Customer(string customerName)
    {
        name = customerName;
    }

    public void RentVehicle(Vehicle vehicle, int days)
    {
        Console.WriteLine();
        Console.WriteLine("Customer Name = "+name);
        vehicle.Display();
        Console.WriteLine("Total Days = "+days);
        Console.WriteLine("Rent = "+vehicle.CalculateRent(days));
    }
}

class Person
{
    // main method
    static void Main(string[]args)
    {
        // creating objects
        Customer obj = new Customer("Rohan");
        Customer obj1 = new Customer("Jon");
        Customer obj2 = new Customer("Tim");

        Vehicle bike = new Bike(101,"Honda");
        Vehicle car = new Car(102,"Maruti");
        Vehicle truck = new Truck(103,"Tata");

        obj.RentVehicle(bike, 5);
        obj1.RentVehicle(car, 3);
        obj2.RentVehicle(truck, 2);
    }
}

