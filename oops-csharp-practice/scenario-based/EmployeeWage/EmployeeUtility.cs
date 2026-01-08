using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeWage.EmployeeWage;

namespace EmployeeWage.EmployeeWage
{
    internal class EmployeeUtility : IEmployee
    {
        private Employee[] obj = new Employee[50];
        int countEmployee = 0;
     

        //method to add the employee
        public void AddEmployees()
        {
            if (countEmployee >= obj.Length)
            {
                Console.WriteLine("Sorry Vacancy Full");

            }
            else
            {
                Employee emp = new Employee();
                Console.Write("Enter the name of the Employee: ");
                emp.SetEmpName(Console.ReadLine());

                Console.Write("Enter Employee Id: ");
                emp.SetEmpId(Console.ReadLine());

                obj[countEmployee] = emp;
                countEmployee++;
                Console.WriteLine("-----------Employee added-----------");
            }
        }

        //method to check the attendance
        public void CheckAttendance()
        {
            Random rand = new Random();
            for (int i = 0; i < countEmployee; i++)
            {
                int check = rand.Next(0, 2);
                if (check == 1)
                {
                    Console.WriteLine(obj[i].GetEmpName() + " is Present");
                }
                else
                {
                    Console.WriteLine(obj[i].GetEmpName() + " is Absent");
                }
            }
        }

        public void ShowDailyWages()
        {
            Random rand = new Random();

            for (int i = 0; i < countEmployee; i++)
            {
                Employee emp = obj[i];
                int check = rand.Next(0, 3); // 0 = Absent, 1 = PartTime, 2 = FullTime

                int workingHours = 0;
                string status = "";

                //Switch Case logic directly inside the loop
                switch (check)
                {
                    case 1:
                        workingHours = emp.PartTime;
                        status = "PartTime";
                        break;
                    case 2:
                        workingHours = emp.FullDay;
                        status = "FullTime";
                        break;
                    default:
                        workingHours = 0;
                        status = "Absent";
                        break;
                }

                double DailyWage = workingHours * emp.HourlyWage;

                Console.WriteLine($"Name: {emp.GetEmpName()}\nStatus: {status}\nWage: {DailyWage}");
            }
        }


        //method to calculate the monthly wages
        public void CalculateMonthlyWage()
        {
            Random rand = new Random();
            for (int i = 0; i < countEmployee; i++)
            {
                Employee emp = obj[i];
                int totalHours = 0;
                int totalDays = 0;

                while (totalDays < 20 && totalHours < 100)
                {
                    totalDays++;
                    int check = rand.Next(0, 3);
                    int dailyHours = 0;

                    switch (check)
                    {
                        case 1: 
                            dailyHours = emp.PartTime; 
                            break;
                        case 2: 
                            dailyHours = emp.FullDay; 
                            break;
                        default: 
                            dailyHours = 0; 
                            break;
                    }

                    if (totalHours + dailyHours > 100)
                    {
                        dailyHours = 100 - totalHours;
                    }
                    totalHours += dailyHours;
                }
                Console.WriteLine($"Name: {emp.GetEmpName()}\nDays: {totalDays}\nHours: {totalHours}\nTotal Wage: {totalHours * emp.HourlyWage}");
            }
        }



    }
}



