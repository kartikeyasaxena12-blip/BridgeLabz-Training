using System;

class Vehicle
{
    string ownerName;
    string vehicleType;

    static double registrationFee = 2000;

    // Constructor
    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner Name : " + ownerName);
        Console.WriteLine("Vehicle Type : " + vehicleType);
        Console.WriteLine("Registration Fee : " + registrationFee);
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }
}

class Program
{
    static void Main()
    {
        Vehicle v1 = new Vehicle("Ravi", "Two Wheeler");
        Vehicle v2 = new Vehicle("Neha", "Car");

        v1.DisplayVehicleDetails();
        Console.WriteLine();

        // Update registration fee for all vehicles
        Vehicle.UpdateRegistrationFee(2800);

        v2.DisplayVehicleDetails();
    }
}
