using System;
class MultipleNumber
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter a Number");
        int number= Convert.ToInt32(Console.ReadLine());// input 
        for(int i=100;i>=number;i--)//for loop
        {
            if(i%number==0)
            {
                Console.WriteLine(i);//print 
            }
        }
    }
}