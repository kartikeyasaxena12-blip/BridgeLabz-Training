using System;
class DayOfWeek{
    public static void Main(string[] args){
		//taking input
        Console.WriteLine("Enter month : ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter day : ");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter year : ");
        int year = Convert.ToInt32(Console.ReadLine());
		
		//calculating day of the week
        int y0 = year-(14-month)/12;
        int x = y0+y0/4-y0/100+y0/400;
        int m0 = month+12*((14-month)/12)-2;
        int d0 = (day+x+31*m0/12)%7;
        Console.WriteLine("Day of the week : " + d0);
    }
}