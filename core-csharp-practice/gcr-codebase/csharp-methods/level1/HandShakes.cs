using System;
class HandshakeProgram
{
    static int CalculateHandshakes(int n)//function to calculate handshakes
    {
        return (n * (n - 1)) / 2;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");//input
        int students = Convert.ToInt32(Console.ReadLine());

        int handshakes = CalculateHandshakes(students);
        Console.WriteLine("Maximum number of handshakes among " + students + " students is " + handshakes);//printing
    }
}
