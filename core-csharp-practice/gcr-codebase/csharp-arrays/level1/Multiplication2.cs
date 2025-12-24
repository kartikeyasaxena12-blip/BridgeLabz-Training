using System;
class Multiplication2
{
    static void Main(string[]args)
    {
        int number= Convert.ToInt32(Console.ReadLine());//input number
        int[] multi= new int[4];//initialize array
        for(int i=6;i<10;i++)
        {
            multi[i-6]=number*i;//adding multiplication table
        }
        Console.WriteLine(number+" * 6 "+" = "+multi[0]);//printing 
        Console.WriteLine(number+" * 7 "+" = "+multi[1]);//printing 
        Console.WriteLine(number+" * 8 "+" = "+multi[2]);//printing 
        Console.WriteLine(number+" * 9 "+" = "+multi[3]);//printing 
    }
}
