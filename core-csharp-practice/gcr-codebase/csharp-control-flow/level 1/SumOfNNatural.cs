using System;
class SumOfNNatural
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter a nmber"); 
        int num= Convert.ToInt32(Console.ReadLine()); //input number
        int total=0; // sum of numbers using while loop
        int temp=num;
        while(num>0)
        {
            total= total+num;
            num--;
        }
        int totalN= (temp*(temp+1))/2;

        Console.WriteLine("Sum of numbers using while loop "+total);
        Console.WriteLine("sum of numbers using formula "+totalN);
    }
}