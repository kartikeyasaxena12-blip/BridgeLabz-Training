using System;
class RocketLaunch
{
    static void Main(string[]args)
    {
        int counter = Convert.ToInt32(Console.ReadLine()); //input
        for(int i=counter;i>=1;i--) //for loop
        {
            Console.WriteLine(i); //print
        }
    }
}