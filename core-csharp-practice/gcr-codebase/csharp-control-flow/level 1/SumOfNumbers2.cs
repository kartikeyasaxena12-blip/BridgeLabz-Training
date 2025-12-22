using System;
class SumOfNumbers
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter a nmber");        
        double total=0.0; //to store sum
        while(true)
        {
            double number = Convert.ToDouble(Console.ReadLine()); //input number
            if(number<=0)
            {
                break;
            }
            total = total+number;
        }
        Console.WriteLine("Sum of Numbers = "+total);
    }
}