using System;
class Bonus
{
    static void Main(string[]args)
    {
        double salary= Convert.ToDouble(Console.ReadLine()); //input salary
        double years= Convert.ToDouble(Console.ReadLine()); //input year of service
        double bonus=0;

        if(years>5)
        {
            bonus= 0.05*salary; // calculating bonus
            Console.WriteLine("Bonus = "+bonus);
        }
        else{
            Console.WriteLine("Year of service is not more than 5");
        }
    }
}
        