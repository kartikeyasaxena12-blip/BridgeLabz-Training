using System;

interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Abstract Vehicle class
abstract class Vehicle
{
    protected string vehicleNumber;
    protected string vehicleType;
    protected double rentalRate;

    private string insurancePolicyNumber;

    public void SetVehicleNumber(string number)
    {
        vehicleNumber = number;
    }

    public void SetVehicleType(string type)
    {
        vehicleType = type;
    }

    public void SetRentalRate(double rate)
    {
        rentalRate = rate;
    }

    public void SetInsurancePolicy(string policyNumber)
    {
        insurancePolicyNumber = policyNumber;
    }

    // Abstract method
    public abstract double CalculateRentalCost(int days);

    public void DisplayVehicle()
    {
        Console.WriteLine("Vehicle No : " + vehicleNumber);
        Console.WriteLine("Type       : " + vehicleType);
        Console.WriteLine("Rate/Day   : " + rentalRate);
    }
}

// Car class
class Car : Vehicle, IInsurable
{
    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public double CalculateInsurance()
    {
        return rentalRate * 0.15; 
    }

    public string GetInsuranceDetails()
    {
        return "Car Insurance: 15%";
    }
}

// Bike class
class Bike : Vehicle, IInsurable
{
    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public double CalculateInsurance()
    {
        return rentalRate * 0.08; // 8% insurance
    }

    public string GetInsuranceDetails()
    {
        return "Bike Insurance: 8%";
    }
}

// Truck class
class Truck : Vehicle, IInsurable
{
    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days + 500; 
    }

    public double CalculateInsurance()
    {
        return rentalRate * 0.20;
    }

    public string GetInsuranceDetails()
    {
        return "Truck Insurance: 20%";
    }
}

// Main Program
class Program
{
    static void PrintRentalDetails(Vehicle vehicle, int days)
    {
        double insuranceCost = 0;

        if (vehicle is IInsurable)
        {
            insuranceCost = ((IInsurable)vehicle).CalculateInsurance();
        }

        double rentalCost = vehicle.CalculateRentalCost(days);

        vehicle.DisplayVehicle();
        Console.WriteLine("Days Rented : " + days);
        Console.WriteLine("Rental Cost: " + rentalCost);
        Console.WriteLine("Insurance  : " + insuranceCost);
        Console.WriteLine("Total Cost : " + (rentalCost + insuranceCost));
        Console.WriteLine("------------------------------");
    }

    static void Main()
    {
        Vehicle v1 = new Car();
        v1.SetVehicleNumber("CAR101");
        v1.SetVehicleType("Car");
        v1.SetRentalRate(2000);
        v1.SetInsurancePolicy("CAR-IN-001");

        Vehicle v2 = new Bike();
        v2.SetVehicleNumber("BIKE202");
        v2.SetVehicleType("Bike");
        v2.SetRentalRate(500);
        v2.SetInsurancePolicy("BIKE-IN-002");

        Vehicle v3 = new Truck();
        v3.SetVehicleNumber("TRK303");
        v3.SetVehicleType("Truck");
        v3.SetRentalRate(4000);
        v3.SetInsurancePolicy("TRK-IN-003");

        Vehicle[] vehicles = { v1, v2, v3 };

        foreach (Vehicle v in vehicles)
        {
            PrintRentalDetails(v, 3); 
        }
    }
}
