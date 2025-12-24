using System;
class BMI
{
    static void Main()
    {
        Console.WriteLine("Enter number of persons:");
        int n = Convert.ToInt32(Console.ReadLine());//to input no of persons
        double[] weight = new double[n];
        double[] height = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];

        for (int i = 0; i < n; i++)//input height and weight
        {
            Console.WriteLine("\nPerson " + (i + 1));
            Console.WriteLine("Enter weight (kg): ");
            weight[i] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height (meters): ");
            height[i] = Convert.ToDouble(Console.ReadLine());
        }
        // calculate BMI
        for (int i = 0; i < n; i++)
        {
            bmi[i] = weight[i] / (height[i] * height[i]);
            if (bmi[i] <= 18.4)
                status[i] = "Underweight";
            else if (bmi[i] <= 24.9)
                status[i] = "Normal";
            else if (bmi[i] <= 39.9)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nPerson " + (i + 1));
            Console.WriteLine("Height : " + height[i] + " meters");
            Console.WriteLine("Weight : " + weight[i] + " kg");
            Console.WriteLine("BMI    : " + bmi[i]);
            Console.WriteLine("Status : " + status[i]);
        }
    }
}
