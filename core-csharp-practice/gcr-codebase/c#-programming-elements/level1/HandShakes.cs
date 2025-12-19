using System;
class HandShakes
{
    static void Main(string[]args)
    {
        int number_Students= Convert.ToInt32(Console.ReadLine());
        int handShakes= (number_Students*(number_Students-1))/2;
        Console.WriteLine("The maximum number of possible handshakes is "+handShakes);
    }
}