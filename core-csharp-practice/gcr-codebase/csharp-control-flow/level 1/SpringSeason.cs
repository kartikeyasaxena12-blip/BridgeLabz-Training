using System;
class SpringSeason
{
    static void Main(string[]args)
    {
        int month = Convert.ToInt32(Console.ReadLine()); //input month
        int day= Convert.ToInt32(Console.ReadLine()); //input day

        if((month==3 && day>=20)|| month==4 || month==5 || (month==6 && day<=20)) //checking condition
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}