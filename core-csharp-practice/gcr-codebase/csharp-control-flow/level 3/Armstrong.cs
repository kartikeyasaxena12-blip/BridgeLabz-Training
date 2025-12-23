using System;
class Armstrong{
    static void Main(string[]args)
    {
        int num= Convert.ToInt32(Console.ReadLine()); //input number
        int armStrong=0;// to store armstrong number
        int temp=num;
        int r=0;//to store remainder
        while(num!=0)
        {
            r=num%10;
            armStrong= armStrong+(r*r*r);
            num=num/10;
        }
        if(temp==armStrong)
        {
            Console.WriteLine("It's an Armstrong number");
        }
        else{
            Console.WriteLine("It's not an Armstrong number");
        }

    }
}