using System;
class GreatestFactor
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter a Number");
        int num= Convert.ToInt32(Console.ReadLine());// input 
        int greatest=0;//to store greatest factor
        for(int i=num-1;i>=1;i--)
        {
            if(num%i==0)
            {
                greatest=i;
                break;
            }
        }
        Console.WriteLine("Greatest Factor = "+greatest);
    }
}