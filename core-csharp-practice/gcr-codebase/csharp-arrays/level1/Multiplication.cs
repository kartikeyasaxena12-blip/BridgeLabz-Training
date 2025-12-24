using System;
class Multiplication
{
    static void Main(string[]args)
    {
        int number= Convert.ToInt32(Console.ReadLine());//input number
        int[] multi= new int[10];//initialize array
        for(int i=0;i<10;i++)
        {
            multi[i]=number*(i+1);//adding multiplication table
        }
        for(int i=0;i<10;i++)
        {
            Console.WriteLine(number+" * "+(i+1)+" = "+multi[i]);//printing 
        }
    }
}