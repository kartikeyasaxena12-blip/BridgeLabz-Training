using System;
class Vehicle
{
    public static double RegistrationFee = 500.0;

    // readonly variable 
    public readonly string RegistrationNumber;

    public string OwnerName;
    public string VehicleType;

    // Constructor
    public Vehicle(string OwnerName, string VehicleType, string RegistrationNumber)
    {
        this.OwnerName = OwnerName;
        this.VehicleType = VehicleType;
        this.RegistrationNumber = RegistrationNumber;
    }

    // static method to update registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
        Console.WriteLine("Updated Registration Fee: " + RegistrationFee);
    }

    // method to display vehicle details
    public void DisplayDetails(object obj)
    {
        if (obj is Vehicle)
        {
            Console.WriteLine("Owner Name: " + OwnerName);
            Console.WriteLine("Vehicle Type: " + VehicleType);
            Console.WriteLine("Registration Number: " + RegistrationNumber);
            Console.WriteLine("Registration Fee: " + RegistrationFee);
        }
        else
        {
            Console.WriteLine("Object is not a Vehicle");
        }
    }

    // Main method
    static void Main()
    {
        Vehicle v1 = new Vehicle("Rahul Sharma", "Car", "REG101");
        Vehicle v2 = new Vehicle("Anita Verma", "Motorbike", "REG102");

        Vehicle.UpdateRegistrationFee(750); // updating fee for all vehicles
        Console.WriteLine();

        v1.DisplayDetails(v1);
        Console.WriteLine();

        v2.DisplayDetails(v2);

        Console.ReadLine();
    }
}
