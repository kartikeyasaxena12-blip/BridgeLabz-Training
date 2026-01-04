using System;

class CarRental
{
    string customerName;
    string carModel;
    int rentalDays;
    double totalCost;

    // Default constructor
    public CarRental()
    {
        customerName = " ";
        carModel = " ";
        rentalDays = 1;
        CalculateCost();
    }

    // Parameterized constructor
    public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        CalculateCost();
    }

    // Method to calculate total cost
    void CalculateCost()
    {
        double ratePerDay;

        if (carModel == "Hatchback")
            ratePerDay = 1500;
        else if (carModel == "Sedan")
            ratePerDay = 2500;
        else if (carModel == "SUV")
            ratePerDay = 3500;
        else
            ratePerDay = 2000;

        totalCost = ratePerDay * rentalDays;
    }

    // Method to display rental details
    public void Display()
    {
        Console.WriteLine("Customer Name : " + customerName);
        Console.WriteLine("Car Model     : " + carModel);
        Console.WriteLine("Rental Days   : " + rentalDays);
        Console.WriteLine("Total Cost    : " + totalCost);
    }
}

class Program
{
    static void Main()
    {
        CarRental r1 = new CarRental();
        r1.Display();

        Console.WriteLine();

        CarRental r2 = new CarRental("XYZ", "SUV", 2);
        r2.Display();
    }
}
