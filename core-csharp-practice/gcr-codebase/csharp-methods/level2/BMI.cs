using System;
class BMI
{
    static void CalculateBMI(double[,] data) // Calculate BMI
    {
        for (int i = 0; i < 10; i++)
        {
            double heightInMeters = data[i, 1] / 100; 
            data[i, 2] = data[i, 0] / (heightInMeters * heightInMeters); 
        }
    }

    static string GetBMIStatus(double bmi) // BMI status
    {
        if (bmi <= 18.4) return "Underweight";
        else if (bmi <= 24.9) return "Normal";
        else if (bmi <= 39.9) return "Overweight";
        else return "Obese";
    }

    static void Main()
    {
        double[,] persons = new double[10, 3]; 

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter weight (kg) of person " + (i + 1) + ": ");
            while (!double.TryParse(Console.ReadLine(), out persons[i, 0]) || persons[i, 0] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid weight (positive number).");
                Console.Write("Enter weight (kg) of person " + (i + 1) + ": ");
            }

            Console.Write("Enter height (cm) of person " + (i + 1) + ": ");
            while (!double.TryParse(Console.ReadLine(), out persons[i, 1]) || persons[i, 1] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid height (positive number).");
                Console.Write("Enter height (cm) of person " + (i + 1) + ": ");
            }
        }

        CalculateBMI(persons); // Calculate BMI for all persons

        Console.WriteLine("\nBMI Details:");

        for (int i = 0; i < 10; i++)
        {
            string status = GetBMIStatus(persons[i, 2]);

            Console.WriteLine("Person " + (i + 1) +" Weight: " + persons[i, 0] + " kg" +" Height: " + persons[i, 1] + " cm" +" BMI: " + persons[i, 2].ToString("F2") + " Status: " + status);
        }
    }
}
