using System;
class NumberOfDigits{
    static void Main(string[]args)
    {
        int num= Convert.ToInt32(Console.ReadLine()); //input number
        int count=0;
        while(num!=0)
        {
            count++;//count no of digits
            num=num/10;
        }
        Console.WriteLine("Number of Digits = "+count);//printing number of digits
    }
}
