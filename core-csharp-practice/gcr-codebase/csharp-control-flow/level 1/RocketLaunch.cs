using System;
class RocketLaunch
{
    static void Main(string[]args)
    {
        int counter = Convert.ToInt32(Console.ReadLine()); //input 

        while(counter>=1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }
}