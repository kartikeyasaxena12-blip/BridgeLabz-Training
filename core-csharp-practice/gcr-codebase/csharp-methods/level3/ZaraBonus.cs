using System;
class ZaraBonus
{
    static Random random = new Random();

    public static int[,] GenerateEmployeesData()
    {
        int[,] employees = new int[10, 2]; 
        for (int i = 0; i < 10; i++)
        {
            employees[i, 0] = random.Next(10000, 100000); 
            employees[i, 1] = random.Next(1, 11);          
        }
        return employees;
    }

    // Method to calculate new salary and bonus
    public static double[,] CalculateNewSalaryAndBonus(int[,] employees)
    {
        double[,] updatedData = new double[10, 2]; 
        for (int i = 0; i < 10; i++)
        {
            double bonusPercent = employees[i, 1] > 5 ? 0.05 : 0.02;
            double bonus = employees[i, 0] * bonusPercent;
            updatedData[i, 0] = employees[i, 0] + bonus;
            updatedData[i, 1] = bonus;
        }
        return updatedData;
    }

    // Method to display employee details and totals
    public static void PrintEmployeeBonuses(int[,] employees, double[,] updatedData)
    {
        double totalOldSalary = 0, totalNewSalary = 0, totalBonus = 0;

        for (int i = 0; i < 10; i++)
        {
            totalOldSalary += employees[i, 0];
            totalBonus += updatedData[i, 1];
            totalNewSalary += updatedData[i, 0];

            Console.WriteLine("Employee " + (i + 1) +": Old Salary = " + employees[i, 0] +", Years of Service = " + employees[i, 1] +", Bonus = " + Math.Round(updatedData[i, 1], 2) +", New Salary = " + Math.Round(updatedData[i, 0], 2));
        }

        Console.WriteLine("\nTotal Old Salary: " + totalOldSalary);
        Console.WriteLine("Total Bonus Paid: " + Math.Round(totalBonus, 2));
        Console.WriteLine("Total New Salary: " + Math.Round(totalNewSalary, 2));
    }

    static void Main()
    {
        int[,] employees = GenerateEmployeesData();
        double[,] updatedData = CalculateNewSalaryAndBonus(employees);
        PrintEmployeeBonuses(employees, updatedData);
    }
}
