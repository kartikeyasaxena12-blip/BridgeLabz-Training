using System;

class HotelBooking
{
    string guestName;
    string roomType;
    int nights;

    // Default constructor
    public HotelBooking()
    {
        guestName = "NA ";
        roomType = "Standard";
        nights = 1;
    }

    // Parameterized constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    // Copy constructor
    public HotelBooking(HotelBooking other)
    {
        this.guestName = other.guestName;
        this.roomType = other.roomType;
        this.nights = other.nights;
    }

    public void Display()
    {
        Console.WriteLine("Guest Name : " + guestName);
        Console.WriteLine("Room Type  : " + roomType);
        Console.WriteLine("Nights     : " + nights);
    }
}

class Program
{
    static void Main()
    {
        // Default
        HotelBooking b1 = new HotelBooking();
        b1.Display();

        Console.WriteLine();

        // Parameterized
        HotelBooking b2 = new HotelBooking("Rahul", "Deluxe", 3);
        b2.Display();

        Console.WriteLine();

        // Copy
        HotelBooking b3 = new HotelBooking(b2);
        b3.Display();
    }
}
