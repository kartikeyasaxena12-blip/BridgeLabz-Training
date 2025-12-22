using System;
class OddEven
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter a number"); 
        int num= Convert.ToInt32(Console.ReadLine()); //input number

        if(num<0) // if num is not natural
        {
            Console.WriteLine("Not a Natural Number");
        }
        for(int i=1;i<=num;i++) //for loop
        {
            if(i%2==0) //even condition
            {
                Console.WriteLine(i+" Even");
            }
            else //odd condition
            {
                Console.WriteLine(i+" Odd");
            }
        }
    }
    
}