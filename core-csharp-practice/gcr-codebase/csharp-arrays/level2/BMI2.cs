using System;
class BMIProgram
{
    static void Main()
    {
        Console.Write("Enter number of persons: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[][] personData = new double[n][];
        string[] status = new string[n];
        for (int i = 0; i < n; i++)
            personData[i] = new double[3];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nPerson " + (i + 1));
            do
            {
                Console.Write("Weight: ");
                personData[i][0] = Convert.ToDouble(Console.ReadLine());
            } while (personData[i][0] <= 0);

            do
            {
                Console.Write("Height: ");
                personData[i][1] = Convert.ToDouble(Console.ReadLine());
            } while (personData[i][1] <= 0);

            personData[i][2] = personData[i][0] /
                               (personData[i][1] * personData[i][1]);

            if (personData[i][2] <= 18.4) status[i] = "Underweight";
            else if (personData[i][2] <= 24.9) status[i] = "Normal";
            else if (personData[i][2] <= 39.9) status[i] = "Overweight";
            else status[i] = "Obese";
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nPerson " + (i + 1));
            Console.WriteLine("Weight : " + personData[i][0]);
            Console.WriteLine("Height : " + personData[i][1]);
            Console.WriteLine("BMI    : " + personData[i][2]);
            Console.WriteLine("Status : " + status[i]);
        }
    }
}
