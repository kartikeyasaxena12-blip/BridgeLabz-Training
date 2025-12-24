using System;
class Youngest 
{
    static void Main(string[]args)
    {
        string[] name= {"Amar","Akbar","Anthony"};
        double[] age= new double[3];
        double[] height= new double[3];
        Console.WriteLine("Enter age");
        for(int i=0;i<3;i++)
        {
            age[i]=Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Enter height");
        for(int i=0;i<3;i++)
        {
            height[i]=Convert.ToDouble(Console.ReadLine());
        }
        int youngest=0;
        int tallest=0;
        for(int i=1;i<3;i++)
        {
            if (age[i]<age[youngest])
            {
                youngest=i;
            }

            if (height[i]>height[tallest])
            {
                tallest=i;
            }
        }
        Console.WriteLine("Youngest Friend = "+name[youngest]);
        Console.WriteLine("Tallest Friend = "+name[tallest]);
    }
}