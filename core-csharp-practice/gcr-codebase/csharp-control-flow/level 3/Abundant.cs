using System;
class Abundant{
    static void Main(string[]args)
    {
        int number= Convert.ToInt32(Console.ReadLine()); //input number
        int sum=0;//to store sum of digits
        for(int i=1;i<number;i++)
        {
            if(number%i==0)
            {
                sum=sum+i;
            }
        }

        if(sum>number)
        {
            Console.WriteLine("Abundant Number");
        }
        else{
            Console.WriteLine("Not an Abundant Number");
        }
    }
}