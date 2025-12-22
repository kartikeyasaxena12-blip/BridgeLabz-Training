using System;
class FactorsNumber
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter a Number");
        int number= Convert.ToInt32(Console.ReadLine());// input 
        for(int i=1;i<number;i++)
        {
            if(number%i==0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
