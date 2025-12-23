using System;
class NumberOfDigits{
    static void Main(string[]args)
    {
        int num= Convert.ToInt32(Console.ReadLine()); //input number
        int sum=0;//to store sum of digits
        int temp=num;
        while(num!=0)
        {
            int remainder=num%10;
            sum=sum+remainder;
            num=num/10;
        }
        if(temp%sum==0)
        {
            Console.WriteLine("Harshad Number");
        }
        else{
            Console.WriteLine("Not a Harshad Number");
        }
    }
}