using System;
class PowerNumber
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter a Number");
        int num= Convert.ToInt32(Console.ReadLine());// input 
        Console.WriteLine("Enter power");
        int pow= Convert.ToInt32(Console.ReadLine());//input power
        int result=1;
        for(int i=1;i<=pow;i++)
        {
            result= result*num;
        }
        Console.WriteLine(result);
    }
}
