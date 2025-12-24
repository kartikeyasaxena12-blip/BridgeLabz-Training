using System;
class Grade
{
    static void Main()
    {
        Console.WriteLine("Enter number of students:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] marks = new int[n, 3];   // 0-Physics, 1-Chemistry, 2-Maths
        double[] percentage = new double[n];
        char[] grade = new char[n];

        for (int i = 0; i < n; i++)//input
        {
            Console.WriteLine("\nStudent " + (i + 1));
            for (int j = 0; j < 3; j++)
            {
                string subject = (j == 0) ? "Physics" :
                                 (j == 1) ? "Chemistry" : "Maths";

                Console.Write("Enter marks in " + subject + ": ");
                int value = Convert.ToInt32(Console.ReadLine());
                if (value < 0)
                {
                    Console.WriteLine("Marks must be positive. Enter again.");
                    j--;  //decrementing index to re-enter
                }
                else
                {
                    marks[i, j] = value;
                }
            }
        }
        // Calculate percentage and grade
        for (int i = 0; i < n; i++)
        {
            int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentage[i] = total / 3.0;

            if (percentage[i] >= 80)
                grade[i] = 'A';
            else if (percentage[i] >= 70)
                grade[i] = 'B';
            else if (percentage[i] >= 60)
                grade[i] = 'C';
            else if (percentage[i] >= 50)
                grade[i] = 'D';
            else if (percentage[i] >= 40)
                grade[i] = 'E';
            else
                grade[i] = 'R';
        }
        for (int i = 0; i < n; i++)//printing
        {
            Console.WriteLine("\nStudent " + (i + 1));
            Console.WriteLine("Physics   : " + marks[i, 0]);
            Console.WriteLine("Chemistry : " + marks[i, 1]);
            Console.WriteLine("Maths     : " + marks[i, 2]);
            Console.WriteLine("Percentage: " + percentage[i]);
            Console.WriteLine("Grade     : " + grade[i]);
        }
    }
}
