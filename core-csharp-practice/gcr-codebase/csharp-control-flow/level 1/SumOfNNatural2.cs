using System;
class SumOfNNatural2
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter a number"); 
        int num= Convert.ToInt32(Console.ReadLine()); //input number
        int total=0; // sum of numbers using while loop
        int temp=num;
        if(num>0) // check for natural number
        {
            Console.WriteLine("It's a Natural Number");
            for(int i=num;i>0;i--)
            {
                total=total+i;
            }
            int totalN= (temp*(temp+1))/2;

            Console.WriteLine("Sum of numbers using while loop "+total);
            Console.WriteLine("sum of numbers using formula "+totalN);
        }
        else{
            Console.WriteLine("It's not a natural number");
        }

        
    }
}