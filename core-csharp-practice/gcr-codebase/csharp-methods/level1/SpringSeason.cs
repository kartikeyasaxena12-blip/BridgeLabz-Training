using System;
class SpringSeason
{
    static void CheckSpring(int month, int day)//to check spring
    {
        if ((month == 3 && day >= 20))
        {
            Console.WriteLine("Its a Spring Season");
        }
        else if((month == 4) ||(month == 5))
        {
            Console.WriteLine("Its a Spring Season");
        }
        else if(month == 6 && day <= 20)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }

    static void Main()
    {
        Console.Write("Enter month: ");//input
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter day: ");
        int day = Convert.ToInt32(Console.ReadLine());
        CheckSpring(month, day);//calling function
    }
}
