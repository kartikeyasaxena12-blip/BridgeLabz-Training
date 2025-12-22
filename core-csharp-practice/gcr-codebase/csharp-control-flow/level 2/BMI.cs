using System;
class BMI
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter Weight in kg");
        double weight= Convert.ToDouble(Console.ReadLine());// input weight
        Console.WriteLine("Enter height in cm");
        double height= Convert.ToDouble(Console.ReadLine());
        height = height/100; //converting cm to meter
        double bmi= weight/(height*height);
        if(bmi<=18.4)
        {
            Console.WriteLine("Underweight");
        }
        else if(bmi>=18.5 && bmi<=24.9)
        {
            Console.WriteLine("Normal");
        }
        else if(bmi>=25.0 && bmi<=39.9)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }
    }
}