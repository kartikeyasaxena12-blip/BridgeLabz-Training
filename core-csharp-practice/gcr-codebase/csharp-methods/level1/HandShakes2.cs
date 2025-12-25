using System;
class HandshakeProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");//input
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;//calculating handshakes

        Console.WriteLine("The maximum number of possible handshakes is " + handshakes);//printing
    }
}
