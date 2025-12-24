using System;
class Bonus 
{
    static void Main(string[]args)
    {
        double[] salary= new double[10];//input salary
        double[] years= new double[10];//input years of service
        double[] new_salary= new double[10];
        double[] bonus= new double[10];
        double bon=0.0;//to store total bonus
        Console.WriteLine("Enter salary");
        for(int i=0;i<10;i++)
        {
            salary[i]=Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Enter years of service");
        for(int i=0;i<10;i++)
        {
            years[i]=Convert.ToDouble(Console.ReadLine());
        }
        for(int i=0;i<10;i++)
        {
            if(years[i]>5)//if years of service>5
            {
                bonus[i]=salary[i]*0.05;
                new_salary[i]=salary[i]+bonus[i];
                bon=bon+bonus[i];
            }
            else
            {
                bonus[i]=salary[i]*0.02;
                new_salary[i]=salary[i]+bonus[i];
                bon=bon+bonus[i];
            }
        }

        for(int i=0;i<10;i++)
        {
            Console.WriteLine("Old Salary of employee "+(i+1)+"="+salary[i]+" and new salary = "+new_salary[i]);
        }
        Console.WriteLine("Total Bonus = "+bon);//printing total bonus



    }
}