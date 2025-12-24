using System;
class MeanHeight
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter Height");
        double[] height= new double[11];//initialize array
        double sum=0;//to store sum of heights
        for(int i=0;i<11;i++)
        {
            height[i]=Convert.ToDouble(Console.ReadLine());//to store height
            sum=sum+height[i];
        } 
        double mean= sum/11; // calculating mean of heights
        Console.WriteLine("Mean = "+mean);
    }
}

